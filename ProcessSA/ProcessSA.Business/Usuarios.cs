using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProcessSA.Business;


namespace ProcessSA.Business
{
    public class Usuarios
    {
        public string RutUsuarios { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombreUsuario{ get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }
        public string Email { get; set; }
        public string Teléfono { get; set; }

        public Usuarios()
        {
            this.Init();
        }

        private void Init()
        {
            RutUsuarios = string.Empty;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            NombreUsuario = string.Empty;
            Contraseña = string.Empty;
            Rol = string.Empty;
            Email = string.Empty;
            Teléfono = string.Empty;
        }

        //public bool Create()
        //{
        //    return false;
        //}

        //public bool Read()
        //{
        //    Datos.ProcessSAEntities bbdd = new Datos.ProcessSAEntities();

        //    try
        //    {
        //        Datos.Usuarios usu = bbdd.Usuarios.First(e => e.RutUsuarios == RutUsuarios);
        //        Rol = usu.Rol.Descripcion;
        //        CommonBC.Syncronize(usu, this);
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

        //public bool Update()
        //{
        //    Datos.OnBreakEntities bbdd = new Datos.OnBreakEntities();

        //    try
        //    {
        //        Datos.Usuarios usu = bbdd.Usuarios.First(e => e.RutUsuarios == RutUsuarios);
        //        CommonBC.Syncronize(this, usu);
        //        usu.Rol = ObtenerRol();

        //        bbdd.SaveChanges();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

        //public bool Delete()
        //{
        //    Datos.OnBreakEntities bbdd = new Datos.OnBreakEntities();

        //    try
        //    {
        //        Datos.Usuarios usu = bbdd.Usuarios.First(e => e.RutUsuarios == RutUsuarios);

        //        bbdd.Usuarios.Remove(usu);
        //        bbdd.SaveChanges();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}

        public bool ComprobarDatos()
        {
            if (RutUsuarios == string.Empty ||
            Nombres == string.Empty ||
            Apellidos == string.Empty ||
            NombreUsuario == string.Empty ||
            Contraseña == string.Empty ||
            Rol == string.Empty ||
            Email == string.Empty ||
            Teléfono == string.Empty)
            {
                throw new Exception("Los datos no pueden estar vacios");
            }
            return true;
        }

        //public List<Usuarios> ReadAll()
        //{
        //    Datos.OnBreakEntities bbdd = new Datos.OnBreakEntities();

        //    try
        //    {
        //        List<Datos.Usuarios> listaDatos = bbdd.Usuarios.ToList<Datos.Usuarios>();
        //        List<Usuarios> listaNegocio = GenerarListado(listaDatos);
        //        return listaNegocio;
        //    }
        //    catch (Exception)
        //    {
        //        return new List<Usuarios>();
        //    }
        //}

        //private List<Usuarios> GenerarListado(List<Datos.Usuarios> listaDatos)
        //{
        //    List<Usuarios> listaNegocio = new List<Usuarios>();

        //    foreach (Datos.Usuarios dato in listaDatos)
        //    {
        //        Usuarios usuarios = new Usuarios();
        //        CommonBC.Syncronize(dato, usuarios);
        //        usuarios.Rol = dato.Rol.Descripcion;
        //        listaNegocio.Add(usuarios);
        //    }
        //    return listaNegocio;
        //}
    }
}
