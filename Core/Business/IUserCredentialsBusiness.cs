using Core.DTO;

namespace Core.Business
{
    public interface IUserCredentialsBusiness
    {
        void Add(UserCredentialsDTO dto);
        UserCredentialsDTO? Find(UserCredentialsDTO dto);
        List<UserCredentialsDTO> GetAll();
        UserCredentialsDTO? FindByUsername(string username);
    }
}
