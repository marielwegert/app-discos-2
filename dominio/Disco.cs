﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Disco
    {
        //PROPIEDADES CON SUS ANNOTATIONS
        public int Id { get; set; }
        [DisplayName("Título")]
        public string Titulo { get; set; }
        [DisplayName("Fecha de Lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }
        [DisplayName("Cantidad de Canciones")]
        public int CantidadCanciones { get; set; }
        [DisplayName("Imagen de la Tapa")]
        public string UrlImagenTapa { get; set; }
        public Estilo Estilo { get; set; }
        [DisplayName("Tipo de Edición")]
        public TipoEdicion TipoEdicion { get; set; }



    }
}
