﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace Microsoft.Health.Common.Telemetry
{
    public enum ErrorSource
    {
        /// <summary>
        /// A service error.
        /// </summary>
        Service,

        /// <summary>
        /// A user error.
        /// </summary>
        User,

        /// <summary>
        /// An error with an undefined source.
        /// </summary>
        Undefined,
    }
}
