using Flash.Entidad.Aplicacion;
using Flash.Proceso.Procesos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Flash.WebMVC.Controllers
{
    public class MarcasController : Controller
    {
        //
        // GET: /Marcas/

        public ActionResult Create()
        {
            List<MarcaEntidad> Marcas = new List<MarcaEntidad>();

            //Se obtienen las marcas de la base de datos
            Marcas = SeleccionarMarca(new MarcaEntidad());
            //Envío de las marcas a la vista
            ViewBag.Marcas = Marcas;


/*
            ModeloEntidad registro = new ModeloEntidad();
            List<ModeloEntidad> Registros = new List<ModeloEntidad>();
            ModeloProceso ModeloProcesoObjeto =new ModeloProceso();


            Registros = ModeloProcesoObjeto.SeleccionarModelos(new ModeloEntidad());


           
            return View(Registros);*/


            MarcaEntidad registro = new MarcaEntidad();
            List<MarcaEntidad> Registros = new List<MarcaEntidad>();
            MarcaProceso ModeloProcesoObjeto = new MarcaProceso();


            Registros = ModeloProcesoObjeto.SeleccionarMarcas(new MarcaEntidad());



            return View(Registros);
        }

        protected static List<MarcaEntidad> SeleccionarMarca(MarcaEntidad Marca)
        {
            MarcaProceso MarcaProcesoObjeto = new MarcaProceso();
            return MarcaProcesoObjeto.SeleccionarMarcas(Marca);
        }

        public ActionResult Save()
        {
            return View();
        }

    }
}
