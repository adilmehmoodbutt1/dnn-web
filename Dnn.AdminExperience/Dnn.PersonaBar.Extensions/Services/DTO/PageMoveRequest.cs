﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information

namespace Dnn.PersonaBar.Pages.Services.Dto
{
    public class PageMoveRequest
    {
        public int PageId { get; set; }

        public int RelatedPageId { get; set; }

        public int ParentId { get; set; }

        public string Action { get; set; }
    }
}