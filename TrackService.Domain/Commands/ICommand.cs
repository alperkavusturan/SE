﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TrackService.Domain.Commands
{
    public interface ICommand<out TResult>
    {
    }

    public interface ICommandHandler<in TCommand, out TResult> where TCommand : ICommand<TResult>
    {
        TResult Execute();
    }
}
