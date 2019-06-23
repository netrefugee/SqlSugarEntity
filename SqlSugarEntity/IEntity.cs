using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SqlSugarEntity
{
    public interface IEntity
    {
        bool CreateEntity(string entityName, string filePath);
    }
}
