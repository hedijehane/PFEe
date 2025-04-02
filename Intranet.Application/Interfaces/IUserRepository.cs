﻿namespace Intranet.Application.Interfaces;

public interface IUserRepository
{
    Task<User> GetByEmailAsync(string email);
    Task AddAsync(User user);
}