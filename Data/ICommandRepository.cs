using Data.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
   public interface ICommandRepository:IRepository<Models.Command>
    {
        Models.Command GetMyCommand();
        Task<Models.Command>  GetMyCommandAsync();
    }
}
