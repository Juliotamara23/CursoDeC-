﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvisosVarios
{
    internal class AvisosTrafico : IAvisos
    {

        public AvisosTrafico()
        {
            remitente = "DGT";
            mensaje = "Sancion cometida. Pague antes de 3 dias y se beneficiara " +
                "una reduccion en la sancion";

            fecha = "";
        }

        public AvisosTrafico(string remitente, string mensaje, string fecha)
        {
            this.remitente = remitente;
            this.mensaje = mensaje;
            this.fecha = fecha;
        }

        public string getFecha()
        {
            return fecha;
        }

        public void mostrarAviso()
        {
            Console.WriteLine("Mensaje {0} ha sido enviado por {1} el dia {2}",
                mensaje, remitente, fecha);
        }

        private string remitente;
        private string mensaje;
        private string fecha;
    }
}
