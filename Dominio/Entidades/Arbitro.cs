using System;
using System.Collections.Generic;
namespace Dominio
{
    public class Arbitro
    {
        public int Id {get;set;}
        public string Documento {get;set;}
        public string Nombres {get;set;}
        public string Apellidos {get;set;}
        public string Celular {get;set;}
        public string Genero {get;set;}
        public string Disciplina {get;set;}
        // llave forane para la relaciòn con Torneo
        public int TorneoId{get;set;}
        public int ColegioArbitroId{get;set;}
        
    }
}