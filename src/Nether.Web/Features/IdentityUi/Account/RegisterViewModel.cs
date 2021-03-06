﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.ComponentModel.DataAnnotations;

namespace Nether.Web.Features.IdentityUi
{
    public class RegisterViewModel
    {
        public string ReturnUrl { get; set; }
        [Required]
        public string Gamertag { get; set; }
    }
}