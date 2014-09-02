using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

using Flash.Entidad.Aplicacion;
using Flash.Entidad.General;
using Flash.Proceso.Procesos;
using Flash.Comun.Constante;



namespace Flash.WebMVC.Controllers.Control
{
    public class ControlController : Controller
    {

        //ConnectionStringSettings conString = rootWebConfig.ConnectionStrings.ConnectionStrings[CONSTRINGNAME];
        //static Configuration rootWebConfig = WebConfigurationManager.OpenWebConfiguration("/MyProject");
        //
        // GET: /Control/


        public ActionResult Inicio() 
        {
            RegistroEntidad registro = new RegistroEntidad();
            List<RegistroEntidad> Registros = new List<RegistroEntidad>();
            RegistroProceso RegistroProcesoObjeto = new RegistroProceso();
            
            
            Registros = RegistroProcesoObjeto.SeleccionarRegistros(new RegistroEntidad());
            
            

            //Envío de los registros a la vista
            return View(Registros);

        }

        

        public ActionResult Index()
        {

            ClienteEntidad Cliente = new ClienteEntidad();
            ClienteEntidad[] clientes = { new ClienteEntidad(), new ClienteEntidad()} ;
            ViewBag.cliente = Cliente;
            UsuarioProceso userProcess = new UsuarioProceso();
            ResultadoEntidad Resultado = new ResultadoEntidad();
            Resultado = userProcess.IdentificarUsuario(new UsuarioEntidad(){UsuarioId = 1, Contrasenia = "pelos"});

            //Cliente = Resultado.ResultadoDatos.Tables[0].Rows[0][""]
            

            return View(clientes);
        }

        //
        // GET: /Control/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Control/Create

        public ActionResult Create()
        {

            List<MarcaEntidad> Marcas = new List<MarcaEntidad>();
            List<ModeloEntidad> Modelos = new List<ModeloEntidad>();
            List<ColorEntidad> Colores = new List<ColorEntidad>();
            List<FallaEntidad> Fallas = new List<FallaEntidad>();
            List<int> Years = new List<int>();


            //Se obtienen las marcas de la base de datos
            Marcas = SeleccionarMarca(new MarcaEntidad());

            //Envío de las marcas a la vista
            ViewBag.Marcas = Marcas;

            //Se obtienen los modelos de los vehículos de la base de datos
            ModeloEntidad modeloEntidad = new ModeloEntidad();
            modeloEntidad.Marca.MarcaId = 1;

            Modelos = SeleccionarModelos(modeloEntidad);

            //Se envian los objetos de tipo "ModeloEntidad" a la capa de vista
            ViewBag.Modelos = Modelos;

            Colores = SeleccionarColores(new ColorEntidad());
            ViewBag.Colores = Colores;

            for (int x = 1980; x < DateTime.Now.Year + 2; x++)
            {
                Years.Add(x);

            //    DropDownList1.Items.Add(x.ToString());
             ViewBag.Years = Years;
            }

            Fallas = SeleccionarFalla(new FallaEntidad());
            ViewBag.Fallas = Fallas;



            return View();
        }

        protected static List<MarcaEntidad> SeleccionarMarca(MarcaEntidad Marca)
        {
            MarcaProceso MarcaProcesoObjeto = new MarcaProceso();
            return MarcaProcesoObjeto.SeleccionarMarcas(Marca);
        }

        protected static List<ModeloEntidad> SeleccionarModelos(ModeloEntidad Modelo)
        {
            ModeloProceso ModeloProcesoObjeto = new ModeloProceso();
            return ModeloProcesoObjeto.SeleccionarModelos(Modelo);
        }

        protected static List<ColorEntidad> SeleccionarColores(ColorEntidad Color)
        {
            ColorProceso ColorProcesoObjeto = new ColorProceso();
            return ColorProcesoObjeto.SeleccionarColores(Color);
        }

        protected static List<FallaEntidad> SeleccionarFalla(FallaEntidad Falla)
        {
            FallaProceso FallaEntidadObjeto = new FallaProceso();
            return FallaEntidadObjeto.SeleccionarFalla(Falla);
        }

        protected static void CrearRegistro(RegistroEntidad registro)
        {
            RegistroProceso RegistroEntidadObjeto = new RegistroProceso();

            RegistroEntidadObjeto.CrearRegistros(registro);
        }

        //
        // POST: /Control/Create

        public ActionResult GetModelosPorMarca(String idMarca)
        {

            List<ModeloEntidad> carModelos = new List<ModeloEntidad>();
            ModeloEntidad modeloEntidad = new ModeloEntidad();
            modeloEntidad.Marca.MarcaId = Convert.ToInt32(idMarca);

            carModelos = SeleccionarModelos(modeloEntidad);
            return Json(new { CarModel = carModelos }, JsonRequestBehavior.AllowGet);
        
        }

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Control/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Control/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Control/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Control/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Save(FormCollection form)
        {
            RegistroEntidad Registro = new RegistroEntidad();
         
            var tel = form["TelefonoLbl"];
            var cel = form["CelLbl"];
            int marca = int.Parse(form["Marcas"]);
            int modelo = int.Parse(form["Modelos"]);
            int color = int.Parse(form["Color"]);
            int anio = int.Parse(form["Año"]);
            var cliente = form["Cliente"];
            var apellido = form["Apellido"];
            short falla = short.Parse(form["Alias"]);
            var desc = form["Descripcion"];

              Registro.Automovil.Anio = anio;
              Registro.Descripcion = desc;
              Registro.FallaId = falla;
              Registro.Automovil.ColorId = color;
              Registro.Automovil.Cliente.Nombre = cliente;
              Registro.Automovil.Cliente.ApellidoPaterno = apellido;
              Registro.Automovil.Cliente.Telefono = tel;
              Registro.Automovil.Cliente.Celular = cel;
              Registro.Automovil.Modelo.ModeloId = modelo;
              Registro.Automovil.Modelo.Marca.MarcaId = marca;
              Registro.UsuarioInserto = 1;
              Registro.Automovil.AutomovilId = 5;
              Registro.FechaEntrada = DateTime.Now.ToString();
            CrearRegistro(Registro);


            return View(Registro);
        }
    }
}
