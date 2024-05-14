using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPachecoEtapa5
{
    public partial class frmEtapa5 : Form
    {
        public frmEtapa5()
        {
            InitializeComponent();
        }

        clsVehiculo objAuto;
        clsVehiculo objAvion;
        clsVehiculo objBarco;
        bool Auto = false;
        bool Avion = false;
        bool Barco = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            objAuto = new clsVehiculo();
            objAvion = new clsVehiculo();
            objBarco = new clsVehiculo();

            objAuto.CrearAuto();
            objAvion.CrearAvion();
            objBarco.CrearBarco();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Random random = new Random(); //Random esta cambiando constantemente
            int Numero = random.Next(1, 4); //"Numero" toma el valor en ese instante y lo guarda, entre valores determinados

            switch (Numero)
            {
                case 1:
                    objAuto.CrearAuto();
                    objAuto.pctAuto.Location = new Point(300, 50);
                    Controls.Add(objAuto.pctAuto);
                    Auto = true;
                    if (Avion == true)
                    {
                        objAvion.pctAvion.Dispose();
                        Avion = false;
                    }
                    if (Barco == true)
                    {
                        objBarco.pctBarco.Dispose();
                        Barco = false;
                    }
                    break;

                case 2:
                    objAvion.CrearAvion();
                    objAvion.pctAvion.Location = new Point(300, 50);
                    Controls.Add(objAvion.pctAvion);
                    Avion = true;
                    if (Auto == true)
                    {
                        objAuto.pctAuto.Dispose();
                        Auto = false;
                    }
                    if (Barco == true)
                    {
                        objBarco.pctBarco.Dispose();
                        Barco = true;
                    }
                    break;

                case 3:
                    objBarco.CrearBarco();
                    objBarco.pctBarco.Location = new Point(300, 50);
                    Controls.Add(objBarco.pctBarco);
                    Barco = true;
                    if (Avion == true)
                    {
                        objAvion.pctAvion.Dispose();
                        Avion = false;
                    }
                    if (Auto == true)
                    {
                        objAuto.pctAuto.Dispose();
                        Auto = false;
                    }
                    break;
            }
        }
    }
}