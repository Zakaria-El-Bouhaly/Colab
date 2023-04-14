using Colab.Models;
using Colab.Requests;

namespace Colab.Repositories;
public interface IProfileRepo
{
    Task<User> GetProfile();
    Task<User> UpdateProfile(ProfileRequest user);
    Task<User> UpdateEmail(EmailRequest emailRequest);
    Task UpdatePassword(PasswordRequest passwordRequest);

    
    
}