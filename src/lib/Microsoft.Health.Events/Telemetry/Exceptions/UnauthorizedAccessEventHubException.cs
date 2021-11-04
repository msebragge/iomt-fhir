﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using Microsoft.Health.Common.Telemetry;

namespace Microsoft.Health.Events.Telemetry.Exceptions
{
    public sealed class UnauthorizedAccessEventHubException : IomtTelemetryFormattableException
    {
        public UnauthorizedAccessEventHubException(
            string message,
            Exception innerException,
            string helpLink,
            string errorName)
            : base(
                  message,
                  innerException,
                  name: $"{ErrorType.EventHubError}{errorName}",
                  operation: ConnectorOperation.Setup)
        {
            HelpLink = helpLink;
        }

        public override string ErrType => ErrorType.EventHubError;

        public override string ErrSource => nameof(ErrorSource.User);
    }
}
