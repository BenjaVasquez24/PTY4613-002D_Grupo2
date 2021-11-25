using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessSA.Business
{
    public class Tareas
    {
        public string IDTarea { get; set; }
        public string NombreTarea { get; set; }
        public string Rol { get; set; }
        public string Encargado { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public DateTime HoraFin { get; set; }
        public string Comentarios { get; set; }

        public Tareas()
        {
            this.Init();
        }

        private void Init()
        {
            IDTarea = "T0001";
            NombreTarea = string.Empty;
            Rol = string.Empty;
            Encargado = string.Empty;
            FechaInicio = DateTime.Today;
            HoraInicio = DateTime.Today;
            FechaFin = DateTime.Today;
            HoraFin = DateTime.Today;
            Comentarios = string.Empty;
        }

        public bool Create (Tareas tareas)
        {
            return false;
        }
    }
}
