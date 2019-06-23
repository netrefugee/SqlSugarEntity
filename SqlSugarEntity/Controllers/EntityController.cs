using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SqlSugarEntity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntityController : ControllerBase
    {
        IDbContext db;
        EntityService entityService;
        private readonly IHostingEnvironment hostingEnvironment;
        public EntityController(IDbContext dbContext, IHostingEnvironment environment)
        {
            hostingEnvironment = environment;
            db = dbContext;
            entityService = new EntityService(db);

        }
        // GET: api/CreateEntity
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/CreateEntity/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CreateEntity
        [HttpPost]
        public JsonResult Post(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return new JsonResult("实体名称不能为空");
            }
            entityService.CreateEntity(name, System.IO.Path.Combine(hostingEnvironment.ContentRootPath, "Models"));
            return new JsonResult("生成成功");
        }

    }
}
