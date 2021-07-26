using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAPI.Data
{
    public class PostgreSQLConfiguracion
    {
        public PostgreSQLConfiguracion(string connection) => ConnectionString = connection;
        public string ConnectionString { get; set; }
    }
}
