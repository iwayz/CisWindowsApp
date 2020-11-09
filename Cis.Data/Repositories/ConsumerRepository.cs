using Cis.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cis.Data.Repositories
{
    public class ConsumerRepository: Repository<Consumer>
    {
        public ConsumerRepository(DbContext context): base(context)
        {

        }
    }
}
