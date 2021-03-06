﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.


namespace Microsoft.IIS.Administration.Files
{
    using System;

    public interface IFileRedirectService
    {
        void AddRedirect(string fileName, Func<string> redirectBuilder, bool permanent);

        IRedirect GetRedirect(string fileName);
    }
}