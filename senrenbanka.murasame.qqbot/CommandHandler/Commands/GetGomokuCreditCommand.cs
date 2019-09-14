﻿using System;
using System.Collections.Generic;
using senrenbanka.murasame.qqbot.CommandHandler.Attributes;

namespace senrenbanka.murasame.qqbot.CommandHandler.Commands
{
    [AdminOnly]
    public class GetGomokuCreditCommand : ICommandTransform
    {
        public string Name { get; set; } = "/gcget";

        public IEnumerable<string> Parameters { get; set; }

        public void Transform(string cmdInput)
        {
            Parameters = cmdInput.Substring(cmdInput.IndexOf(" ", StringComparison.Ordinal) + 1).Split( ' ');
        }
    }
}