﻿using GTANetworkAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Whistler.VehicleSystem.Models.Configs
{
    class VehicleModels
    {
        /// <summary>
        /// Список стандартных авто (нужен потому что в VehicleHash не все)
        /// </summary>
        public static Dictionary<uint, string> VehicleModelNames = new Dictionary<uint, string>()
        {
            {NAPI.Util.GetHashKey("adder"),"adder"},
            {NAPI.Util.GetHashKey("airbus"),"airbus"},
            {NAPI.Util.GetHashKey("airtug"),"airtug"},
            {NAPI.Util.GetHashKey("akula"),"akula"},
            {NAPI.Util.GetHashKey("akuma"),"akuma"},
            {NAPI.Util.GetHashKey("alpha"),"alpha"},
            {NAPI.Util.GetHashKey("alphaz1"),"alphaz1"},
            {NAPI.Util.GetHashKey("ambulance"),"ambulance"},
            {NAPI.Util.GetHashKey("annihilator"),"annihilator"},
            {NAPI.Util.GetHashKey("apc"),"apc"},
            {NAPI.Util.GetHashKey("ardent"),"ardent"},
            {NAPI.Util.GetHashKey("armytanker"),"armytanker"},
            {NAPI.Util.GetHashKey("armytrailer"),"armytrailer"},
            {NAPI.Util.GetHashKey("armytrailer2"),"armytrailer2"},
            {NAPI.Util.GetHashKey("asbo"),"asbo"},
            {NAPI.Util.GetHashKey("asea"),"asea"},
            {NAPI.Util.GetHashKey("asea2"),"asea2"},
            {NAPI.Util.GetHashKey("asterope"),"asterope"},
            {NAPI.Util.GetHashKey("autarch"),"autarch"},
            {NAPI.Util.GetHashKey("avarus"),"avarus"},
            {NAPI.Util.GetHashKey("avenger"),"avenger"},
            {NAPI.Util.GetHashKey("avenger2"),"avenger2"},
            {NAPI.Util.GetHashKey("bagger"),"bagger"},
            {NAPI.Util.GetHashKey("baletrailer"),"baletrailer"},
            {NAPI.Util.GetHashKey("baller"),"baller"},
            {NAPI.Util.GetHashKey("baller2"),"baller2"},
            {NAPI.Util.GetHashKey("baller3"),"baller3"},
            {NAPI.Util.GetHashKey("baller4"),"baller4"},
            {NAPI.Util.GetHashKey("baller5"),"baller5"},
            {NAPI.Util.GetHashKey("baller6"),"baller6"},
            {NAPI.Util.GetHashKey("banshee"),"banshee"},
            {NAPI.Util.GetHashKey("banshee2"),"banshee2"},
            {NAPI.Util.GetHashKey("barracks"),"barracks"},
            {NAPI.Util.GetHashKey("barracks2"),"barracks2"},
            {NAPI.Util.GetHashKey("barracks3"),"barracks3"},
            {NAPI.Util.GetHashKey("barrage"),"barrage"},
            {NAPI.Util.GetHashKey("bati"),"bati"},
            {NAPI.Util.GetHashKey("bati2"),"bati2"},
            {NAPI.Util.GetHashKey("benson"),"benson"},
            {NAPI.Util.GetHashKey("besra"),"besra"},
            {NAPI.Util.GetHashKey("bestiagts"),"bestiagts"},
            {NAPI.Util.GetHashKey("bf400"),"bf400"},
            {NAPI.Util.GetHashKey("bfinjection"),"bfinjection"},
            {NAPI.Util.GetHashKey("biff"),"biff"},
            {NAPI.Util.GetHashKey("bifta"),"bifta"},
            {NAPI.Util.GetHashKey("bison"),"bison"},
            {NAPI.Util.GetHashKey("bison2"),"bison2"},
            {NAPI.Util.GetHashKey("bison3"),"bison3"},
            {NAPI.Util.GetHashKey("bjxl"),"bjxl"},
            {NAPI.Util.GetHashKey("blade"),"blade"},
            {NAPI.Util.GetHashKey("blazer"),"blazer"},
            {NAPI.Util.GetHashKey("blazer2"),"blazer2"},
            {NAPI.Util.GetHashKey("blazer3"),"blazer3"},
            {NAPI.Util.GetHashKey("blazer4"),"blazer4"},
            {NAPI.Util.GetHashKey("blazer5"),"blazer5"},
            {NAPI.Util.GetHashKey("blimp"),"blimp"},
            {NAPI.Util.GetHashKey("blimp2"),"blimp2"},
            {NAPI.Util.GetHashKey("blimp3"),"blimp3"},
            {NAPI.Util.GetHashKey("blista"),"blista"},
            {NAPI.Util.GetHashKey("blista2"),"blista2"},
            {NAPI.Util.GetHashKey("blista3"),"blista3"},
            {NAPI.Util.GetHashKey("bmx"),"bmx"},
            {NAPI.Util.GetHashKey("boattrailer"),"boattrailer"},
            {NAPI.Util.GetHashKey("bobcatxl"),"bobcatxl"},
            {NAPI.Util.GetHashKey("bodhi2"),"bodhi2"},
            {NAPI.Util.GetHashKey("bombushka"),"bombushka"},
            {NAPI.Util.GetHashKey("boxville"),"boxville"},
            {NAPI.Util.GetHashKey("boxville2"),"boxville2"},
            {NAPI.Util.GetHashKey("boxville3"),"boxville3"},
            {NAPI.Util.GetHashKey("boxville4"),"boxville4"},
            {NAPI.Util.GetHashKey("boxville5"),"boxville5"},
            {NAPI.Util.GetHashKey("brawler"),"brawler"},
            {NAPI.Util.GetHashKey("brickade"),"brickade"},
            {NAPI.Util.GetHashKey("brioso"),"brioso"},
            {NAPI.Util.GetHashKey("bruiser"),"bruiser"},
            {NAPI.Util.GetHashKey("bruiser2"),"bruiser2"},
            {NAPI.Util.GetHashKey("bruiser3"),"bruiser3"},
            {NAPI.Util.GetHashKey("brutus"),"brutus"},
            {NAPI.Util.GetHashKey("brutus2"),"brutus2"},
            {NAPI.Util.GetHashKey("brutus3"),"brutus3"},
            {NAPI.Util.GetHashKey("btype"),"btype"},
            {NAPI.Util.GetHashKey("btype2"),"btype2"},
            {NAPI.Util.GetHashKey("btype3"),"btype3"},
            {NAPI.Util.GetHashKey("buccaneer"),"buccaneer"},
            {NAPI.Util.GetHashKey("buccaneer2"),"buccaneer2"},
            {NAPI.Util.GetHashKey("buffalo"),"buffalo"},
            {NAPI.Util.GetHashKey("buffalo2"),"buffalo2"},
            {NAPI.Util.GetHashKey("buffalo3"),"buffalo3"},
            {NAPI.Util.GetHashKey("bulldozer"),"bulldozer"},
            {NAPI.Util.GetHashKey("bullet"),"bullet"},
            {NAPI.Util.GetHashKey("burrito"),"burrito"},
            {NAPI.Util.GetHashKey("burrito2"),"burrito2"},
            {NAPI.Util.GetHashKey("burrito3"),"burrito3"},
            {NAPI.Util.GetHashKey("burrito4"),"burrito4"},
            {NAPI.Util.GetHashKey("burrito5"),"burrito5"},
            {NAPI.Util.GetHashKey("bus"),"bus"},
            {NAPI.Util.GetHashKey("buzzard"),"buzzard"},
            {NAPI.Util.GetHashKey("buzzard2"),"buzzard2"},
            {NAPI.Util.GetHashKey("cablecar"),"cablecar"},
            {NAPI.Util.GetHashKey("caddy"),"caddy"},
            {NAPI.Util.GetHashKey("caddy2"),"caddy2"},
            {NAPI.Util.GetHashKey("caddy3"),"caddy3"},
            {NAPI.Util.GetHashKey("camper"),"camper"},
            {NAPI.Util.GetHashKey("caracara"),"caracara"},
            {NAPI.Util.GetHashKey("caracara2"),"caracara2"},
            {NAPI.Util.GetHashKey("carbonizzare"),"carbonizzare"},
            {NAPI.Util.GetHashKey("carbonrs"),"carbonrs"},
            {NAPI.Util.GetHashKey("cargobob"),"cargobob"},
            {NAPI.Util.GetHashKey("cargobob2"),"cargobob2"},
            {NAPI.Util.GetHashKey("cargobob3"),"cargobob3"},
            {NAPI.Util.GetHashKey("cargobob4"),"cargobob4"},
            {NAPI.Util.GetHashKey("cargoplane"),"cargoplane"},
            {NAPI.Util.GetHashKey("casco"),"casco"},
            {NAPI.Util.GetHashKey("cavalcade"),"cavalcade"},
            {NAPI.Util.GetHashKey("cavalcade2"),"cavalcade2"},
            {NAPI.Util.GetHashKey("cerberus"),"cerberus"},
            {NAPI.Util.GetHashKey("cerberus2"),"cerberus2"},
            {NAPI.Util.GetHashKey("cerberus3"),"cerberus3"},
            {NAPI.Util.GetHashKey("cheburek"),"cheburek"},
            {NAPI.Util.GetHashKey("cheetah"),"cheetah"},
            {NAPI.Util.GetHashKey("cheetah2"),"cheetah2"},
            {NAPI.Util.GetHashKey("chernobog"),"chernobog"},
            {NAPI.Util.GetHashKey("chimera"),"chimera"},
            {NAPI.Util.GetHashKey("chino"),"chino"},
            {NAPI.Util.GetHashKey("chino2"),"chino2"},
            {NAPI.Util.GetHashKey("cliffhanger"),"cliffhanger"},
            {NAPI.Util.GetHashKey("clique"),"clique"},
            {NAPI.Util.GetHashKey("coach"),"coach"},
            {NAPI.Util.GetHashKey("cog55"),"cog55"},
            {NAPI.Util.GetHashKey("cog552"),"cog552"},
            {NAPI.Util.GetHashKey("cogcabrio"),"cogcabrio"},
            {NAPI.Util.GetHashKey("cognoscenti"),"cognoscenti"},
            {NAPI.Util.GetHashKey("cognoscenti2"),"cognoscenti2"},
            {NAPI.Util.GetHashKey("comet2"),"comet2"},
            {NAPI.Util.GetHashKey("comet3"),"comet3"},
            {NAPI.Util.GetHashKey("comet4"),"comet4"},
            {NAPI.Util.GetHashKey("comet5"),"comet5"},
            {NAPI.Util.GetHashKey("contender"),"contender"},
            {NAPI.Util.GetHashKey("coquette"),"coquette"},
            {NAPI.Util.GetHashKey("coquette2"),"coquette2"},
            {NAPI.Util.GetHashKey("coquette3"),"coquette3"},
            {NAPI.Util.GetHashKey("cruiser"),"cruiser"},
            {NAPI.Util.GetHashKey("crusader"),"crusader"},
            {NAPI.Util.GetHashKey("cuban800"),"cuban800"},
            {NAPI.Util.GetHashKey("cutter"),"cutter"},
            {NAPI.Util.GetHashKey("cyclone"),"cyclone"},
            {NAPI.Util.GetHashKey("daemon"),"daemon"},
            {NAPI.Util.GetHashKey("daemon2"),"daemon2"},
            {NAPI.Util.GetHashKey("deathbike"),"deathbike"},
            {NAPI.Util.GetHashKey("deathbike2"),"deathbike2"},
            {NAPI.Util.GetHashKey("deathbike3"),"deathbike3"},
            {NAPI.Util.GetHashKey("defiler"),"defiler"},
            {NAPI.Util.GetHashKey("deluxo"),"deluxo"},
            {NAPI.Util.GetHashKey("deveste"),"deveste"},
            {NAPI.Util.GetHashKey("deviant"),"deviant"},
            {NAPI.Util.GetHashKey("diablous"),"diablous"},
            {NAPI.Util.GetHashKey("diablous2"),"diablous2"},
            {NAPI.Util.GetHashKey("dilettante"),"dilettante"},
            {NAPI.Util.GetHashKey("dilettante2"),"dilettante2"},
            {NAPI.Util.GetHashKey("dinghy"),"dinghy"},
            {NAPI.Util.GetHashKey("dinghy2"),"dinghy2"},
            {NAPI.Util.GetHashKey("dinghy3"),"dinghy3"},
            {NAPI.Util.GetHashKey("dinghy4"),"dinghy4"},
            {NAPI.Util.GetHashKey("dloader"),"dloader"},
            {NAPI.Util.GetHashKey("docktrailer"),"docktrailer"},
            {NAPI.Util.GetHashKey("docktug"),"docktug"},
            {NAPI.Util.GetHashKey("dodo"),"dodo"},
            {NAPI.Util.GetHashKey("dominator"),"dominator"},
            {NAPI.Util.GetHashKey("dominator2"),"dominator2"},
            {NAPI.Util.GetHashKey("dominator3"),"dominator3"},
            {NAPI.Util.GetHashKey("dominator4"),"dominator4"},
            {NAPI.Util.GetHashKey("dominator5"),"dominator5"},
            {NAPI.Util.GetHashKey("dominator6"),"dominator6"},
            {NAPI.Util.GetHashKey("double"),"double"},
            {NAPI.Util.GetHashKey("drafter"),"drafter"},
            {NAPI.Util.GetHashKey("dubsta"),"dubsta"},
            {NAPI.Util.GetHashKey("dubsta2"),"dubsta2"},
            {NAPI.Util.GetHashKey("dubsta3"),"dubsta3"},
            {NAPI.Util.GetHashKey("dukes"),"dukes"},
            {NAPI.Util.GetHashKey("dukes2"),"dukes2"},
            {NAPI.Util.GetHashKey("dump"),"dump"},
            {NAPI.Util.GetHashKey("dune"),"dune"},
            {NAPI.Util.GetHashKey("dune2"),"dune2"},
            {NAPI.Util.GetHashKey("dune3"),"dune3"},
            {NAPI.Util.GetHashKey("dune4"),"dune4"},
            {NAPI.Util.GetHashKey("dune5"),"dune5"},
            {NAPI.Util.GetHashKey("duster"),"duster"},
            {NAPI.Util.GetHashKey("dynasty"),"dynasty"},
            {NAPI.Util.GetHashKey("elegy"),"elegy"},
            {NAPI.Util.GetHashKey("elegy2"),"elegy2"},
            {NAPI.Util.GetHashKey("ellie"),"ellie"},
            {NAPI.Util.GetHashKey("emerus"),"emerus"},
            {NAPI.Util.GetHashKey("emperor"),"emperor"},
            {NAPI.Util.GetHashKey("emperor2"),"emperor2"},
            {NAPI.Util.GetHashKey("emperor3"),"emperor3"},
            {NAPI.Util.GetHashKey("enduro"),"enduro"},
            {NAPI.Util.GetHashKey("entity2"),"entity2"},
            {NAPI.Util.GetHashKey("entityxf"),"entityxf"},
            {NAPI.Util.GetHashKey("esskey"),"esskey"},
            {NAPI.Util.GetHashKey("everon"),"everon"},
            {NAPI.Util.GetHashKey("exemplar"),"exemplar"},
            {NAPI.Util.GetHashKey("f620"),"f620"},
            {NAPI.Util.GetHashKey("faction"),"faction"},
            {NAPI.Util.GetHashKey("faction2"),"faction2"},
            {NAPI.Util.GetHashKey("faction3"),"faction3"},
            {NAPI.Util.GetHashKey("fagaloa"),"fagaloa"},
            {NAPI.Util.GetHashKey("faggio"),"faggio"},
            {NAPI.Util.GetHashKey("faggio2"),"faggio2"},
            {NAPI.Util.GetHashKey("faggio3"),"faggio3"},
            {NAPI.Util.GetHashKey("fbi"),"fbi"},
            {NAPI.Util.GetHashKey("fbi2"),"fbi2"},
            {NAPI.Util.GetHashKey("fcr"),"fcr"},
            {NAPI.Util.GetHashKey("fcr2"),"fcr2"},
            {NAPI.Util.GetHashKey("felon"),"felon"},
            {NAPI.Util.GetHashKey("felon2"),"felon2"},
            {NAPI.Util.GetHashKey("feltzer2"),"feltzer2"},
            {NAPI.Util.GetHashKey("feltzer3"),"feltzer3"},
            {NAPI.Util.GetHashKey("firetruk"),"firetruk"},
            {NAPI.Util.GetHashKey("fixter"),"fixter"},
            {NAPI.Util.GetHashKey("flashgt"),"flashgt"},
            {NAPI.Util.GetHashKey("flatbed"),"flatbed"},
            {NAPI.Util.GetHashKey("fmj"),"fmj"},
            {NAPI.Util.GetHashKey("forklift"),"forklift"},
            {NAPI.Util.GetHashKey("formula"),"formula"},
            {NAPI.Util.GetHashKey("formula2"),"formula2"},
            {NAPI.Util.GetHashKey("fq2"),"fq2"},
            {NAPI.Util.GetHashKey("freecrawler"),"freecrawler"},
            {NAPI.Util.GetHashKey("freight"),"freight"},
            {NAPI.Util.GetHashKey("freightcar"),"freightcar"},
            {NAPI.Util.GetHashKey("freightcont1"),"freightcont1"},
            {NAPI.Util.GetHashKey("freightcont2"),"freightcont2"},
            {NAPI.Util.GetHashKey("freightgrain"),"freightgrain"},
            {NAPI.Util.GetHashKey("freighttrailer"),"freighttrailer"},
            {NAPI.Util.GetHashKey("frogger"),"frogger"},
            {NAPI.Util.GetHashKey("frogger2"),"frogger2"},
            {NAPI.Util.GetHashKey("fugitive"),"fugitive"},
            {NAPI.Util.GetHashKey("furia"),"furia"},
            {NAPI.Util.GetHashKey("furoregt"),"furoregt"},
            {NAPI.Util.GetHashKey("fusilade"),"fusilade"},
            {NAPI.Util.GetHashKey("futo"),"futo"},
            {NAPI.Util.GetHashKey("gargoyle"),"gargoyle"},
            {NAPI.Util.GetHashKey("gauntlet"),"gauntlet"},
            {NAPI.Util.GetHashKey("gauntlet2"),"gauntlet2"},
            {NAPI.Util.GetHashKey("gauntlet3"),"gauntlet3"},
            {NAPI.Util.GetHashKey("gauntlet4"),"gauntlet4"},
            {NAPI.Util.GetHashKey("gb200"),"gb200"},
            {NAPI.Util.GetHashKey("gburrito"),"gburrito"},
            {NAPI.Util.GetHashKey("gburrito2"),"gburrito2"},
            {NAPI.Util.GetHashKey("glendale"),"glendale"},
            {NAPI.Util.GetHashKey("gp1"),"gp1"},
            {NAPI.Util.GetHashKey("graintrailer"),"graintrailer"},
            {NAPI.Util.GetHashKey("granger"),"granger"},
            {NAPI.Util.GetHashKey("gresley"),"gresley"},
            {NAPI.Util.GetHashKey("gt500"),"gt500"},
            {NAPI.Util.GetHashKey("guardian"),"guardian"},
            {NAPI.Util.GetHashKey("habanero"),"habanero"},
            {NAPI.Util.GetHashKey("hakuchou"),"hakuchou"},
            {NAPI.Util.GetHashKey("hakuchou2"),"hakuchou2"},
            {NAPI.Util.GetHashKey("halftrack"),"halftrack"},
            {NAPI.Util.GetHashKey("handler"),"handler"},
            {NAPI.Util.GetHashKey("hauler"),"hauler"},
            {NAPI.Util.GetHashKey("hauler2"),"hauler2"},
            {NAPI.Util.GetHashKey("havok"),"havok"},
            {NAPI.Util.GetHashKey("hellion"),"hellion"},
            {NAPI.Util.GetHashKey("hermes"),"hermes"},
            {NAPI.Util.GetHashKey("hexer"),"hexer"},
            {NAPI.Util.GetHashKey("hotknife"),"hotknife"},
            {NAPI.Util.GetHashKey("hotring"),"hotring"},
            {NAPI.Util.GetHashKey("howard"),"howard"},
            {NAPI.Util.GetHashKey("hunter"),"hunter"},
            {NAPI.Util.GetHashKey("huntley"),"huntley"},
            {NAPI.Util.GetHashKey("hustler"),"hustler"},
            {NAPI.Util.GetHashKey("hydra"),"hydra"},
            {NAPI.Util.GetHashKey("imorgon"),"imorgon"},
            {NAPI.Util.GetHashKey("impaler"),"impaler"},
            {NAPI.Util.GetHashKey("impaler2"),"impaler2"},
            {NAPI.Util.GetHashKey("impaler3"),"impaler3"},
            {NAPI.Util.GetHashKey("impaler4"),"impaler4"},
            {NAPI.Util.GetHashKey("imperator"),"imperator"},
            {NAPI.Util.GetHashKey("imperator2"),"imperator2"},
            {NAPI.Util.GetHashKey("imperator3"),"imperator3"},
            {NAPI.Util.GetHashKey("infernus"),"infernus"},
            {NAPI.Util.GetHashKey("infernus2"),"infernus2"},
            {NAPI.Util.GetHashKey("ingot"),"ingot"},
            {NAPI.Util.GetHashKey("innovation"),"innovation"},
            {NAPI.Util.GetHashKey("insurgent"),"insurgent"},
            {NAPI.Util.GetHashKey("insurgent2"),"insurgent2"},
            {NAPI.Util.GetHashKey("insurgent3"),"insurgent3"},
            {NAPI.Util.GetHashKey("intruder"),"intruder"},
            {NAPI.Util.GetHashKey("issi2"),"issi2"},
            {NAPI.Util.GetHashKey("issi3"),"issi3"},
            {NAPI.Util.GetHashKey("issi4"),"issi4"},
            {NAPI.Util.GetHashKey("issi5"),"issi5"},
            {NAPI.Util.GetHashKey("issi6"),"issi6"},
            {NAPI.Util.GetHashKey("issi7"),"issi7"},
            {NAPI.Util.GetHashKey("italigtb"),"italigtb"},
            {NAPI.Util.GetHashKey("italigtb2"),"italigtb2"},
            {NAPI.Util.GetHashKey("italigto"),"italigto"},
            {NAPI.Util.GetHashKey("jackal"),"jackal"},
            {NAPI.Util.GetHashKey("jb700"),"jb700"},
            {NAPI.Util.GetHashKey("jb7002"),"jb7002"},
            {NAPI.Util.GetHashKey("jester"),"jester"},
            {NAPI.Util.GetHashKey("jester2"),"jester2"},
            {NAPI.Util.GetHashKey("jester3"),"jester3"},
            {NAPI.Util.GetHashKey("jet"),"jet"},
            {NAPI.Util.GetHashKey("jetmax"),"jetmax"},
            {NAPI.Util.GetHashKey("journey"),"journey"},
            {NAPI.Util.GetHashKey("jugular"),"jugular"},
            {NAPI.Util.GetHashKey("kalahari"),"kalahari"},
            {NAPI.Util.GetHashKey("kamacho"),"kamacho"},
            {NAPI.Util.GetHashKey("kanjo"),"kanjo"},
            {NAPI.Util.GetHashKey("khamelion"),"khamelion"},
            {NAPI.Util.GetHashKey("khanjali"),"khanjali"},
            {NAPI.Util.GetHashKey("komoda"),"komoda"},
            {NAPI.Util.GetHashKey("krieger"),"krieger"},
            {NAPI.Util.GetHashKey("kuruma"),"kuruma"},
            {NAPI.Util.GetHashKey("kuruma2"),"kuruma2"},
            {NAPI.Util.GetHashKey("landstalker"),"landstalker"},
            {NAPI.Util.GetHashKey("lazer"),"lazer"},
            {NAPI.Util.GetHashKey("le7b"),"le7b"},
            {NAPI.Util.GetHashKey("lectro"),"lectro"},
            {NAPI.Util.GetHashKey("lguard"),"lguard"},
            {NAPI.Util.GetHashKey("limo2"),"limo2"},
            {NAPI.Util.GetHashKey("locust"),"locust"},
            {NAPI.Util.GetHashKey("lurcher"),"lurcher"},
            {NAPI.Util.GetHashKey("luxor"),"luxor"},
            {NAPI.Util.GetHashKey("luxor2"),"luxor2"},
            {NAPI.Util.GetHashKey("lynx"),"lynx"},
            {NAPI.Util.GetHashKey("mamba"),"mamba"},
            {NAPI.Util.GetHashKey("mammatus"),"mammatus"},
            {NAPI.Util.GetHashKey("manana"),"manana"},
            {NAPI.Util.GetHashKey("manchez"),"manchez"},
            {NAPI.Util.GetHashKey("marquis"),"marquis"},
            {NAPI.Util.GetHashKey("marshall"),"marshall"},
            {NAPI.Util.GetHashKey("massacro"),"massacro"},
            {NAPI.Util.GetHashKey("massacro2"),"massacro2"},
            {NAPI.Util.GetHashKey("maverick"),"maverick"},
            {NAPI.Util.GetHashKey("menacer"),"menacer"},
            {NAPI.Util.GetHashKey("mesa"),"mesa"},
            {NAPI.Util.GetHashKey("mesa2"),"mesa2"},
            {NAPI.Util.GetHashKey("mesa3"),"mesa3"},
            {NAPI.Util.GetHashKey("metrotrain"),"metrotrain"},
            {NAPI.Util.GetHashKey("michelli"),"michelli"},
            {NAPI.Util.GetHashKey("microlight"),"microlight"},
            {NAPI.Util.GetHashKey("miljet"),"miljet"},
            {NAPI.Util.GetHashKey("minitank"),"minitank"},
            {NAPI.Util.GetHashKey("minivan"),"minivan"},
            {NAPI.Util.GetHashKey("minivan2"),"minivan2"},
            {NAPI.Util.GetHashKey("mixer"),"mixer"},
            {NAPI.Util.GetHashKey("mixer2"),"mixer2"},
            {NAPI.Util.GetHashKey("mogul"),"mogul"},
            {NAPI.Util.GetHashKey("molotok"),"molotok"},
            {NAPI.Util.GetHashKey("monroe"),"monroe"},
            {NAPI.Util.GetHashKey("monster"),"monster"},
            {NAPI.Util.GetHashKey("monster3"),"monster3"},
            {NAPI.Util.GetHashKey("monster4"),"monster4"},
            {NAPI.Util.GetHashKey("monster5"),"monster5"},
            {NAPI.Util.GetHashKey("moonbeam"),"moonbeam"},
            {NAPI.Util.GetHashKey("moonbeam2"),"moonbeam2"},
            {NAPI.Util.GetHashKey("mower"),"mower"},
            {NAPI.Util.GetHashKey("mule"),"mule"},
            {NAPI.Util.GetHashKey("mule2"),"mule2"},
            {NAPI.Util.GetHashKey("mule3"),"mule3"},
            {NAPI.Util.GetHashKey("mule4"),"mule4"},
            {NAPI.Util.GetHashKey("nebula"),"nebula"},
            {NAPI.Util.GetHashKey("nemesis"),"nemesis"},
            {NAPI.Util.GetHashKey("neo"),"neo"},
            {NAPI.Util.GetHashKey("neon"),"neon"},
            {NAPI.Util.GetHashKey("nero"),"nero"},
            {NAPI.Util.GetHashKey("nero2"),"nero2"},
            {NAPI.Util.GetHashKey("nightblade"),"nightblade"},
            {NAPI.Util.GetHashKey("nightshade"),"nightshade"},
            {NAPI.Util.GetHashKey("nightshark"),"nightshark"},
            {NAPI.Util.GetHashKey("nimbus"),"nimbus"},
            {NAPI.Util.GetHashKey("ninef"),"ninef"},
            {NAPI.Util.GetHashKey("ninef2"),"ninef2"},
            {NAPI.Util.GetHashKey("nokota"),"nokota"},
            {NAPI.Util.GetHashKey("novak"),"novak"},
            {NAPI.Util.GetHashKey("omnis"),"omnis"},
            {NAPI.Util.GetHashKey("oppressor"),"oppressor"},
            {NAPI.Util.GetHashKey("oppressor2"),"oppressor2"},
            {NAPI.Util.GetHashKey("oracle"),"oracle"},
            {NAPI.Util.GetHashKey("oracle2"),"oracle2"},
            {NAPI.Util.GetHashKey("osiris"),"osiris"},
            {NAPI.Util.GetHashKey("outlaw"),"outlaw"},
            {NAPI.Util.GetHashKey("packer"),"packer"},
            {NAPI.Util.GetHashKey("panto"),"panto"},
            {NAPI.Util.GetHashKey("paradise"),"paradise"},
            {NAPI.Util.GetHashKey("paragon"),"paragon"},
            {NAPI.Util.GetHashKey("paragon2"),"paragon2"},
            {NAPI.Util.GetHashKey("pariah"),"pariah"},
            {NAPI.Util.GetHashKey("patriot"),"patriot"},
            {NAPI.Util.GetHashKey("patriot2"),"patriot2"},
            {NAPI.Util.GetHashKey("pbus"),"pbus"},
            {NAPI.Util.GetHashKey("pbus2"),"pbus2"},
            {NAPI.Util.GetHashKey("pcj"),"pcj"},
            {NAPI.Util.GetHashKey("penetrator"),"penetrator"},
            {NAPI.Util.GetHashKey("penumbra"),"penumbra"},
            {NAPI.Util.GetHashKey("peyote"),"peyote"},
            {NAPI.Util.GetHashKey("peyote2"),"peyote2"},
            {NAPI.Util.GetHashKey("pfister811"),"pfister811"},
            {NAPI.Util.GetHashKey("phantom"),"phantom"},
            {NAPI.Util.GetHashKey("phantom2"),"phantom2"},
            {NAPI.Util.GetHashKey("phantom3"),"phantom3"},
            {NAPI.Util.GetHashKey("phoenix"),"phoenix"},
            {NAPI.Util.GetHashKey("picador"),"picador"},
            {NAPI.Util.GetHashKey("pigalle"),"pigalle"},
            {NAPI.Util.GetHashKey("police"),"police"},
            {NAPI.Util.GetHashKey("police2"),"police2"},
            {NAPI.Util.GetHashKey("police3"),"police3"},
            {NAPI.Util.GetHashKey("police4"),"police4"},
            {NAPI.Util.GetHashKey("policeb"),"policeb"},
            {NAPI.Util.GetHashKey("policeold1"),"policeold1"},
            {NAPI.Util.GetHashKey("policeold2"),"policeold2"},
            {NAPI.Util.GetHashKey("policet"),"policet"},
            {NAPI.Util.GetHashKey("polmav"),"polmav"},
            {NAPI.Util.GetHashKey("pony"),"pony"},
            {NAPI.Util.GetHashKey("pony2"),"pony2"},
            {NAPI.Util.GetHashKey("pounder"),"pounder"},
            {NAPI.Util.GetHashKey("pounder2"),"pounder2"},
            {NAPI.Util.GetHashKey("prairie"),"prairie"},
            {NAPI.Util.GetHashKey("pranger"),"pranger"},
            {NAPI.Util.GetHashKey("predator"),"predator"},
            {NAPI.Util.GetHashKey("premier"),"premier"},
            {NAPI.Util.GetHashKey("primo"),"primo"},
            {NAPI.Util.GetHashKey("primo2"),"primo2"},
            {NAPI.Util.GetHashKey("proptrailer"),"proptrailer"},
            {NAPI.Util.GetHashKey("prototipo"),"prototipo"},
            {NAPI.Util.GetHashKey("pyro"),"pyro"},
            {NAPI.Util.GetHashKey("radi"),"radi"},
            {NAPI.Util.GetHashKey("raiden"),"raiden"},
            {NAPI.Util.GetHashKey("raketrailer"),"raketrailer"},
            {NAPI.Util.GetHashKey("rallytruck"),"rallytruck"},
            {NAPI.Util.GetHashKey("rancherxl"),"rancherxl"},
            {NAPI.Util.GetHashKey("rancherxl2"),"rancherxl2"},
            {NAPI.Util.GetHashKey("rapidgt"),"rapidgt"},
            {NAPI.Util.GetHashKey("rapidgt2"),"rapidgt2"},
            {NAPI.Util.GetHashKey("rapidgt3"),"rapidgt3"},
            {NAPI.Util.GetHashKey("raptor"),"raptor"},
            {NAPI.Util.GetHashKey("ratbike"),"ratbike"},
            {NAPI.Util.GetHashKey("ratloader"),"ratloader"},
            {NAPI.Util.GetHashKey("ratloader2"),"ratloader2"},
            {NAPI.Util.GetHashKey("rcbandito"),"rcbandito"},
            {NAPI.Util.GetHashKey("reaper"),"reaper"},
            {NAPI.Util.GetHashKey("rebel"),"rebel"},
            {NAPI.Util.GetHashKey("rebel2"),"rebel2"},
            {NAPI.Util.GetHashKey("rebla"),"rebla"},
            {NAPI.Util.GetHashKey("regina"),"regina"},
            {NAPI.Util.GetHashKey("rentalbus"),"rentalbus"},
            {NAPI.Util.GetHashKey("retinue"),"retinue"},
            {NAPI.Util.GetHashKey("retinue2"),"retinue2"},
            {NAPI.Util.GetHashKey("revolter"),"revolter"},
            {NAPI.Util.GetHashKey("rhapsody"),"rhapsody"},
            {NAPI.Util.GetHashKey("rhino"),"rhino"},
            {NAPI.Util.GetHashKey("riata"),"riata"},
            {NAPI.Util.GetHashKey("riot"),"riot"},
            {NAPI.Util.GetHashKey("riot2"),"riot2"},
            {NAPI.Util.GetHashKey("ripley"),"ripley"},
            {NAPI.Util.GetHashKey("rocoto"),"rocoto"},
            {NAPI.Util.GetHashKey("rogue"),"rogue"},
            {NAPI.Util.GetHashKey("romero"),"romero"},
            {NAPI.Util.GetHashKey("rrocket"),"rrocket"},
            {NAPI.Util.GetHashKey("rubble"),"rubble"},
            {NAPI.Util.GetHashKey("ruffian"),"ruffian"},
            {NAPI.Util.GetHashKey("ruiner"),"ruiner"},
            {NAPI.Util.GetHashKey("ruiner2"),"ruiner2"},
            {NAPI.Util.GetHashKey("ruiner3"),"ruiner3"},
            {NAPI.Util.GetHashKey("rumpo"),"rumpo"},
            {NAPI.Util.GetHashKey("rumpo2"),"rumpo2"},
            {NAPI.Util.GetHashKey("rumpo3"),"rumpo3"},
            {NAPI.Util.GetHashKey("ruston"),"ruston"},
            {NAPI.Util.GetHashKey("s80"),"s80"},
            {NAPI.Util.GetHashKey("sabregt"),"sabregt"},
            {NAPI.Util.GetHashKey("sabregt2"),"sabregt2"},
            {NAPI.Util.GetHashKey("sadler"),"sadler"},
            {NAPI.Util.GetHashKey("sadler2"),"sadler2"},
            {NAPI.Util.GetHashKey("sanchez"),"sanchez"},
            {NAPI.Util.GetHashKey("sanchez2"),"sanchez2"},
            {NAPI.Util.GetHashKey("sanctus"),"sanctus"},
            {NAPI.Util.GetHashKey("sandking"),"sandking"},
            {NAPI.Util.GetHashKey("sandking2"),"sandking2"},
            {NAPI.Util.GetHashKey("savage"),"savage"},
            {NAPI.Util.GetHashKey("savestra"),"savestra"},
            {NAPI.Util.GetHashKey("sc1"),"sc1"},
            {NAPI.Util.GetHashKey("scarab"),"scarab"},
            {NAPI.Util.GetHashKey("scarab2"),"scarab2"},
            {NAPI.Util.GetHashKey("scarab3"),"scarab3"},
            {NAPI.Util.GetHashKey("schafter2"),"schafter2"},
            {NAPI.Util.GetHashKey("schafter3"),"schafter3"},
            {NAPI.Util.GetHashKey("schafter4"),"schafter4"},
            {NAPI.Util.GetHashKey("schafter5"),"schafter5"},
            {NAPI.Util.GetHashKey("schafter6"),"schafter6"},
            {NAPI.Util.GetHashKey("schlagen"),"schlagen"},
            {NAPI.Util.GetHashKey("schwarzer"),"schwarzer"},
            {NAPI.Util.GetHashKey("scorcher"),"scorcher"},
            {NAPI.Util.GetHashKey("scramjet"),"scramjet"},
            {NAPI.Util.GetHashKey("scrap"),"scrap"},
            {NAPI.Util.GetHashKey("seabreeze"),"seabreeze"},
            {NAPI.Util.GetHashKey("seashark"),"seashark"},
            {NAPI.Util.GetHashKey("seashark2"),"seashark2"},
            {NAPI.Util.GetHashKey("seashark3"),"seashark3"},
            {NAPI.Util.GetHashKey("seasparrow"),"seasparrow"},
            {NAPI.Util.GetHashKey("seminole"),"seminole"},
            {NAPI.Util.GetHashKey("sentinel"),"sentinel"},
            {NAPI.Util.GetHashKey("sentinel2"),"sentinel2"},
            {NAPI.Util.GetHashKey("sentinel3"),"sentinel3"},
            {NAPI.Util.GetHashKey("serrano"),"serrano"},
            {NAPI.Util.GetHashKey("seven70"),"seven70"},
            {NAPI.Util.GetHashKey("shamal"),"shamal"},
            {NAPI.Util.GetHashKey("sheava"),"sheava"},
            {NAPI.Util.GetHashKey("sheriff"),"sheriff"},
            {NAPI.Util.GetHashKey("sheriff2"),"sheriff2"},
            {NAPI.Util.GetHashKey("shotaro"),"shotaro"},
            {NAPI.Util.GetHashKey("skylift"),"skylift"},
            {NAPI.Util.GetHashKey("slamvan"),"slamvan"},
            {NAPI.Util.GetHashKey("slamvan2"),"slamvan2"},
            {NAPI.Util.GetHashKey("slamvan3"),"slamvan3"},
            {NAPI.Util.GetHashKey("slamvan4"),"slamvan4"},
            {NAPI.Util.GetHashKey("slamvan5"),"slamvan5"},
            {NAPI.Util.GetHashKey("slamvan6"),"slamvan6"},
            {NAPI.Util.GetHashKey("sovereign"),"sovereign"},
            {NAPI.Util.GetHashKey("specter"),"specter"},
            {NAPI.Util.GetHashKey("specter2"),"specter2"},
            {NAPI.Util.GetHashKey("speeder"),"speeder"},
            {NAPI.Util.GetHashKey("speeder2"),"speeder2"},
            {NAPI.Util.GetHashKey("speedo"),"speedo"},
            {NAPI.Util.GetHashKey("speedo2"),"speedo2"},
            {NAPI.Util.GetHashKey("speedo4"),"speedo4"},
            {NAPI.Util.GetHashKey("squalo"),"squalo"},
            {NAPI.Util.GetHashKey("stafford"),"stafford"},
            {NAPI.Util.GetHashKey("stalion"),"stalion"},
            {NAPI.Util.GetHashKey("stalion2"),"stalion2"},
            {NAPI.Util.GetHashKey("stanier"),"stanier"},
            {NAPI.Util.GetHashKey("starling"),"starling"},
            {NAPI.Util.GetHashKey("stinger"),"stinger"},
            {NAPI.Util.GetHashKey("stingergt"),"stingergt"},
            {NAPI.Util.GetHashKey("stockade"),"stockade"},
            {NAPI.Util.GetHashKey("stockade3"),"stockade3"},
            {NAPI.Util.GetHashKey("stratum"),"stratum"},
            {NAPI.Util.GetHashKey("streiter"),"streiter"},
            {NAPI.Util.GetHashKey("stretch"),"stretch"},
            {NAPI.Util.GetHashKey("strikeforce"),"strikeforce"},
            {NAPI.Util.GetHashKey("stromberg"),"stromberg"},
            {NAPI.Util.GetHashKey("stryder"),"stryder"},
            {NAPI.Util.GetHashKey("stunt"),"stunt"},
            {NAPI.Util.GetHashKey("submersible"),"submersible"},
            {NAPI.Util.GetHashKey("submersible2"),"submersible2"},
            {NAPI.Util.GetHashKey("sugoi"),"sugoi"},
            {NAPI.Util.GetHashKey("sultan"),"sultan"},
            {NAPI.Util.GetHashKey("sultan2"),"sultan2"},
            {NAPI.Util.GetHashKey("sultanrs"),"sultanrs"},
            {NAPI.Util.GetHashKey("suntrap"),"suntrap"},
            {NAPI.Util.GetHashKey("superd"),"superd"},
            {NAPI.Util.GetHashKey("supervolito"),"supervolito"},
            {NAPI.Util.GetHashKey("supervolito2"),"supervolito2"},
            {NAPI.Util.GetHashKey("surano"),"surano"},
            {NAPI.Util.GetHashKey("surfer"),"surfer"},
            {NAPI.Util.GetHashKey("surfer2"),"surfer2"},
            {NAPI.Util.GetHashKey("surge"),"surge"},
            {NAPI.Util.GetHashKey("swift"),"swift"},
            {NAPI.Util.GetHashKey("swift2"),"swift2"},
            {NAPI.Util.GetHashKey("swinger"),"swinger"},
            {NAPI.Util.GetHashKey("t20"),"t20"},
            {NAPI.Util.GetHashKey("taco"),"taco"},
            {NAPI.Util.GetHashKey("tailgater"),"tailgater"},
            {NAPI.Util.GetHashKey("taipan"),"taipan"},
            {NAPI.Util.GetHashKey("tampa"),"tampa"},
            {NAPI.Util.GetHashKey("tampa2"),"tampa2"},
            {NAPI.Util.GetHashKey("tampa3"),"tampa3"},
            {NAPI.Util.GetHashKey("tanker"),"tanker"},
            {NAPI.Util.GetHashKey("tanker2"),"tanker2"},
            {NAPI.Util.GetHashKey("tankercar"),"tankercar"},
            {NAPI.Util.GetHashKey("taxi"),"taxi"},
            {NAPI.Util.GetHashKey("technical"),"technical"},
            {NAPI.Util.GetHashKey("technical2"),"technical2"},
            {NAPI.Util.GetHashKey("technical3"),"technical3"},
            {NAPI.Util.GetHashKey("tempesta"),"tempesta"},
            {NAPI.Util.GetHashKey("terbyte"),"terbyte"},
            {NAPI.Util.GetHashKey("tezeract"),"tezeract"},
            {NAPI.Util.GetHashKey("thrax"),"thrax"},
            {NAPI.Util.GetHashKey("thrust"),"thrust"},
            {NAPI.Util.GetHashKey("thruster"),"thruster"},
            {NAPI.Util.GetHashKey("tiptruck"),"tiptruck"},
            {NAPI.Util.GetHashKey("tiptruck2"),"tiptruck2"},
            {NAPI.Util.GetHashKey("titan"),"titan"},
            {NAPI.Util.GetHashKey("torero"),"torero"},
            {NAPI.Util.GetHashKey("tornado"),"tornado"},
            {NAPI.Util.GetHashKey("tornado2"),"tornado2"},
            {NAPI.Util.GetHashKey("tornado3"),"tornado3"},
            {NAPI.Util.GetHashKey("tornado4"),"tornado4"},
            {NAPI.Util.GetHashKey("tornado5"),"tornado5"},
            {NAPI.Util.GetHashKey("tornado6"),"tornado6"},
            {NAPI.Util.GetHashKey("toro"),"toro"},
            {NAPI.Util.GetHashKey("toro2"),"toro2"},
            {NAPI.Util.GetHashKey("toros"),"toros"},
            {NAPI.Util.GetHashKey("tourbus"),"tourbus"},
            {NAPI.Util.GetHashKey("towtruck"),"towtruck"},
            {NAPI.Util.GetHashKey("towtruck2"),"towtruck2"},
            {NAPI.Util.GetHashKey("tr2"),"tr2"},
            {NAPI.Util.GetHashKey("tr3"),"tr3"},
            {NAPI.Util.GetHashKey("tr4"),"tr4"},
            {NAPI.Util.GetHashKey("tractor"),"tractor"},
            {NAPI.Util.GetHashKey("tractor2"),"tractor2"},
            {NAPI.Util.GetHashKey("tractor3"),"tractor3"},
            {NAPI.Util.GetHashKey("trailerlarge"),"trailerlarge"},
            {NAPI.Util.GetHashKey("trailerlogs"),"trailerlogs"},
            {NAPI.Util.GetHashKey("trailers"),"trailers"},
            {NAPI.Util.GetHashKey("trailers2"),"trailers2"},
            {NAPI.Util.GetHashKey("trailers3"),"trailers3"},
            {NAPI.Util.GetHashKey("trailers4"),"trailers4"},
            {NAPI.Util.GetHashKey("trailersmall"),"trailersmall"},
            {NAPI.Util.GetHashKey("trailersmall2"),"trailersmall2"},
            {NAPI.Util.GetHashKey("trash"),"trash"},
            {NAPI.Util.GetHashKey("trash2"),"trash2"},
            {NAPI.Util.GetHashKey("trflat"),"trflat"},
            {NAPI.Util.GetHashKey("tribike"),"tribike"},
            {NAPI.Util.GetHashKey("tribike2"),"tribike2"},
            {NAPI.Util.GetHashKey("tribike3"),"tribike3"},
            {NAPI.Util.GetHashKey("trophytruck"),"trophytruck"},
            {NAPI.Util.GetHashKey("trophytruck2"),"trophytruck2"},
            {NAPI.Util.GetHashKey("tropic"),"tropic"},
            {NAPI.Util.GetHashKey("tropic2"),"tropic2"},
            {NAPI.Util.GetHashKey("tropos"),"tropos"},
            {NAPI.Util.GetHashKey("tug"),"tug"},
            {NAPI.Util.GetHashKey("tula"),"tula"},
            {NAPI.Util.GetHashKey("tulip"),"tulip"},
            {NAPI.Util.GetHashKey("turismo2"),"turismo2"},
            {NAPI.Util.GetHashKey("turismor"),"turismor"},
            {NAPI.Util.GetHashKey("tvtrailer"),"tvtrailer"},
            {NAPI.Util.GetHashKey("tyrant"),"tyrant"},
            {NAPI.Util.GetHashKey("tyrus"),"tyrus"},
            {NAPI.Util.GetHashKey("utillitruck"),"utillitruck"},
            {NAPI.Util.GetHashKey("utillitruck2"),"utillitruck2"},
            {NAPI.Util.GetHashKey("utillitruck3"),"utillitruck3"},
            {NAPI.Util.GetHashKey("vacca"),"vacca"},
            {NAPI.Util.GetHashKey("vader"),"vader"},
            {NAPI.Util.GetHashKey("vagner"),"vagner"},
            {NAPI.Util.GetHashKey("vagrant"),"vagrant"},
            {NAPI.Util.GetHashKey("valkyrie"),"valkyrie"},
            {NAPI.Util.GetHashKey("valkyrie2"),"valkyrie2"},
            {NAPI.Util.GetHashKey("vamos"),"vamos"},
            {NAPI.Util.GetHashKey("velum"),"velum"},
            {NAPI.Util.GetHashKey("velum2"),"velum2"},
            {NAPI.Util.GetHashKey("verlierer2"),"verlierer2"},
            {NAPI.Util.GetHashKey("vestra"),"vestra"},
            {NAPI.Util.GetHashKey("vigero"),"vigero"},
            {NAPI.Util.GetHashKey("vigilante"),"vigilante"},
            {NAPI.Util.GetHashKey("vindicator"),"vindicator"},
            {NAPI.Util.GetHashKey("virgo"),"virgo"},
            {NAPI.Util.GetHashKey("virgo2"),"virgo2"},
            {NAPI.Util.GetHashKey("virgo3"),"virgo3"},
            {NAPI.Util.GetHashKey("viseris"),"viseris"},
            {NAPI.Util.GetHashKey("visione"),"visione"},
            {NAPI.Util.GetHashKey("volatol"),"volatol"},
            {NAPI.Util.GetHashKey("volatus"),"volatus"},
            {NAPI.Util.GetHashKey("voltic"),"voltic"},
            {NAPI.Util.GetHashKey("voltic2"),"voltic2"},
            {NAPI.Util.GetHashKey("voodoo"),"voodoo"},
            {NAPI.Util.GetHashKey("voodoo2"),"voodoo2"},
            {NAPI.Util.GetHashKey("vortex"),"vortex"},
            {NAPI.Util.GetHashKey("vstr"),"vstr"},
            {NAPI.Util.GetHashKey("warrener"),"warrener"},
            {NAPI.Util.GetHashKey("washington"),"washington"},
            {NAPI.Util.GetHashKey("wastelander"),"wastelander"},
            {NAPI.Util.GetHashKey("windsor"),"windsor"},
            {NAPI.Util.GetHashKey("windsor2"),"windsor2"},
            {NAPI.Util.GetHashKey("wolfsbane"),"wolfsbane"},
            {NAPI.Util.GetHashKey("xa21"),"xa21"},
            {NAPI.Util.GetHashKey("xls"),"xls"},
            {NAPI.Util.GetHashKey("xls2"),"xls2"},
            {NAPI.Util.GetHashKey("yosemite"),"yosemite"},
            {NAPI.Util.GetHashKey("yosemite2"),"yosemite2"},
            {NAPI.Util.GetHashKey("youga"),"youga"},
            {NAPI.Util.GetHashKey("youga2"),"youga2"},
            {NAPI.Util.GetHashKey("z190"),"z190"},
            {NAPI.Util.GetHashKey("zentorno"),"zentorno"},
            {NAPI.Util.GetHashKey("zhaba"),"zhaba"},
            {NAPI.Util.GetHashKey("zion"),"zion"},
            {NAPI.Util.GetHashKey("zion2"),"zion2"},
            {NAPI.Util.GetHashKey("zion3"),"zion3"},
            {NAPI.Util.GetHashKey("zombiea"),"zombiea"},
            {NAPI.Util.GetHashKey("zombieb"),"zombieb"},
            {NAPI.Util.GetHashKey("zorrusso"),"zorrusso"},
            {NAPI.Util.GetHashKey("zr380"),"zr380"},
            {NAPI.Util.GetHashKey("zr3802"),"zr3802"},
            {NAPI.Util.GetHashKey("zr3803"),"zr3803"},
            {NAPI.Util.GetHashKey("ztype"),"ztype"},
        };
    }
}
