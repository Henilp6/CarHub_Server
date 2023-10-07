using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Microsoft.EntityFrameworkCore;

namespace CarHub_DataAccess
{
   
    public class ApplicationUserRole : IdentityUserRole<string>
    {
       
        
    }

}
