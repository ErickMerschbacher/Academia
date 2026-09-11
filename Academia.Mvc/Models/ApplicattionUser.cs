using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace Academia;

public class ApplicattionUser : IdentityUser
{
    public string NomeCompleto {get; set;} = string.Empty
}
