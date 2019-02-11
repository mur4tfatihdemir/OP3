namespace hotelf
{
    using hotelf.classlibrary;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model1 : DbContext
    {
        // Your context has been configured to use a 'Model1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'hotelf.Model1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model1' 
        // connection string in the application configuration file.
        public Model1()
            : base("name=Model1")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<IL> Ils { get; set; }
        public virtual DbSet<Ilce> Ilces { get; set; }
        public virtual DbSet<mahalleid> Mahalleids { get; set; }
        public virtual DbSet<musteri> musteris { get; set; }
        public virtual DbSet<oda> odas { get; set; }
        //  public virtual DbSet<odatipienum > Odatipienum1s { get; set; }

        public virtual DbSet<otelozelligi> Otelozelligis { get; set; }
        public virtual DbSet<otelresimleri> Otelresimleris { get; set; }
        public virtual DbSet<ozellik> Ozelliks { get; set; }
        public virtual DbSet<rezervasyon> Rezervasyons { get; set; }
        public virtual DbSet<yildiz> Yildizs { get; set; }
        public virtual DbSet<yorum> yorus { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}