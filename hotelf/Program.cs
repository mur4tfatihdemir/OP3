using hotelf.classlibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelf
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Dfactory1.IlceCrud.CheckConnection();
            Dfactory1.IlCrud.CheckConnection();
            Dfactory1.MahalleCrud.CheckConnection();
            Dfactory1.MusteriCrud.CheckConnection();
            Dfactory1.OdaCrud.CheckConnection();
            Dfactory1.OtelCrud.CheckConnection();
            Dfactory1.OtelOzelligiCrud.CheckConnection();
            Dfactory1.OtelResimleriCrud.CheckConnection();
            Dfactory1.OzellikCrud.CheckConnection();
            Dfactory1.RezervasyonCrud.CheckConnection();
            Dfactory1.YildizCrud.CheckConnection();
            Dfactory1.YorumCrud.CheckConnection();
            Application.Run(new Form1());


        }
    }
}
