﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Datos;


namespace Negocio
{
    public class clsNEGPerson
    {

        clsDAOPerson daoPerson = new clsDAOPerson();

        public DataTable GetAll()
        {

            return daoPerson.GetAll();
        }



        public DataTable GetBuscar(string buscar)
        {
            return daoPerson.GetBuscar(buscar);
        }
    }
}
