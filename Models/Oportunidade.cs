﻿using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Oportunidade
    {
        [Key]
        public int Id {get; set;}
        public string Descricao { get; set;}    
        public DateTime DataEntrega { get; set;}
        public string NivelSurto { get; set;}  
        public int QtdHoras { get; set;}
        public long QtdErros { get; set;}
        public long AprendizadoNivel { get; set;}
        public long HorasDeSono { get; set;}
        public int HorasDeFolga { get; set;}

    }
}