﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using ORM_STM;


namespace ORM_STM	
{
	public partial class EntitiesModel : OpenAccessContext, IEntitiesModelUnitOfWork
	{
		private static string connectionStringName = @"Coneccion";
			
		private static BackendConfiguration backend = GetBackendConfiguration();
		
			
		private static MetadataSource metadataSource = XmlMetadataSource.FromAssemblyResource("EntitiesModel.rlinq");
	
		public EntitiesModel()
			:base(connectionStringName, backend, metadataSource)
		{ }
		
		public EntitiesModel(string connection)
			:base(connection, backend, metadataSource)
		{ }
	
		public EntitiesModel(BackendConfiguration backendConfiguration)
			:base(connectionStringName, backendConfiguration, metadataSource)
		{ }
			
		public EntitiesModel(string connection, MetadataSource metadataSource)
			:base(connection, backend, metadataSource)
		{ }
		
		public EntitiesModel(string connection, BackendConfiguration backendConfiguration, MetadataSource metadataSource)
			:base(connection, backendConfiguration, metadataSource)
		{ }
			
		public IQueryable<Tarjeta_personalizada> Tarjeta_personalizadas 
		{
	    	get
	    	{
	        	return this.GetAll<Tarjeta_personalizada>();
	    	}
		}
		
		public IQueryable<Tarjetum> Tarjeta 
		{
	    	get
	    	{
	        	return this.GetAll<Tarjetum>();
	    	}
		}
		
		public IQueryable<Solicitud_reclamo> Solicitud_reclamos 
		{
	    	get
	    	{
	        	return this.GetAll<Solicitud_reclamo>();
	    	}
		}
		
		public IQueryable<Ruta> Rutas 
		{
	    	get
	    	{
	        	return this.GetAll<Ruta>();
	    	}
		}
		
		public IQueryable<Recarga> Recargas 
		{
	    	get
	    	{
	        	return this.GetAll<Recarga>();
	    	}
		}
		
		public IQueryable<Programacion> Programacions 
		{
	    	get
	    	{
	        	return this.GetAll<Programacion>();
	    	}
		}
		
		public IQueryable<Estacion> Estacions 
		{
	    	get
	    	{
	        	return this.GetAll<Estacion>();
	    	}
		}
		
		public IQueryable<Empleado> Empleados 
		{
	    	get
	    	{
	        	return this.GetAll<Empleado>();
	    	}
		}
		
		public IQueryable<Consumo> Consumos 
		{
	    	get
	    	{
	        	return this.GetAll<Consumo>();
	    	}
		}
		
		public IQueryable<Bu> Bus 
		{
	    	get
	    	{
	        	return this.GetAll<Bu>();
	    	}
		}
		
		public static BackendConfiguration GetBackendConfiguration()
		{
			BackendConfiguration backend = new BackendConfiguration();
			backend.Backend = "PostgreSql";
			backend.ProviderName = "Npgsql";
			return backend;
		}
	}

	public interface IEntitiesModelUnitOfWork : IUnitOfWork
	{
		IQueryable<Tarjeta_personalizada> Tarjeta_personalizadas 
		{ 
			get;
		}

		IQueryable<Tarjetum> Tarjeta 
		{ 
			get;
		}

		IQueryable<Solicitud_reclamo> Solicitud_reclamos 
		{ 
			get;
		}

		IQueryable<Ruta> Rutas 
		{ 
			get;
		}

		IQueryable<Recarga> Recargas 
		{ 
			get;
		}

		IQueryable<Programacion> Programacions 
		{ 
			get;
		}

		IQueryable<Estacion> Estacions 
		{ 
			get;
		}

		IQueryable<Empleado> Empleados 
		{ 
			get;
		}

		IQueryable<Consumo> Consumos 
		{ 
			get;
		}

		IQueryable<Bu> Bus 
		{ 
			get;
		}

	}
}
#pragma warning restore 1591

