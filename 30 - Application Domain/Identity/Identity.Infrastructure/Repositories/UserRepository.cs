//-----------------------------------------------------------------
// <copyright file="UserRepository.cs" company="Smart Solution">
// Copyright (c) Smart Solution. All rights reserved.
// </copyright>
//-----------------------------------------------------------------

namespace Identity.Infrastructure
{
    using BestDeals.Core;
    using Identity.Domain;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    public class UserRepository : IUserRepository
    {
        private readonly IdentityContext _context;

        public IUnitOfWork UnitOfWork 
        {
            get 
            {
                return _context;
            }
        }

        public User Add(User user)
        {
            throw new NotImplementedException();
        }

        public bool Authenticate(string login, string password)
        {
            throw new NotImplementedException();
        }

        public bool Authentication(string jwtId)
        {
            throw new NotImplementedException();
        }

        public bool Delete(User user)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetAsync(Guid userId)
        {
            throw new NotImplementedException();
        }

        public bool ResetPassWord(ForgetPassword forgetPassword)
        {
            throw new NotImplementedException();
        }

        public bool Update(User user)
        {
            throw new NotImplementedException();
        }

        public bool UpdateStatus(Guid userId, UserStatus userstatus)
        {
            throw new NotImplementedException();
        }
    }
}
