﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using Microsoft.Health.Common.Telemetry;

namespace Microsoft.Health.Extensions.Fhir.Telemetry.Exceptions
{
    public sealed class InvalidFhirServiceException : IomtTelemetryFormattableException
    {
        private static readonly string _errorType = ErrorType.FHIRServerError;

        public InvalidFhirServiceException()
        {
        }

        public InvalidFhirServiceException(string message)
            : base(message)
        {
        }

        public InvalidFhirServiceException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public InvalidFhirServiceException(
            string message,
            string errorName)
            : this(
                  message,
                  new Exception(),
                  errorName)
        {
        }

        public InvalidFhirServiceException(
            string message,
            Exception innerException,
            string errorName)
            : base(
                  message,
                  innerException,
                  name: $"{_errorType}{errorName}",
                  operation: ConnectorOperation.FHIRConversion)
        {
        }

        public override string ErrType => _errorType;

        public override string ErrSeverity => ErrorSeverity.Critical;

        public override string ErrSource => nameof(ErrorSource.User);
    }
}
