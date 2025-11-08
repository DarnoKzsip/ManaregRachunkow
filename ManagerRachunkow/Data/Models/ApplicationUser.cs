using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic;

namespace ManagerRachunkow.Data.Models;

public class ApplicationUser: IdentityUser
{
    public bool IdPaid { get; set; }
    public IEnumerable<Bill> Bills { get; set; }
    public IEnumerable<Information> Informations { get; set; }
}
