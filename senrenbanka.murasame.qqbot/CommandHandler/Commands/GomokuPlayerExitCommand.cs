﻿using System.Collections.Generic;
using senrenbanka.murasame.qqbot.CommandHandler.Attributes;

namespace senrenbanka.murasame.qqbot.CommandHandler.Commands
{
    [Name("/ge")]
    [Namespace("ns:Gomoku")]
    public class GomokuPlayerExitCommand : ICommandTransform
    {
        public IEnumerable<string> Transform(string cmdInput)
        {
            throw new System.NotImplementedException();
        }
    }
}