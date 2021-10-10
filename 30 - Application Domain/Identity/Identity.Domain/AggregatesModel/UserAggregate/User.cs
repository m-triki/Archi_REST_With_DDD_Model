//-----------------------------------------------------------------
// <copyright file="User.cs" company="Smart Solution">
// Copyright (c) Smart Solution. All rights reserved.
// </copyright>
//-----------------------------------------------------------------

namespace Identity.Domain
{
    using BestDeals.Core;
    using System;

    public class User : Entity, IAggregateRoot
    {
        private string firstName;

        private string lastName;

        private string email;

        private string jwt;

        private string username;

        private string password;

        private Guid roleId;

        private int statusId;

        /// <summary>
        /// Gets or sets the user's status
        /// </summary>
        public UserStatus Status { get; private set; }

        public User(string firstName, string lastName, string email, string jwt, string username, string password, Guid roleId, int statusId)
        { 
        }

    }
}
