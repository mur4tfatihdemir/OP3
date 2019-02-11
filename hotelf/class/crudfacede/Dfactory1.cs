using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelf.classlibrary
{
    class Dfactory1
    {
         
       
                  private static volatile Model1 _db = null;
        public static Model1 Db
        {
            get
            {
                if (_db == null)
                {
                    _db = new Model1();
                }
                return _db;
            }
        }

        public static volatile Oteltumislem<IL> _IlCrud = null;
        public static Oteltumislem<IL> IlCrud
        {
            get
            {
                if (_IlCrud == null)
                {
                    _IlCrud = new Oteltumislem<IL>(Db, Db.Ils);
                }
                return _IlCrud;
            }
        }
        public static volatile Oteltumislem<Ilce> _IlceCrud = null;
        public static Oteltumislem<Ilce> IlceCrud
        {
            get
            {
                if (_IlceCrud == null)
                {
                    _IlceCrud = new Oteltumislem<Ilce>(Db, Db.Ilces);
                }
                return _IlceCrud;
            }
        }
        public static volatile Oteltumislem<mahalleid> _MahalleCrud = null;
        public static Oteltumislem<mahalleid> MahalleCrud
        {
            get
            {
                if (_MahalleCrud == null)
                {
                    _MahalleCrud = new Oteltumislem<mahalleid>(Db, Db.Mahalleids);
                }
                return _MahalleCrud;
            }
        }

        public static volatile Oteltumislem<musteri> _MusteriCrud = null;
        public static Oteltumislem<musteri> MusteriCrud
        {
            get
            {
                if (_MusteriCrud == null)
                {
                    _MusteriCrud = new Oteltumislem<musteri>(Db, Db.musteris);
                }
                return _MusteriCrud;
            }
        }
        public static volatile Oteltumislem<oda> _OdaCrud = null;
        public static Oteltumislem<oda> OdaCrud
        {
            get
            {
                if (_OdaCrud == null)
                {
                    _OdaCrud = new Oteltumislem<oda>(Db, Db.odas);
                }
                return _OdaCrud;
            }
        }
        public static volatile Oteltumislem<otel> _OtelCrud = null;
        public static Oteltumislem<otel> OtelCrud
        {
            get
            {
                if (_OtelCrud == null)
                {
                    _OtelCrud = new Oteltumislem<otel>(Db, Db.Otels);
                }
                return _OtelCrud;
            }
        }
        public static volatile Oteltumislem<otelozelligi> _OtelOzelligiCrud = null;
        public static Oteltumislem<otelozelligi> OtelOzelligiCrud
        {
            get
            {
                if (_OtelOzelligiCrud == null)
                {
                    _OtelOzelligiCrud = new Oteltumislem<otelozelligi>(Db, Db.Otelozelligis);
                }
                return _OtelOzelligiCrud;
            }
        }
        public static volatile Oteltumislem<otelresimleri> _OtelResimleriCrud = null;
        public static Oteltumislem<otelresimleri> OtelResimleriCrud
        {
            get
            {
                if (_OtelResimleriCrud == null)
                {
                    _OtelResimleriCrud = new Oteltumislem<otelresimleri>(Db, Db.Otelresimleris);
                }
                return _OtelResimleriCrud;
            }
        }
        public static volatile Oteltumislem<ozellik> _OzellikCrud = null;
        public static Oteltumislem<ozellik> OzellikCrud
        {
            get
            {
                if (_OzellikCrud == null)
                {
                    _OzellikCrud = new Oteltumislem<ozellik>(Db, Db.Ozelliks);
                }
                return _OzellikCrud;
            }
        }
        public static volatile Oteltumislem<rezervasyon> _RezerasyonCrud = null;
        public static Oteltumislem<rezervasyon> RezervasyonCrud
        {
            get
            {
                if (_RezerasyonCrud == null)
                {
                    _RezerasyonCrud = new Oteltumislem<rezervasyon>(Db, Db.Rezervasyons);
                }
                return _RezerasyonCrud;
            }
        }
        public static volatile Oteltumislem<yildiz> _YildizCrud = null;
        public static Oteltumislem<yildiz> YildizCrud
        {
            get
            {
                if (_YildizCrud == null)
                {
                    _YildizCrud = new Oteltumislem<yildiz>(Db, Db.Yildizs);
                }
                return _YildizCrud;
            }
        }
        public static volatile Oteltumislem<yorum> _YorumCrud = null;
        public static Oteltumislem<yorum> YorumCrud
        {
            get
            {
                if (_YorumCrud == null)
                {
                    _YorumCrud = new Oteltumislem<yorum>(Db, Db.yorus);
                }
                return _YorumCrud;
            }
        }






    }
}
