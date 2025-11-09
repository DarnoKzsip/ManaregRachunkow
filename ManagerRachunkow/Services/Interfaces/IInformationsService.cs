using ManagerRachunkow.ModelsDTO;

namespace ManagerRachunkow.Services.Interfaces
{
    public interface IInformationsService
    {
        ResponseDTO AddInformation(InformationDTO informationDTO);
        ResponseDTO EditInformation(InformationDTO informationDTO);
        ResponseDTO DeleteInformation(string mail);
        InformationsDTO GetAllByUser (string userId);
    }
}
