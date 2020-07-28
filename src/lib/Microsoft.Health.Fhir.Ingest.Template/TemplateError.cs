﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace Microsoft.Health.Fhir.Ingest.Template
{
    public class TemplateError
    {
        private readonly string _message;

        public TemplateError(string message)
        {
            _message = message;
        }

        public string Message
        {
            get { return _message;  }
        }
    }
}
