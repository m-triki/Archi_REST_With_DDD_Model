//-----------------------------------------------------------------
// <copyright file="IdentityDomainException.cs" company="Smart Solution">
// Copyright (c) Smart Solution. All rights reserved.
// </copyright>
//-----------------------------------------------------------------

namespace Identity.Domain
{
    using System;

    public class IdentityDomainException : Exception
    {
        public IdentityDomainException()
        { }

        public IdentityDomainException(string message)
            : base(message)
        { }

        public IdentityDomainException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
