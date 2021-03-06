﻿using System.Linq;
using senrenbanka.murasame.qqbot.BotImpl.Gomoku;
using senrenbanka.murasame.qqbot.CommandHandler.Attributes;
using senrenbanka.murasame.qqbot.CommandHandler.Commands;

namespace senrenbanka.murasame.qqbot.CommandHandler.Handlers
{
    [HandlerOf(nameof(ForceEndGomokuCommand))]
    public class ForceEndGomokuCommandHandler : ICommandHandler<ForceEndGomokuCommand>
    {
        public void Handle(CommandContext context, ForceEndGomokuCommand command, params object[] handleObjects)
        {
            var mahuaApi = CommandFactory.GetMahuaApi();

            if (long.TryParse(command.Transform(context.Message).ToList()[0], out var group))
            {
                GomokuFactory.TryGetPlayGround(group.ToString(), out var game);
                if (game != null)
                {
                    mahuaApi.SendGroupMessage(context.FromGroup, $"成功结束游戏: {game.GameId}");
                    game.Dispose();
                    return;
                }
                mahuaApi.SendGroupMessage(context.FromGroup, "参数错误或者该群暂时没有游戏实例正在进行");
            }
        }
    }
}