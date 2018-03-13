﻿using System;
using ARKGame;

//这些类是AFMsg 类的拓展，用于网络消息包
//these classes are sealed of AFMsg classes.
namespace AFMsg
{
    public sealed partial class ReqAccountLogin : PacketBase
    {
        public override void Clear()
        {
        }
    }
    public sealed partial class AckEventResult : PacketBase
    {
        public override void Clear()
        {
        }
    }
    public sealed partial class ReqServerList : PacketBase
    {
        public override void Clear()
        {
        }
    }
    public sealed partial class AckServerList : PacketBase
    {
        public override void Clear()
        {
            
        }
    }
}