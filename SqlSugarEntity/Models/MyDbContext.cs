using Microsoft.Extensions.Configuration;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlSugarEntity.Models
{
    public class MyDbContext : IDbContext
    {
        SqlSugarClient sqlSugarClient = null;
        public MyDbContext(IConfiguration configuration)
        {
            sqlSugarClient = new SqlSugarClient(new ConnectionConfig
            {
                ConnectionString = configuration.GetConnectionString("DefaultConnection"),
                IsAutoCloseConnection = true,
                DbType = DbType.MySql
            });
        }
        public SqlSugarClient Client { get { return sqlSugarClient; } }
    }
}
