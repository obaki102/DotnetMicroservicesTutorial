﻿using CQRS.Core.Commands;

namespace Post.Cmd.Api.Commands
{
    public class AddCommentCommand : BaseCommand
    {
        public string Comment { get; set; } = string.Empty; 
        public string Message { get; set; } = string.Empty;
    }
}
