﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Whistler.Inventory.Enums
{
    public enum CostumeNames
    {
        Invalid,
        MBase,
        FBase,
        #region Fraction

        //male
        MFR1Gang,
        MFR1Getto,
        MFR2Gang,
        MFR2Getto,
        MFR3Gang,
        MFR3Getto,
        MFR4Gang,
        MFR4Getto,
        MFR5Gang,
        MFR5Getto,
        MFR6Office1,
        MFR6Office2,
        MFR6Office3,
        MFR6Office4,
        MFR6Office5,
        MFR6Office6,
        MFR6Office7,
        MFR6Office8,
        MFR6Office9,
        MFR6Sport,
        MFR6Security,
        MFR6SpecialAgent,
        MFR7Police1,
        MFR7Police2,
        MFR7Police3,
        MFR7Police4,
        MFR7Police5,
        MFR7Police6,
        MFR7Police7,
        MFR7Police8,
        MFR7Police9,
        MFR7Police10,
        MFR7Police11,
        MFR7Police12,
        MFR7Police13,
        MFR7Police14,
        MFR7Swat,
        MFR7Sport,
        MFR7Operative,
        MFR7AF,
        MFR7SwatDaily,
        MFR8Ems1,
        MFR8Ems2,
        MFR8Ems3,
        MFR8Ems4,
        MFR8Ems5,
        MFR8Ems6,
        MFR8Ems7,
        MFR8Ems8,
        MFR8Ems9,
        MFR8Ems10,
        MFR8Ems11,
        MFR8Paramedic1,
        MFR8Paramedic2,
        MFR8Sport,
        MFR8Work,
        MFR9Swat, 
        MFR9Sport, 
        MFR9Work,
        MFR9WorkKadet,
        MFR9HRT,
        MFR9Casual,
        MFR9AirForce,
        MFR10Gang,
        MFR11Gang,
        MFR12Gang,
        MFR12GangLeader,
        MFR13Gang,
        MFR13GangLeader,
        MFR14Army1,
        MFR14Army2,
        MFR14Army3,
        MFR14Army4,
        MFR14Army5,
        MFR14Army6,
        MFR14Army7,
        MFR14Army8,
        MFR14Army9,
        MFR14Army10,
        MFR14Army11,
        MFR14Army12,
        MFR14Army13,
        MFR14Army14,
        MFR14Army15,
        MFR14Military, 
        MFR14Stb, 
        MFR14Medical, 
        MFR14Deltaforce, 
        MFR14Airforce, 
        MFR14Camo1, 
        MFR14Camo2, 
        MFR14Camo3, 
        MFR14Camo4, 
        MFR14Camo5, 
        MFR14Camo6, 
        MFR14Sport,
        MFR15News,
        MFR15NewsLeader,
        MFR15Sport,
        MFR16Gang,
        MFR17Mery,
        MFR17GovCostume1,
        MFR17GovCostume2,
        MFR17GovCostume3,
        MFR17GovCostume4,
        MFR18Ref1,
        MFR18Ref2,
        MFR18Ref3,
        MFR18Ref4,
        MFR18Ref5,
        MFR18Ref6,
        MFR18Ref7,
        MFR18Ref8,
        MFR18Ref9,
        MFR18Ref10,
        MFR18Ref11,
        MFR18Ref12,
        MFR18Ref13,
        MFR18Sport,
        MFRCost1, 
        MFRCost2, 
        MFRCost3, 
        MFRCost4, 
        MFRCost5, 
        MFRCost6, 
        MFRCost7, 
        MFRCost8, 
        MFRCost9, 
        MFRCost10, 
        MFRCost11, 
        MFRCost12, 
        MFRCost13, 
        MFRCost14,


        //famale
        FFR1Gang,
        FFR1Getto,
        FFR2Gang,
        FFR2Getto,
        FFR3Gang,
        FFR3Getto,
        FFR4Gang,
        FFR4Getto,
        FFR5Gang,
        FFR5Getto,
        FFR6Office1,
        FFR6Office2,
        FFR6Office3,
        FFR6Office4,
        FFR6Office5,
        FFR6Office6,
        FFR6Office7,
        FFR6Office8,
        FFR6Office9,
        FFR6Sport,
        FFR6Security,
        FFR6SpecialAgent,
        FFR7Police1,
        FFR7Police2,
        FFR7Police3,
        FFR7Police4,
        FFR7Police5,
        FFR7Police6,
        FFR7Police7,
        FFR7Police8,
        FFR7Police9,
        FFR7Police10,
        FFR7Police11,
        FFR7Police12,
        FFR7Police13,
        FFR7Police14,
        FFR7Swat,
        FFR7Sport,
        FFR7Operative,
        FFR7AF,
        FFR7SwatDaily,
        FFR7Costume1,
        FFR7Costume2,
        FFR7Costume3,
        FFR7Costume4,
        FFR7Costume5,
        FFR8Ems1,
        FFR8Ems2,
        FFR8Ems3,
        FFR8Ems4,
        FFR8Ems5,
        FFR8Ems6,
        FFR8Ems7,
        FFR8Ems8,
        FFR8Ems9,
        FFR8Ems10,
        FFR8Ems11,
        FFR8Paramedic1,
        FFR8Paramedic2,
        FFR8Sport,
        FFR8Work,
        FFR9Swat, 
        FFR9Sport, 
        FFR9Work,
        FFR9WorkKadet,
        FFR9AirForce,
        FFR10Gang,
        FFR11Gang,
        FFR12Gang,
        FFR12GangLeader,
        FFR13Gang,
        FFR13GangLeader,
        FFR14Army1,
        FFR14Army2,
        FFR14Army3,
        FFR14Army4,
        FFR14Army5,
        FFR14Army6,
        FFR14Army7,
        FFR14Army8,
        FFR14Army9,
        FFR14Army10,
        FFR14Army11,
        FFR14Army12,
        FFR14Army13,
        FFR14Army14,
        FFR14Army15,
        FFR14Military, 
        FFR14Stb, 
        FFR14Medical, 
        FFR14Deltaforce, 
        FFR14Airforce, 
        FFR14Camo1, 
        FFR14Camo2, 
        FFR14Camo3, 
        FFR14Camo4, 
        FFR14Camo5, 
        FFR14Camo6, 
        FFR14Sport,
        FFR15News,
        FFR15NewsLeader,
        FFR15Sport,
        FFR16Gang,
        FFR17Mery,
        FFR17GovCostume1,
        FFR17GovCostume2,
        FFR17GovCostume3,
        FFR17GovCostume4,
        FFR18Ref1,
        FFR18Ref2,
        FFR18Ref3,
        FFR18Ref4,
        FFR18Ref5,
        FFR18Ref6,
        FFR18Ref7,
        FFR18Ref8,
        FFR18Ref9,
        FFR18Ref10,
        FFR18Ref11,
        FFR18Ref12,
        FFR18Ref13,
        FFR18Sport,
        FFRCost1, 
        FFRCost2, 
        FFRCost3, 
        FFRCost4, 
        FFRCost5, 
        FFRCost6, 
        FFRCost7, 
        FFRCost8, 
        FFRCost9, 
        FFRCost10, 
        FFRCost11, 
        FFRCost12, 
        FFRCost13, 
        FFRCost14,

        #endregion

        #region Family

        MFAMSladeBMW,
        MFAMSladePunisher,
        MFAMTutashxia,
        MFAMModest,
        MFAMGrubie,
        MFAMTareta,
        MFAMWensetti,
        MFAMAux,
        MFAMOyama,
        MFAMBosko,
        MFAMLacosta,
        MFAMBillionaire,
        MFAMLJT,
        MFAMCostello,
        MFAMCrowd,
        MFAMGroznensky,
        MFAMEscobarov,
        MFAMAzerMaf,
        MFAMLega,
        MFAMGrozny,
        MFAMSniper,
        MFAMXan,
        MFAMKhalid,
        MFAMArmenMafia,
        MFAMDark,
        MFAMSoprano,
        MFAMMaze,
        MFAMMazeCostume1,
        MFAMMazeCostume2,
        MFAMMazeCostume3,
        MFAMMazeCostume4,
        MFAMMazeCostume5,
        MFAMMazeCostume6,
        MFAMMazyProject,



        FFAMTutashxia,
        FFAMModest,
        FFAMGrubie,
        FFAMTareta,
        FFAMWensetti,
        FFAMAux,
        FFAMOyama,
        FFAMBosko,
        FFAMLacosta,
        FFAMBillionaire,
        FFAMLJT,
        FFAMCostello,
        FFAMCrowd,
        FFAMGroznensky,
        FFAMEscobarov,
        FFAMAzerMaf,
        FFAMLega,
        FFAMGrozny,
        FFAMSniper,
        FFAMXan,
        FFAMKhalid,
        FFAMArmenMafia,
        FFAMDark,
        FFAMSoprano,
        FFAMMazeCostume1,
        FFAMMazeCostume2,
        FFAMMazeCostume3,
        FFAMMazeCostume4,
        FFAMMazeCostume5,
        FFAMMazeCostume6,

        #endregion


        #region Other
        MRBForm1,
        MRBForm2,
        MRBForm3,
        MRBForm4,
        MRBForm5,


        FRBForm1,
        FRBForm2,
        FRBForm3,
        #endregion

        #region Work
        MWorkMail1,
        MWorkFireFighter1,

        FWorkMail1,
        FWorkFireFighter1,
        #endregion






    }
}
