﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;


namespace pryPachecoEtapa5
{
    class clsVehiculo
    {
        public PictureBox pctAuto;
        public PictureBox pctAvion;
        public PictureBox pctBarco;
        public string tipoVehiculo;

        public void CrearAuto()
        {
            pctAuto = new PictureBox();
            pctAuto.SizeMode = PictureBoxSizeMode.StretchImage;
            pctAuto.Width = 200;
            pctAuto.Height = 200;
            pctAuto.BackColor = Color.Transparent;
            string ruta = Path.Combine(Application.StartupPath, "..", "..", "Resources", "auto.png");
            pctAuto.ImageLocation = ruta;
            tipoVehiculo = "Auto";
        }
        public void CrearAvion()
        {
            pctAvion = new PictureBox();
            pctAvion.SizeMode = PictureBoxSizeMode.StretchImage;
            pctAvion.Width = 200;
            pctAvion.Height = 200;
            pctAvion.BackColor = Color.Transparent;
            string ruta = Path.Combine(Application.StartupPath, "..", "..", "Resources", "avion.png");
            pctAvion.ImageLocation = ruta;
            tipoVehiculo = "Avión";
        }
        public void CrearBarco()
        {
            pctBarco = new PictureBox();
            pctBarco.SizeMode = PictureBoxSizeMode.StretchImage;
            pctBarco.Width = 200;
            pctBarco.Height = 200;
            pctBarco.BackColor = Color.Transparent;
            string ruta = Path.Combine(Application.StartupPath, "..", "..", "Resources", "barco.png");
            pctBarco.ImageLocation = ruta;
            tipoVehiculo = "Barco";
        }
    }
}
