//-----------------------------------------------------------------
// <copyright file="UserStatus.cs" company="Smart Solution">
// Copyright (c) Smart Solution. All rights reserved.
// </copyright>
//-----------------------------------------------------------------

namespace Identity.Domain
{
    using BestDeals.Core;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UserStatus : Enumeration
    {
        public static UserStatus Active = new UserStatus(1, nameof(Active).ToLowerInvariant());
        public static UserStatus Inactive = new UserStatus(2, nameof(Inactive).ToLowerInvariant());

        public UserStatus(int id, string name) : base(id, name)
        {
        }


        public static IEnumerable<UserStatus> List() =>
            new[] { Active, Inactive };

        public static UserStatus FromName(string name)
        {
            var state = List()
                .SingleOrDefault(s => String.Equals(s.Name, name, StringComparison.CurrentCultureIgnoreCase));

            if (state == null)
            {
                throw new IdentityDomainException($"Possible values for UserStatus: {String.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }

        public static UserStatus FromId(int id)
        {
            var state = List().SingleOrDefault(s => s.Id == id);

            if (state == null)
            {
                throw new IdentityDomainException($"Possible values for UserStatus: {String.Join(",", List().Select(s => s.Name))}");
            }

            return state;
        }
    }
}
