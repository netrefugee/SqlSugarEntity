using SqlSugar;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SqlSugarEntity
{
    public class EntityService : IEntity
    {
        IDbContext db;
        public EntityService(IDbContext dbContext)
        {
            db = dbContext;
        }
        public bool CreateEntity(string entityName, string filePath)
        {
            try
            {
                db.Client.DbFirst.IsCreateAttribute().Where(entityName).CreateClassFile(filePath);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
