﻿using FFXIVClassic_Lobby_Server.packets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFXIVClassic_Map_Server.packets.send.actor
{
    class SetActorTargetAnimatedPacket
    {
        public const ushort OPCODE = 0x00D3;
        public const uint PACKET_SIZE = 0x28;
        
        public static SubPacket buildPacket(uint playerActorID, uint targetActorID, uint targetID)
        {            
            return new SubPacket(OPCODE, playerActorID, targetID, BitConverter.GetBytes((ulong)targetID));
        }
    }
}
