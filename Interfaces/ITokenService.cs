using System;
using System.ComponentModel.DataAnnotations;
using API.Entities;

namespace API.Interfaces;

public interface ITokenService
{
    string CreateToken(AppUser user);
}
