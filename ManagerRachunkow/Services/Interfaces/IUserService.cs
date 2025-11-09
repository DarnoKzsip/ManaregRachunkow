using ManagerRachunkow.ModelsDTO;

namespace ManagerRachunkow.Services.Interfaces
{
    public interface IUserService
    {
        UsersDTO GetAllUsers();
        ResponseDTO EditUser (UserDTO userDTO);
        ResponseAfterAutDTO GetIdAdnRoleForUserById(string mail);
    }
}
