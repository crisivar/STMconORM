#pragma warning disable 1591
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
	public partial class Solicitud_reclamo
	{
		private int _id_Tarjeta;
		public virtual int Id_tarjeta 
		{ 
		    get
		    {
		        return this._id_Tarjeta;
		    }
		    set
		    {
		        this._id_Tarjeta = value;
		    }
		}
		
		private int _id_Estacion;
		public virtual int Id_estacion 
		{ 
		    get
		    {
		        return this._id_Estacion;
		    }
		    set
		    {
		        this._id_Estacion = value;
		    }
		}
		
		private string _tipo;
		public virtual string Tipo 
		{ 
		    get
		    {
		        return this._tipo;
		    }
		    set
		    {
		        this._tipo = value;
		    }
		}
		
		private string _descripcion;
		public virtual string Descripcion 
		{ 
		    get
		    {
		        return this._descripcion;
		    }
		    set
		    {
		        this._descripcion = value;
		    }
		}
		
		private Estacion _estacion;
		public virtual Estacion Estacion 
		{ 
		    get
		    {
		        return this._estacion;
		    }
		    set
		    {
		        this._estacion = value;
		    }
		}
		
		private Tarjetum _tarjetum;
		public virtual Tarjetum Tarjetum 
		{ 
		    get
		    {
		        return this._tarjetum;
		    }
		    set
		    {
		        this._tarjetum = value;
		    }
		}
		
	}
}