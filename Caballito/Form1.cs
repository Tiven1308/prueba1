using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using Caballito.DatosApuesta;

namespace Caballito
{
    public partial class Form1 : Form
    {

        //Indica hacia donde corren los caballos
        enum PositionCaballo
        {
            rightCaballo
        }


        //Posiciones de los caballos x,y,ancho,alto
        private int posicionXCaballo1;
        private int posicionYCaballo1;
        private int anchoCaballo1;
        private int altoCaballo1;

        private int posicionXCaballo2;
        private int posicionYCaballo2;
        private int anchoCaballo2;
        private int altoCaballo2;

        private int posicionXCaballo3;
        private int posicionYCaballo3;
        private int anchoCaballo3;
        private int altoCaballo3;

        private int posicionXCaballo4;
        private int posicionYCaballo4;
        private int anchoCaballo4;
        private int altoCaballo4;

        //Aqui se indica la posición xy de los caballos en la interfaz
        public void PosicionXy()
        {
            posicionXCaballo1 = 10;
            posicionYCaballo1 = 10;

            posicionXCaballo2 = 10;
            posicionYCaballo2 = 70;

            posicionXCaballo3 = 10;
            posicionYCaballo3 = 140;

            posicionXCaballo4 = 10;
            posicionYCaballo4 = 210;
        }

        //Aqui se indica la posición ancho y alto de los caballos en la interfaz
        public void PosicionAnchoAlto()
        {
            anchoCaballo1 = 70;
            altoCaballo1 = 70;

            anchoCaballo2 = 70;
            altoCaballo2 = 70;

            anchoCaballo3 = 70;
            altoCaballo3 = 70;

            anchoCaballo4 = 70;
            altoCaballo4 = 70;
        }

        //Hilos de los caballos
        Thread hiloCaballo1;
        Thread hiloCaballo2;
        Thread hiloCaballo3;
        Thread hiloCaballo4;

        //Cambio de los caballos
        private int cambioCaballo1;
        private int cambioCaballo2;
        private int cambioCaballo3;
        private int cambioCaballo4;

        private PositionCaballo posCaballo1;
        private PositionCaballo posCaballo2;
        private PositionCaballo posCaballo3;
        private PositionCaballo posCaballo4;

        //Indica que los caballos correran aletatoriamente y siempre habra un ganador diferente
        Random random1 = new Random();
        Random random2 = new Random();
        Random random3 = new Random();
        Random random4 = new Random();

        //Indica el inicio o pausa de los hilos
        Boolean InicioPausaCaballo1 = true;
        Boolean InicioPausaCaballo2 = true;
        Boolean InicioPausaCaballo3 = true;
        Boolean InicioPausaCaballo4 = true;
        Boolean InicioCarrera = false;

        //velocidad de los caballos aleatoriamente
        Random maximoCaballo = new Random();
        int maximo = 60;

        ApuestaCaballos apuestaCaballo;
        int caballoApuesta;       
        Double valorApuestaCaballo;
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;           
            apuestaCaballo = new ApuestaCaballos();
            InitializeComponent();            
            PosicionXy();           
            PosicionAnchoAlto();           
            apuestaCaballo.totalApuesta.Add(apuestaCaballo.valorBase);           
            valorApuestaCaballo = apuestaCaballo.valorBase;         
            lbTotaldinero.Text = valorApuestaCaballo + "";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap("caballo-2.png"), posicionXCaballo1, posicionYCaballo1, anchoCaballo1, altoCaballo1);
            e.Graphics.DrawImage(new Bitmap("caballo-2.png"), posicionXCaballo2, posicionYCaballo2, anchoCaballo2, altoCaballo2);
            e.Graphics.DrawImage(new Bitmap("caballo-2.png"), posicionXCaballo3, posicionYCaballo3, anchoCaballo3, altoCaballo3);
            e.Graphics.DrawImage(new Bitmap("caballo-2.png"), posicionXCaballo4, posicionYCaballo4, anchoCaballo4, altoCaballo4);
        
            }

        public void Repintar1()
        {
            while (InicioPausaCaballo1)
            {
                cambioCaballo1 = random1.Next(maximoCaballo.Next(maximo));
                if (posCaballo1 == PositionCaballo.rightCaballo)
                {
                    if (panel1.Width > posicionXCaballo1 + anchoCaballo1)
                    {
                        posicionXCaballo1 = posicionXCaballo1 + cambioCaballo1;
                    }
                    else
                    {
                        InicioPausaCaballo1 = false;
                        String caballo1 = "1";
                        DarFinalCarrera(caballo1);
                    }
                }
                panel1.Invalidate();
                Thread.Sleep(150);
            }

        }

        public void Repintar2()
        {
            while (InicioPausaCaballo2)
            {
                cambioCaballo2 = random2.Next(maximoCaballo.Next(maximo));
                if (posCaballo2 == PositionCaballo.rightCaballo)
                {
                    if (panel1.Width > posicionXCaballo2 + anchoCaballo2)
                    {
                        posicionXCaballo2 = posicionXCaballo2 + cambioCaballo2;
                    }
                    else
                    {
                        InicioPausaCaballo2 = false;
                        String caballo2 = "2";
                        DarFinalCarrera(caballo2);
                    }
                }
                panel1.Invalidate();
                Thread.Sleep(150);
            }
        }

        public void Repintar3()
        {
            while (InicioPausaCaballo3)
            {
                cambioCaballo3 = random3.Next(maximoCaballo.Next(maximo));
                if (posCaballo3 == PositionCaballo.rightCaballo)
                {
                    if (panel1.Width > posicionXCaballo3 + anchoCaballo3)
                    {
                        posicionXCaballo3 = posicionXCaballo3 + cambioCaballo3;
                    }
                    else
                    {
                        InicioPausaCaballo3 = false;
                        String caballo3 = "3";
                        DarFinalCarrera(caballo3);
                    }
                }
                panel1.Invalidate();
                Thread.Sleep(150);

            }
        }
        public void Repintar4()
        {
            while (InicioPausaCaballo4)
            {
                cambioCaballo4 = random4.Next(maximoCaballo.Next(maximo));
                if (posCaballo4 == PositionCaballo.rightCaballo)
                {
                    if (panel1.Width > posicionXCaballo4 + anchoCaballo4)
                    {
                        posicionXCaballo4 = posicionXCaballo4 + cambioCaballo4;
                    }
                    else
                    {
                        InicioPausaCaballo4 = false;
                        String caballo4 = "4";
                        DarFinalCarrera(caballo4);
                    }
                }
                panel1.Invalidate();
                Thread.Sleep(150);
            }
        }

        //Método para iniciar la carrera
        public void IniciarCarrera()
        {
            InicioCarrera = true;
            hiloCaballo1 = new Thread(Repintar1);
            hiloCaballo1.Start();
            hiloCaballo2 = new Thread(Repintar2);
            hiloCaballo2.Start();
            hiloCaballo3 = new Thread(Repintar3);
            hiloCaballo3.Start();
            hiloCaballo4 = new Thread(Repintar4);
            hiloCaballo4.Start();
        }

        //Método del boton iniciar de la interfaz
        private void button1_Click(object sender, EventArgs e)
        {
            String caballoSeleccionado = cbxCaballo.Text;
            if (string.IsNullOrEmpty(txtApuesta.Text) || string.IsNullOrEmpty(caballoSeleccionado))
            {
                MessageBox.Show("Ingrese Toda La Información");
            }
            else
            {
                caballoApuesta = apuestaCaballo.Combobox(caballoSeleccionado);
                if (caballoApuesta == -1)
                {
                    MessageBox.Show("Seleccione uno de los 4 caballos");
                }
                else
                {
                    valorApuestaCaballo = Convert.ToDouble(txtApuesta.Text);
                    if (valorApuestaCaballo > 0 && valorApuestaCaballo <= apuestaCaballo.ValorApuesta())
                    {
                        if (InicioCarrera == false)
                        {
                            apuestaCaballo.EliminarPosicionesCarrera();
                            InicioPausaCaballo1 = true;
                            InicioPausaCaballo2 = true;
                            InicioPausaCaballo3 = true;
                            InicioPausaCaballo4 = true;
                            IniciarCarrera();
                            btnIniciarCarrera.Text = "Iniciar Carrera";
                            btnIniciarCarrera.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Se Efectua tu apuesta ");
                    }
                  
                }
            }
        }

        private void txtApuesta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo Números", "Ten Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        
         //Método donde se indica el fin de la carrera 
         
        public void DarFinalCarrera(String caballo)
        {
            apuestaCaballo.AgregarPosicionCaballo(caballo);
            if (InicioPausaCaballo1 == false && InicioPausaCaballo2 == false && InicioPausaCaballo3 == false && InicioPausaCaballo4 == false)
            {
                CheckForIllegalCrossThreadCalls = false;
                String ganador = apuestaCaballo.CaballoGanador();
                int numCaballoGanador = Convert.ToInt32(ganador);
                MessageBox.Show("El Ganador De La Carrera Es " + numCaballoGanador);
                InicioCarrera = false;
                PosicionXy();
                PosicionAnchoAlto();
                Boolean respuestaApuesta= apuestaCaballo.realizarApuesta(numCaballoGanador,caballoApuesta,valorApuestaCaballo);
                btnIniciarCarrera.Enabled = true;
                valorApuestaCaballo = apuestaCaballo.ValorApuesta();
                if (respuestaApuesta == true)
                {
                    MessageBox.Show("Tu Caballo Ha Ganado La Carrera. Tu Nuevo Valor Es  " + valorApuestaCaballo);
                    lbTotaldinero.Text = valorApuestaCaballo + "";
                }
                else {   
                    MessageBox.Show("Tu Caballo Ha Perdido La Carrera. Tu Nuevo Valor Es  " + valorApuestaCaballo);
                    lbTotaldinero.Text = valorApuestaCaballo + "";
                }
                foreach (String lista in apuestaCaballo.listadoPosiciones)
                {
                    Console.WriteLine(lista);
                }

            }
        }

        

    }
}

 