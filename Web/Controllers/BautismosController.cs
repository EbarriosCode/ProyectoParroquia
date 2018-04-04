using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using Models.Domain;
using ReflectionIT.Mvc.Paging;
using Services.ControllerService;
using Services.ResourcesService;
using ViewModels.Domain;

namespace Web.Controllers
{
    public class BautismosController : Controller
    {
        private readonly ICreateBautismoService _createBautismoService;
        private readonly IBautismoService _bautismoService;

        public BautismosController(ICreateBautismoService createBautismoService, IBautismoService bautismoService)
        {
            _createBautismoService = createBautismoService;
            _bautismoService = bautismoService;
        }

        public IActionResult Index(int Page = 1)
        {
            int numRegistros = 10;
            var query = _bautismoService.ListaBautismosPaginados();
            var model =  PagingList.Create(query,numRegistros,Page);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var listas = new BautismoViewModel
            {
                Sacerdotes = (List<Sacerdote>)_createBautismoService.ListSacerdotes(),   
                Departamentos = (List<Departamento>)_createBautismoService.Departamentos(),
                //Municipios = (List<Municipio>)_createBautismoService.Municipios(DepartamentoId)
            };
            
            
            return View(listas);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BautismoViewModel model)
        {
            Bautismo persistencia = new Bautismo
            {
                FechaBautismo = model.FechaBautismo,
                Libro = model.Libro,
                Folio = model.Folio,
                Partida = model.Partida,
                NombreBautizado = $"{model.NombresBautizado} {model.ApellidosBautizado}",
                FechaNacimiento = model.FechaNacimiento,
                PadresBautizado = model.PadresBautizado,
                SacerdoteId = model.SacerdoteId,
                DepartamentoId = model.DepartamentoId,
                MunicipioId = model.MunicipioId,
                Direccion = model.Direccion,
                Padrino = model.Padrino,
                Madrina = model.Madrina,
                Observaciones = model.Observaciones
            };

            if (!ModelState.IsValid)
            {
                var listas = new BautismoViewModel
                {            
                    Sacerdotes = (List<Sacerdote>)_createBautismoService.ListSacerdotes(),
                    Departamentos = (List<Departamento>)_createBautismoService.Departamentos(),
                };

                return View("Create", model);
            }

            _bautismoService.Create(persistencia);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult AjaxMunicipio(string idDepartamento)
        {
            var departamentoId = Int32.Parse(idDepartamento);
            var listaMunicipios = (List<Municipio>)_createBautismoService.Municipios(departamentoId);
            return new JsonResult(listaMunicipios);
        }

    }
}