//-----------------------------------------------------------------
// <copyright file="Role.cs" company="Smart Solution">
// Copyright (c) Smart Solution. All rights reserved.
// </copyright>
//-----------------------------------------------------------------

namespace Identity.Domain
{
    using BestDeals.Core;
    using System;
    using System.Collections.Generic;

    public class Role : Entity
    {
        private string label;

        private string description;

        public Role(string label, string description)
        {
            this.label = label;
            this.description = description;
        }
    }
}
