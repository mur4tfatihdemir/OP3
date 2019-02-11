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
        public static volatile GenelCrud<OtelOzelligi> _OtelOzelligiCrud = null;
        public static GenelCrud<OtelOzelligi> OtelOzelligiCrud
        {
            get
            {
                if (_OtelOzelligiCrud == null)
                {
                    _OtelOzelligiCrud = new GenelCrud<OtelOzelligi>(Db, Db.OtelOzellikleri);
                }
                return _OtelOzelligiCrud;
            }
        }
        public static volatile GenelCrud<OtelResimleri> _OtelResimleriCrud = null;
        public static GenelCrud<OtelResimleri> OtelResimleriCrud
        {
            get
            {
                if (_OtelResimleriCrud == null)
                {
                    _OtelResimleriCrud = new GenelCrud<OtelResimleri>(Db, Db.OtelResimleri);
                }
                return _OtelResimleriCrud;
            }
        }
        public static volatile GenelCrud<Ozellik> _OzellikCrud = null;
        public static GenelCrud<Ozellik> OzellikCrud
        {
            get
            {
                if (_OzellikCrud == null)
                {
                    _OzellikCrud = new GenelCrud<Ozellik>(Db, Db.Ozellikler);
                }
                return _OzellikCrud;
            }
        }
        public static volatile GenelCrud<Rezervasyon> _RezerasyonCrud = null;
        public static GenelCrud<Rezervasyon> RezervasyonCrud
        {
            get
            {
                if (_RezerasyonCrud == null)
                {
                    _RezerasyonCrud = new GenelCrud<Rezervasyon>(Db, Db.Rezervasyonlar);
                }
                return _RezerasyonCrud;
            }
        }
        public static volatile GenelCrud<Yildiz> _YildizCrud = null;
        public static GenelCrud<Yildiz> YildizCrud
        {
            get
            {
                if (_YildizCrud == null)
                {
                    _YildizCrud = new GenelCrud<Yildiz>(Db, Db.Yildizlar);
                }
                return _YildizCrud;
            }
        }
        public static volatile GenelCrud<Yorum> _YorumCrud = null;
        public static GenelCrud<Yorum> YorumCrud
        {
            get
            {
                if (_YorumCrud == null)
                {
                    _YorumCrud = new GenelCrud<Yorum>(Db, Db.Yorumlar);
                }
                return _YorumCrud;
            }
        }






    }
}
