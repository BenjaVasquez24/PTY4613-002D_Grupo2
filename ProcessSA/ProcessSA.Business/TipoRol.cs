using ProcessSA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessSA.Business
{
    public class TipoRol
    {
        public int Id_Rol { get; set; }
        public string Descripcion_rol { get; set; }


        public TipoRol()
        {
            this.Init();
        }

        private void Init()
        {
            Id_Rol = 0;
            Descripcion_rol = string.Empty;
        }

        //public List<TipoRol> ReadAllTipoRol()
        //{
        //    ProcessSAEntities bbdd = new ProcessSAEntities();
        //    try
        //    {
        //        List<TipoRol> listadoDatos = bbdd.ROL.ToList();
        //        List<TipoRol> listadoEmpresa = GenerarListado(listadoDatos);

        //        /* Se retorna la lista */
        //        return listadoEmpresa;

        //    }
        //    catch (Exception ex)
        //    {
        //        return new List<TipoRol>();
        //    }
        //}

        //private List<TipoRol> GenerarListado(List<TipoRol> listadoDatos)
        //{
        //    List<TipoRol> listadoEmpresa = new List<TipoRol>();

        //    foreach (Data.TipoRol dato in listadoDatos)
        //    {

        //        TipoRol negocio = new TipoRol();
        //        CommonBC.Syncronize(dato, negocio);

        //        listadoEmpresa.Add(negocio);
        //    }

        //    return listadoEmpresa;

        //}
    }
}
