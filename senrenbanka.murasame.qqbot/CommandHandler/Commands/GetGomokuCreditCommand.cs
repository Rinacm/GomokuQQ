﻿using System;
using System.Collections.Generic;
using senrenbanka.murasame.qqbot.CommandHandler.Attributes;

namespace senrenbanka.murasame.qqbot.CommandHandler.Commands
{
    [Name("/gcget")]
    [AdminOnly]
    [Namespace("ns:Query")]
    public class GetGomokuCreditCommand : ICommandTransform
    {
        public IEnumerable<string> Transform(string cmdInput)
        {
            return cmdInput.Substring(cmdInput.IndexOf(" ", StringComparison.Ordinal) + 1).Split( ' ');
        }
    }
}