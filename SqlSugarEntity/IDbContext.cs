using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlSugarEntity
{
    public interface IDbContext
    {
        SqlSugarClient Client { get; }
    }
}
