﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Threading.Tasks;

namespace Nether.Analytics
{
    public interface IMessageHandler
    {
        Task<MessageHandlerResults> ProcessMessageAsync(Message msg, string pipelineName, int index);
    }
}