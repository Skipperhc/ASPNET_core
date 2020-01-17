using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET_CORE.DataBase {
    public class ApplicationDBContext : DbContext {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) {

        }
    }
}
