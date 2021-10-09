using System;
using System.Collections.Generic;
namespace Dominio
{
    public class Escenario
    {
        public int Id{get;set;}
        public string Nombre{get;set;}
        public string Direccion{get;set;}
        public string Telefono{get;set;}
        // llave foranea para la relaciòn con Torneo
        public int TorneoId{get;set;}
    }
}