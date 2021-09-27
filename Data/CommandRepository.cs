using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class CommandRepository : Data.Base.Repository<Models.Command>, ICommandRepository    {
        public CommandRepository(DatabaseContext databaseContext) 
            : base(databaseContext)//  بصورت ورودی به کانستراکتور کلاس پدر پاس می دهد databaseContext
            //وقتی که کانستراکتور پدر وردی دارد باید حتما از این طریق ورودی را ارسال نماییم
        {
        }

        public Command GetMyCommand()
        {
            throw new NotImplementedException();
        }

        public Task<Command> GetMyCommandAsync()
        {
            throw new NotImplementedException();
        }
    }
}
