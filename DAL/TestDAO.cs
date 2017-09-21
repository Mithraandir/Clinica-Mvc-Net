using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TestDAO : BaseDAO<Usuario>
    {
        private ClinicaNetDBEntities context;

        public TestDAO()
        {
            context = new ClinicaNetDBEntities();
        }

        public List<Usuario> listar()
        {
            var listado = context.Usuarios.ToList();
            return listado;
        }
    }
}
