﻿using _2013108542_ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2013108542_CON
{
    class Program
    {
        
            static void Main(string[] args)
            {
                var ensambladora = new _2013108542_ENT.Ensambladora();

                var auto1 = ensambladora.EnsamblarCarro(TipoCarro.Automovil, TipoAuto.Sedan, TipoBus.NoDefinido);
                var auto2 = ensambladora.EnsamblarCarro(TipoCarro.Automovil, TipoAuto.Coupe, TipoBus.NoDefinido);
                var auto3 = ensambladora.EnsamblarCarro(TipoCarro.Automovil, TipoAuto.HatchBack, TipoBus.NoDefinido);
                var auto4 = ensambladora.EnsamblarCarro(TipoCarro.Automovil, TipoAuto.PickUp, TipoBus.NoDefinido);

                var bus1 = ensambladora.EnsamblarCarro(TipoCarro.Bus, TipoAuto.NoDefinido, TipoBus.Publico);
                var bus2 = ensambladora.EnsamblarCarro(TipoCarro.Bus, TipoAuto.NoDefinido, TipoBus.Privado);


                ensambladora.Agregar(auto1);
                ensambladora.Agregar(auto2);
                ensambladora.Agregar(auto3);
                ensambladora.Agregar(auto4);
                ensambladora.Agregar(bus1);
                ensambladora.Agregar(bus2);

                ensambladora.IniciarPersonalizacion();
                Thread.Sleep(2000);
                ensambladora.FinalizarPersonalizacion();
            }
        
    }
    
}
