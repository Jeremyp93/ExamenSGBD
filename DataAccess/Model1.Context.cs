﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ExamenSGBDEntities : DbContext
    {
        public ExamenSGBDEntities()
            : base("name=ExamenSGBDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CarteGlobale> CarteGlobales { get; set; }
        public virtual DbSet<CarteGroupe> CarteGroupes { get; set; }
        public virtual DbSet<CarteRestaurant> CarteRestaurants { get; set; }
        public virtual DbSet<DetailReservation> DetailReservations { get; set; }
        public virtual DbSet<Groupe> Groupes { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Restaurant> Restaurants { get; set; }
        public virtual DbSet<TablesChaise> TablesChaises { get; set; }
        public virtual DbSet<TypeRepa> TypeRepas { get; set; }
        public virtual DbSet<DetailMenu> DetailMenus { get; set; }
        public virtual DbSet<Menu> Menus { get; set; }
    
        public virtual int ConfirmReservation(Nullable<int> idReservation, Nullable<int> prixTotal)
        {
            var idReservationParameter = idReservation.HasValue ?
                new ObjectParameter("idReservation", idReservation) :
                new ObjectParameter("idReservation", typeof(int));
    
            var prixTotalParameter = prixTotal.HasValue ?
                new ObjectParameter("prixTotal", prixTotal) :
                new ObjectParameter("prixTotal", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ConfirmReservation", idReservationParameter, prixTotalParameter);
        }
    
        public virtual int DeleteReservation(Nullable<int> idReservation)
        {
            var idReservationParameter = idReservation.HasValue ?
                new ObjectParameter("idReservation", idReservation) :
                new ObjectParameter("idReservation", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteReservation", idReservationParameter);
        }
    
        public virtual int InsertDetailReservation(Nullable<int> idReservation, string prenom, Nullable<int> entree, Nullable<int> plat, Nullable<int> dessert, Nullable<int> prix)
        {
            var idReservationParameter = idReservation.HasValue ?
                new ObjectParameter("idReservation", idReservation) :
                new ObjectParameter("idReservation", typeof(int));
    
            var prenomParameter = prenom != null ?
                new ObjectParameter("prenom", prenom) :
                new ObjectParameter("prenom", typeof(string));
    
            var entreeParameter = entree.HasValue ?
                new ObjectParameter("entree", entree) :
                new ObjectParameter("entree", typeof(int));
    
            var platParameter = plat.HasValue ?
                new ObjectParameter("plat", plat) :
                new ObjectParameter("plat", typeof(int));
    
            var dessertParameter = dessert.HasValue ?
                new ObjectParameter("dessert", dessert) :
                new ObjectParameter("dessert", typeof(int));
    
            var prixParameter = prix.HasValue ?
                new ObjectParameter("prix", prix) :
                new ObjectParameter("prix", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertDetailReservation", idReservationParameter, prenomParameter, entreeParameter, platParameter, dessertParameter, prixParameter);
        }
    
        public virtual int InsertReservation(string numero, Nullable<int> idTable, Nullable<System.DateTime> date, string prenom, string nom, Nullable<int> nbreDePersonnes)
        {
            var numeroParameter = numero != null ?
                new ObjectParameter("numero", numero) :
                new ObjectParameter("numero", typeof(string));
    
            var idTableParameter = idTable.HasValue ?
                new ObjectParameter("idTable", idTable) :
                new ObjectParameter("idTable", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            var prenomParameter = prenom != null ?
                new ObjectParameter("prenom", prenom) :
                new ObjectParameter("prenom", typeof(string));
    
            var nomParameter = nom != null ?
                new ObjectParameter("nom", nom) :
                new ObjectParameter("nom", typeof(string));
    
            var nbreDePersonnesParameter = nbreDePersonnes.HasValue ?
                new ObjectParameter("nbreDePersonnes", nbreDePersonnes) :
                new ObjectParameter("nbreDePersonnes", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertReservation", numeroParameter, idTableParameter, dateParameter, prenomParameter, nomParameter, nbreDePersonnesParameter);
        }
    
        public virtual ObjectResult<SelectAllRestaurants_Result> SelectAllRestaurants()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectAllRestaurants_Result>("SelectAllRestaurants");
        }
    
        public virtual ObjectResult<SelectCarteByRestaurantAndType_Result> SelectCarteByRestaurantAndType(Nullable<int> idRestaurant, Nullable<int> idType)
        {
            var idRestaurantParameter = idRestaurant.HasValue ?
                new ObjectParameter("idRestaurant", idRestaurant) :
                new ObjectParameter("idRestaurant", typeof(int));
    
            var idTypeParameter = idType.HasValue ?
                new ObjectParameter("idType", idType) :
                new ObjectParameter("idType", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectCarteByRestaurantAndType_Result>("SelectCarteByRestaurantAndType", idRestaurantParameter, idTypeParameter);
        }
    
        public virtual ObjectResult<SelectElement_Result> SelectElement(Nullable<int> idRestaurant)
        {
            var idRestaurantParameter = idRestaurant.HasValue ?
                new ObjectParameter("idRestaurant", idRestaurant) :
                new ObjectParameter("idRestaurant", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectElement_Result>("SelectElement", idRestaurantParameter);
        }
    
        public virtual ObjectResult<SelectParticipantsParReservation_Result> SelectParticipantsParReservation(Nullable<int> idReservation)
        {
            var idReservationParameter = idReservation.HasValue ?
                new ObjectParameter("idReservation", idReservation) :
                new ObjectParameter("idReservation", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectParticipantsParReservation_Result>("SelectParticipantsParReservation", idReservationParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SelectPrixCarte(Nullable<int> idCarteRestaurant)
        {
            var idCarteRestaurantParameter = idCarteRestaurant.HasValue ?
                new ObjectParameter("idCarteRestaurant", idCarteRestaurant) :
                new ObjectParameter("idCarteRestaurant", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SelectPrixCarte", idCarteRestaurantParameter);
        }
    
        public virtual ObjectResult<SelectTablesByRestaurant_Result> SelectTablesByRestaurant(Nullable<int> idRestaurant, Nullable<System.DateTime> date)
        {
            var idRestaurantParameter = idRestaurant.HasValue ?
                new ObjectParameter("idRestaurant", idRestaurant) :
                new ObjectParameter("idRestaurant", typeof(int));
    
            var dateParameter = date.HasValue ?
                new ObjectParameter("date", date) :
                new ObjectParameter("date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectTablesByRestaurant_Result>("SelectTablesByRestaurant", idRestaurantParameter, dateParameter);
        }
    
        public virtual int SetPrixCarteRestaurant(Nullable<int> idCarteRestaurant, Nullable<int> prix)
        {
            var idCarteRestaurantParameter = idCarteRestaurant.HasValue ?
                new ObjectParameter("idCarteRestaurant", idCarteRestaurant) :
                new ObjectParameter("idCarteRestaurant", typeof(int));
    
            var prixParameter = prix.HasValue ?
                new ObjectParameter("prix", prix) :
                new ObjectParameter("prix", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SetPrixCarteRestaurant", idCarteRestaurantParameter, prixParameter);
        }
    
        public virtual int UpdateDetailReservation(Nullable<int> idDetailReservation, string prenom, Nullable<int> entree, Nullable<int> plat, Nullable<int> dessert, Nullable<int> prix)
        {
            var idDetailReservationParameter = idDetailReservation.HasValue ?
                new ObjectParameter("idDetailReservation", idDetailReservation) :
                new ObjectParameter("idDetailReservation", typeof(int));
    
            var prenomParameter = prenom != null ?
                new ObjectParameter("prenom", prenom) :
                new ObjectParameter("prenom", typeof(string));
    
            var entreeParameter = entree.HasValue ?
                new ObjectParameter("entree", entree) :
                new ObjectParameter("entree", typeof(int));
    
            var platParameter = plat.HasValue ?
                new ObjectParameter("plat", plat) :
                new ObjectParameter("plat", typeof(int));
    
            var dessertParameter = dessert.HasValue ?
                new ObjectParameter("dessert", dessert) :
                new ObjectParameter("dessert", typeof(int));
    
            var prixParameter = prix.HasValue ?
                new ObjectParameter("prix", prix) :
                new ObjectParameter("prix", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateDetailReservation", idDetailReservationParameter, prenomParameter, entreeParameter, platParameter, dessertParameter, prixParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SumPrixDetailReservation(Nullable<int> idReservation)
        {
            var idReservationParameter = idReservation.HasValue ?
                new ObjectParameter("idReservation", idReservation) :
                new ObjectParameter("idReservation", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SumPrixDetailReservation", idReservationParameter);
        }
    
        public virtual int InsertDetailReservationMenu(Nullable<int> idReservation, string prenom, Nullable<int> entree, Nullable<int> plat, Nullable<int> dessert, Nullable<int> prix, Nullable<int> idMenu)
        {
            var idReservationParameter = idReservation.HasValue ?
                new ObjectParameter("idReservation", idReservation) :
                new ObjectParameter("idReservation", typeof(int));
    
            var prenomParameter = prenom != null ?
                new ObjectParameter("prenom", prenom) :
                new ObjectParameter("prenom", typeof(string));
    
            var entreeParameter = entree.HasValue ?
                new ObjectParameter("entree", entree) :
                new ObjectParameter("entree", typeof(int));
    
            var platParameter = plat.HasValue ?
                new ObjectParameter("plat", plat) :
                new ObjectParameter("plat", typeof(int));
    
            var dessertParameter = dessert.HasValue ?
                new ObjectParameter("dessert", dessert) :
                new ObjectParameter("dessert", typeof(int));
    
            var prixParameter = prix.HasValue ?
                new ObjectParameter("prix", prix) :
                new ObjectParameter("prix", typeof(int));
    
            var idMenuParameter = idMenu.HasValue ?
                new ObjectParameter("idMenu", idMenu) :
                new ObjectParameter("idMenu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertDetailReservationMenu", idReservationParameter, prenomParameter, entreeParameter, platParameter, dessertParameter, prixParameter, idMenuParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> SelectMenu(Nullable<int> idDetailReservation)
        {
            var idDetailReservationParameter = idDetailReservation.HasValue ?
                new ObjectParameter("idDetailReservation", idDetailReservation) :
                new ObjectParameter("idDetailReservation", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("SelectMenu", idDetailReservationParameter);
        }
    
        public virtual ObjectResult<SelectDessertMenu_Result> SelectDessertMenu(Nullable<int> idMenu)
        {
            var idMenuParameter = idMenu.HasValue ?
                new ObjectParameter("idMenu", idMenu) :
                new ObjectParameter("idMenu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectDessertMenu_Result>("SelectDessertMenu", idMenuParameter);
        }
    
        public virtual ObjectResult<SelectEntreeMenu_Result> SelectEntreeMenu(Nullable<int> idMenu)
        {
            var idMenuParameter = idMenu.HasValue ?
                new ObjectParameter("idMenu", idMenu) :
                new ObjectParameter("idMenu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectEntreeMenu_Result>("SelectEntreeMenu", idMenuParameter);
        }
    
        public virtual ObjectResult<SelectPlatMenu_Result> SelectPlatMenu(Nullable<int> idMenu)
        {
            var idMenuParameter = idMenu.HasValue ?
                new ObjectParameter("idMenu", idMenu) :
                new ObjectParameter("idMenu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectPlatMenu_Result>("SelectPlatMenu", idMenuParameter);
        }
    
        public virtual ObjectResult<SelectCarteMenu_Result> SelectCarteMenu(Nullable<int> idMenu, Nullable<int> type)
        {
            var idMenuParameter = idMenu.HasValue ?
                new ObjectParameter("idMenu", idMenu) :
                new ObjectParameter("idMenu", typeof(int));
    
            var typeParameter = type.HasValue ?
                new ObjectParameter("type", type) :
                new ObjectParameter("type", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SelectCarteMenu_Result>("SelectCarteMenu", idMenuParameter, typeParameter);
        }
    
        public virtual int UpdateDetailReservationMenu(Nullable<int> idDetailReservation, string prenom, Nullable<int> entree, Nullable<int> plat, Nullable<int> dessert, Nullable<int> prix, Nullable<int> idMenu)
        {
            var idDetailReservationParameter = idDetailReservation.HasValue ?
                new ObjectParameter("idDetailReservation", idDetailReservation) :
                new ObjectParameter("idDetailReservation", typeof(int));
    
            var prenomParameter = prenom != null ?
                new ObjectParameter("prenom", prenom) :
                new ObjectParameter("prenom", typeof(string));
    
            var entreeParameter = entree.HasValue ?
                new ObjectParameter("entree", entree) :
                new ObjectParameter("entree", typeof(int));
    
            var platParameter = plat.HasValue ?
                new ObjectParameter("plat", plat) :
                new ObjectParameter("plat", typeof(int));
    
            var dessertParameter = dessert.HasValue ?
                new ObjectParameter("dessert", dessert) :
                new ObjectParameter("dessert", typeof(int));
    
            var prixParameter = prix.HasValue ?
                new ObjectParameter("prix", prix) :
                new ObjectParameter("prix", typeof(int));
    
            var idMenuParameter = idMenu.HasValue ?
                new ObjectParameter("idMenu", idMenu) :
                new ObjectParameter("idMenu", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateDetailReservationMenu", idDetailReservationParameter, prenomParameter, entreeParameter, platParameter, dessertParameter, prixParameter, idMenuParameter);
        }
    }
}
