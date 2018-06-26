﻿namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x104)]
    public class GcMissionSequenceLearnWords : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public int Amount;
        [NMS(Size = 0x80)]
        /* 0x084 */ public string DebugText;
    }
}
