using System;
using Microsoft.AspNetCore.Mvc;
using ExamenIsmaelBernad.Services;
using ExamenIsmaelBernad.Modelos;

namespace ExamenIsmaelBernad.Components
{
    public class ProvinciasComunidadViewComponent : ViewComponent
    {
        public IProvinciaRepositorio ProvinciaRepositorio { get; }

        public ProvinciasComunidadViewComponent(IProvinciaRepositorio provinciaRepositorio)
        {
            ProvinciaRepositorio = provinciaRepositorio;
        }

        public IViewComponentResult Invoke(Comunidad? comunidad = null) //puede recibir un objto comunidad o no, en ese caso será null
        {
            var resultado = ProvinciaRepositorio.ComunidadCuantosProvincia(comunidad);
            return View(resultado);
        }
    }
}