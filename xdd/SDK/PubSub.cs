using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Whistler.SDK
{
    public class Hub
    {
        private Dictionary<string, List<Handler>> _handlers = new Dictionary<string, List<Handler>>();
        private object _locker = new object();
        private static Hub _default;

        public static Hub Default => _default ?? (_default = new Hub());
        
        public void Publish(PubSubEvent data)
        {
            if (!_handlers.ContainsKey(data.EventName)) return;
            foreach (var handler in GetAliveHandlers(data.EventName))
            {
                switch (handler.Action)
                {
                    case Action<PubSubEvent> action:
                        action(data);
                        break;
                    case Func<PubSubEvent, Task> func:
                        func(data);
                        break;
                }
            }
        }

        public async Task PublishAsync(string eventName, PubSubEvent data)
        {
            if (!_handlers.ContainsKey(data.EventName)) return;
            foreach (var handler in GetAliveHandlers(data.EventName))
            {
                switch (handler.Action)
                {
                    case Action<PubSubEvent> action:
                        action(data);
                        break;
                    case Func<PubSubEvent, Task> func:
                        await func(data);
                        break;
                }
            }
        }

        /// <summary>
        ///     Allow subscribing directly to this Hub.
        /// </summary>
        /// <param name="handler"></param>
        public void Subscribe(string eventName, Action<PubSubEvent> handler)
        {
            Subscribe(this, eventName, handler);
        }

        public void Subscribe(object subscriber, string eventName, Action<PubSubEvent> handler)
        {
            SubscribeDelegate(subscriber, eventName, handler);
        }

        public void Subscribe(string eventName, Func<PubSubEvent, Task> handler)
        {
            Subscribe(this, eventName, handler);
        }

        public void Subscribe(object subscriber, string eventName, Func<PubSubEvent, Task> handler)
        {
            SubscribeDelegate(subscriber, eventName, handler);
        }

        /// <summary>
        ///     Allow unsubscribing directly to this Hub.
        /// </summary>
        public void Unsubscribe(string eventName)
        {
            Unsubscribe(this, eventName);
        }

        /// <summary>
        ///     Allow unsubscribing directly to this Hub.
        /// </summary>
        /// <param name="handler"></param>
        public void Unsubscribe<T>(string eventName, Action<PubSubEvent> handler)
        {
            Unsubscribe(this, eventName, handler);
        }

        public void Unsubscribe(object subscriber, string eventName, Action<PubSubEvent> handler = null)
        {
            lock (_locker)
            {
                if (!_handlers.ContainsKey(eventName)) {
                    throw new Exception("Event category doesn't exist");
                }
                var query = _handlers[eventName].Where(a => !a.Sender.IsAlive ||
                                                a.Sender.Target.Equals(subscriber));

                if (handler != null)
                    query = query.Where(a => a.Action.Equals(handler));

                foreach (var h in query.ToList())
                    _handlers[eventName].Remove(h);
            }
        }

        private void SubscribeDelegate(object subscriber, string eventName, Delegate handler)
        {
            var item = new Handler
            {
                Action = handler,
                Sender = new WeakReference(subscriber)
            };

            lock (_locker)
            {
                if (!_handlers.ContainsKey(eventName)) {
                    _handlers.Add(eventName, new List<Handler>());
                }
                _handlers[eventName].Add(item);
            }
        }

        private List<Handler> GetAliveHandlers(string eventName)
        {
            PruneHandlers(eventName);
            return _handlers[eventName];
        }

        private void PruneHandlers(string eventName)
        {
            lock (_locker)
            {
                var events = _handlers[eventName];
                for (int i = events.Count - 1; i >= 0; --i)
                {
                    if (!events[i].Sender.IsAlive)
                        events.RemoveAt(i);
                }
            }
        }

        internal class Handler
        {
            public Delegate Action { get; set; }
            public WeakReference Sender { get; set; }
        }
    }

    public class PubSubEvent {
        public string EventName { get; set; }
        public Dictionary<String, object> Payload = new Dictionary<string, object>();
    }
}