﻿using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x1F0)]
    public class GcFleetExpeditionSaveData : NMSTemplate
    {
        /* 0x000 */ public GcSeed ResourceSeed;
        /* 0x010 */ public ulong UA;
        /* 0x020 */ public Vector4f SpawnPosition;
        /* 0x030 */ public Vector4f TerminalPosition;
        /* 0x040 */ public float SpeedMultiplier;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x044 */ public byte[] Padding44;
        /* 0x048 */ public List<NMSString0x10> Powerups;
        [NMS(Size = 0x100)]
        /* 0x058 */ public string CustomName;
        [NMS(Size = 0x10)]
        /* 0x158 */ public string InterventionEventMissionID;
        /* 0x168 */ public ulong StartTime;
        /* 0x170 */ public ulong PauseTime;
        /* 0x178 */ public ulong TimeOfLastUAChange;
        /* 0x180 */ public int NextEventToTrigger;
        /* 0x184 */ public GcExpeditionCategory ExpeditionCategory;
        /* 0x188 */ public GcExpeditionDuration ExpeditionDuration;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x18C */ public byte[] Padding18C;
        /* 0x190 */ public List<int> ActiveFrigateIndices;
        /* 0x1A0 */ public List<int> DamagedFrigateIndices;
        /* 0x1B0 */ public List<int> DestroyedFrigateIndices;
        /* 0x1C0 */ public List<int> AllFrigateIndices;
        /* 0x1D0 */ public int NumberOfSuccessfulEventsThisExpedition;
        /* 0x1D4 */ public int NumberOfFailedEventsThisExpedition;
        /* 0x1D8 */ public List<GcExpeditionEventSaveData> Events;
        /* 0x1E8 */ public bool InterventionPhoneCallActivated;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x1E9 */ public byte[] EndPadding;
    }
}
