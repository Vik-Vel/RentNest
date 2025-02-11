﻿using Microsoft.EntityFrameworkCore;
using RentNest.Core.Contracts;
using RentNest.Infrastructure.Data.Common;
using RentNest.Infrastructure.Data.Models;

namespace RentNest.Core.Services
{
    public class AgentService : IAgentService
    {
        private readonly IRepository repository;

        public AgentService(IRepository _repository)
        {
            repository = _repository;
        }

        public Task CreateAsync(string userId, string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistById(string userId)
        {
          return await repository.AllReadOnly<Agent>()
                .AnyAsync(a=>a.UserId == userId);
        }

        public Task<bool> ExistByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserHasRentsAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UserWithPhoneNumberExistsAsync(string phoneNumber)
        {
            throw new NotImplementedException();
        }
    }
}
