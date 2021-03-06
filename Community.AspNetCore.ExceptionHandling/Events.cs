﻿using Microsoft.Extensions.Logging;

namespace Community.AspNetCore.ExceptionHandling
{
    public static class Events
    {
        public static readonly EventId HandlerError = new EventId(100, "HandlerExecutionError");
        public static readonly EventId PolicyNotFound = new EventId(101, "PolicyForExceptionNotRegistered");
        public static readonly EventId HandlersNotFound = new EventId(102, "HandlersCollectionEmpty");
        public static readonly EventId HandlerNotCreated = new EventId(103, "HandlersCanNotBeCreated");
        public static readonly EventId RetryForStartedResponce = new EventId(104, "RetryForStartedResponce");
        public static readonly EventId Retry = new EventId(105, "Retry");
        public static readonly EventId UnhandledResult = new EventId(106, "UnhandledResult");
        public static readonly EventId RetryIterationExceedLimit = new EventId(107, "RetryIterationExceedLimit");
    }
}