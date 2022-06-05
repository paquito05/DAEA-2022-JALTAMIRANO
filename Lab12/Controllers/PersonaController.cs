using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab12.Models;

namespace Lab12.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Listar()
        {
            List<Persona> personas = new List<Persona>();

            personas.Add(new Persona { PersonaId = 1,
                Nombre =" John",
                Apellido="Sanchez",
                FechaNaci= Convert.ToDateTime("2001-11-05"),
                Direccion ="San Andres 5etapa Mz E' Lote 4",
                Email ="john.altamirano@tecsup.edu.pe"
            });

            personas.Add(new Persona
            {
                PersonaId = 2,
                Nombre = "Carlos",
                Apellido = "Martinez",
                FechaNaci = Convert.ToDateTime("1982-02-14"),
                Direccion = "Av. Los manzanos 101",
                Email = "carlos@gmail.com"
            });

            personas.Add(new Persona
            {
                PersonaId = 3,
                Nombre = " Maria",
                Apellido = "Salas",
                FechaNaci = Convert.ToDateTime("1995-10-28"),
                Direccion = "Av. Progreso 325",
                Email = "maria@gmail.com"
            });
            return View(personas);


        }
    }
}