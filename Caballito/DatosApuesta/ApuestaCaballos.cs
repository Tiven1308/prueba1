using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caballito.DatosApuesta
{
    class ApuestaCaballos
    {
        public List<String> listadoPosiciones = new List<String>();
        public Double valorBase = 20000;
        public List<double> totalApuesta = new List<double>(); 
        public String caballoGanador = "";
          public ApuestaCaballos()
        {
            
        }

       //Método que da la posicion al caballo
        public void AgregarPosicionCaballo(String caballo)
        {
            listadoPosiciones.Add(caballo);
        }

        //Método que muestra eñ caballo ganador
        public String CaballoGanador()
        {

            for (int i = 0; i < listadoPosiciones.Count; i++)
            {
                if (i == 0)
                {
                    caballoGanador = listadoPosiciones[0];
                }
            }
            return caballoGanador;
        }

        //Método que da el valor a la apuesta
        public Double ValorApuesta()
        {
            Double valorApuesta= 0;
            for (int i = 0; i < totalApuesta.Count; i++)
            {
                if (i == 0)
                {
                    valorApuesta = totalApuesta[0];
                }
            }
            return valorApuesta;
        }

        //Método que valida el combobox
        public int Combobox(String caballo)
        {
            int respuesta = -1;
            switch (caballo)
            {
                case "Caballo 1":
                    respuesta = 1;
                    return respuesta;
                case "Caballo 2":
                    respuesta = 2;
                    return respuesta;
                case "Caballo 3":
                    respuesta = 3;
                    return respuesta;
                case "Caballo 4":
                    respuesta = 4;
                    return respuesta;
            }
            return respuesta;
        }

        //Método que realiza la apuesta         
        public Boolean realizarApuesta(int numCaballoGanador, int caballoApuesta, Double valorApuesta)
        {
            if (numCaballoGanador == caballoApuesta)
            {
                for (int i = 0; i < totalApuesta.Count; i++)
                {
                    if (i == 0)
                    {
                        totalApuesta[0] = totalApuesta[0] + valorApuesta;
                        return true;
                    }
                }
                return false;
            }
            else
            {
                for (int i = 0; i < totalApuesta.Count; i++)
                {
                    if (i == 0)
                    {
                        totalApuesta[0] = totalApuesta[0] - valorApuesta;
                        return false;
                    }
                }
                return false;
            }

        }

       
       //Metodo que elimina las posiciones para volver a iniciar
      
        public void EliminarPosicionesCarrera()
        {
            for (int i = 0; i < listadoPosiciones.Count; i++)
            {
                listadoPosiciones.Clear();
            }
        }

    }
}
    