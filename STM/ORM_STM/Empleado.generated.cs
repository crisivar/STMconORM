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
	public partial class Empleado
	{
		private int _id;
		public virtual int Id 
		{ 
		    get
		    {
		        return this._id;
		    }
		    set
		    {
		        this._id = value;
		    }
		}
		
		private string _nombre;
		public virtual string Nombre 
		{ 
		    get
		    {
		        return this._nombre;
		    }
		    set
		    {
		        this._nombre = value;
		    }
		}
		
		private string _tipo_Id;
		public virtual string Tipo_id 
		{ 
		    get
		    {
		        return this._tipo_Id;
		    }
		    set
		    {
		        this._tipo_Id = value;
		    }
		}
		
		private string _cargo;
		public virtual string Cargo 
		{ 
		    get
		    {
		        return this._cargo;
		    }
		    set
		    {
		        this._cargo = value;
		    }
		}
		
		private string _email;
		public virtual string Email 
		{ 
		    get
		    {
		        return this._email;
		    }
		    set
		    {
		        this._email = value;
		    }
		}
		
		private string _direccion;
		public virtual string Direccion 
		{ 
		    get
		    {
		        return this._direccion;
		    }
		    set
		    {
		        this._direccion = value;
		    }
		}
		
		private string _telefono;
		public virtual string Telefono 
		{ 
		    get
		    {
		        return this._telefono;
		    }
		    set
		    {
		        this._telefono = value;
		    }
		}
		
		private int? _salario;
		public virtual int? Salario 
		{ 
		    get
		    {
		        return this._salario;
		    }
		    set
		    {
		        this._salario = value;
		    }
		}
		
		private bool? _estado;
		public virtual bool? Estado 
		{ 
		    get
		    {
		        return this._estado;
		    }
		    set
		    {
		        this._estado = value;
		    }
		}
		
		private int? _id_Estacion;
		public virtual int? Id_estacion 
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
		
		private string _contrasena;
		public virtual string Contrasena 
		{ 
		    get
		    {
		        return this._contrasena;
		    }
		    set
		    {
		        this._contrasena = value;
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
		
		private IList<Programacion> _programacions = new List<Programacion>();
		public virtual IList<Programacion> Programacions 
		{ 
		    get
		    {
		        return this._programacions;
		    }
		}
		
	}
}
