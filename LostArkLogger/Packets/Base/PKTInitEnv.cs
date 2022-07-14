using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public partial class PKTInitEnv
    {
        public PKTInitEnv(BitReader reader)
        {
            if (Properties.Settings.Default.Region == Region.Steam) SteamDecode(reader);
        }
        public UInt64 PlayerId;
        public UInt64 s64;
        public List<Byte> blist;
        public subPKTInitEnv5 subPKTInitEnv5;
        public UInt64 u64;
        public UInt32 u32_0;
        public UInt32 u32_1;
        public Byte b;
    }
}