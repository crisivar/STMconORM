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
	public partial class Recarga
	{
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
		
		private DateTime? _fecha;
		public virtual DateTime? Fecha 
		{ 
		    get
		    {
		        return this._fecha;
		    }
		    set
		    {
		        this._fecha = value;
		    }
		}
		
		private DateTime? _hora;
		public virtual DateTime? Hora 
		{ 
		    get
		    {
		        return this._hora;
		    }
		    set
		    {
		        this._hora = value;
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