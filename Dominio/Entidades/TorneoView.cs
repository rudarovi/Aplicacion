// Espacio para importaciones
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class TorneoView
    {
        public int Id {get;set;}
        public string Nombre {get;set;}
        public string Categoria{get;set;}
        public DateTime FechaInicial{get;set;}
        public DateTime FechaFinal{get;set;}
        public string Horario {get;set;}
        public string Municipio {get;set;}
        
    }
}