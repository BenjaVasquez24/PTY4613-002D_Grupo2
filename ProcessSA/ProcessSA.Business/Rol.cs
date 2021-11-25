using ProcessSA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessSA.Business
{
    public class Rol
    {
        public int Id_rol { get; set; }
        public string Descripcion_rol { get; set; }


        public Rol()
        {
            this.Init();
        }

        private void Init()
        {
            Id_rol = 0;
            Descripcion_rol = string.Empty;
        }
    }
}
