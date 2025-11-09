using ManagerRachunkow.ModelsDTO;

namespace ManagerRachunkow.Services.Interfaces;

public interface IBillService
{
    ResponseDTO AddBill(BillDTO billDTO);
    ResponseDTO EditBill(BillDTO billDTO);
    ResponseDTO DeleteBill(string mail);
    BillsDTO GetAllBillByUser(string mail);
}
