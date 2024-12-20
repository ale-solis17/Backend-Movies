﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Movies.AccesoDatos
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ulatina")]
	public partial class ConexionDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public ConexionDataContext() : 
				base(global::Movies.Properties.Settings.Default.ulatinaConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public ConexionDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConexionDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConexionDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ConexionDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Movies_DB.SP_ACTUALIZAR_USUARIO")]
		public int SP_ACTUALIZAR_USUARIO([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDUSUARIO", DbType="BigInt")] System.Nullable<long> iDUSUARIO, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NAME", DbType="NVarChar(MAX)")] string nAME, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LASTNAME", DbType="NVarChar(MAX)")] string lASTNAME, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PASSWORD", DbType="NVarChar(MAX)")] string pASSWORD, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NICKNAME", DbType="NVarChar(MAX)")] string nICKNAME, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDRETURN", DbType="Int")] ref System.Nullable<int> iDRETURN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORID", DbType="Int")] ref System.Nullable<int> eRRORID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORDESCRIPCION", DbType="NVarChar(MAX)")] ref string eRRORDESCRIPCION)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDUSUARIO, nAME, lASTNAME, pASSWORD, nICKNAME, iDRETURN, eRRORID, eRRORDESCRIPCION);
			iDRETURN = ((System.Nullable<int>)(result.GetParameterValue(5)));
			eRRORID = ((System.Nullable<int>)(result.GetParameterValue(6)));
			eRRORDESCRIPCION = ((string)(result.GetParameterValue(7)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Movies_DB.SP_BORRAR_COMENTARIO")]
		public int SP_BORRAR_COMENTARIO([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDUSUARIO", DbType="BigInt")] System.Nullable<long> iDUSUARIO, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDCOMENTARIO", DbType="BigInt")] System.Nullable<long> iDCOMENTARIO, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDRETURN", DbType="BigInt")] ref System.Nullable<long> iDRETURN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORID", DbType="Int")] ref System.Nullable<int> eRRORID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORDESCRIPCION", DbType="NVarChar(MAX)")] ref string eRRORDESCRIPCION)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDUSUARIO, iDCOMENTARIO, iDRETURN, eRRORID, eRRORDESCRIPCION);
			iDRETURN = ((System.Nullable<long>)(result.GetParameterValue(2)));
			eRRORID = ((System.Nullable<int>)(result.GetParameterValue(3)));
			eRRORDESCRIPCION = ((string)(result.GetParameterValue(4)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Movies_DB.SP_CREAR_USUARIO")]
		public int SP_CREAR_USUARIO([global::System.Data.Linq.Mapping.ParameterAttribute(Name="NAME", DbType="NVarChar(MAX)")] string nAME, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LASTNAME", DbType="NVarChar(MAX)")] string lASTNAME, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MAIL", DbType="NVarChar(MAX)")] string mAIL, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PASSWORD", DbType="NVarChar(MAX)")] string pASSWORD, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NICKNAME", DbType="NVarChar(MAX)")] string nICKNAME, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDRETURN", DbType="Int")] ref System.Nullable<int> iDRETURN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORID", DbType="Int")] ref System.Nullable<int> eRRORID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORDESCRIPCION", DbType="NVarChar(MAX)")] ref string eRRORDESCRIPCION)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nAME, lASTNAME, mAIL, pASSWORD, nICKNAME, iDRETURN, eRRORID, eRRORDESCRIPCION);
			iDRETURN = ((System.Nullable<int>)(result.GetParameterValue(5)));
			eRRORID = ((System.Nullable<int>)(result.GetParameterValue(6)));
			eRRORDESCRIPCION = ((string)(result.GetParameterValue(7)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Movies_DB.SP_TRAER_USUARIO")]
		public int SP_TRAER_USUARIO([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDUSUARIO", DbType="BigInt")] System.Nullable<long> iDUSUARIO, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDRETURN", DbType="BigInt")] ref System.Nullable<long> iDRETURN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NAME", DbType="NVarChar(50)")] ref string nAME, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="LASTNAME", DbType="NVarChar(50)")] ref string lASTNAME, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MAIL", DbType="NVarChar(50)")] ref string mAIL, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NICKNAME", DbType="NVarChar(50)")] ref string nICKNAME, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="USERTYPE", DbType="NVarChar(20)")] ref string uSERTYPE, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="USERSTATUS", DbType="NVarChar(20)")] ref string uSERSTATUS)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDUSUARIO, iDRETURN, nAME, lASTNAME, mAIL, nICKNAME, uSERTYPE, uSERSTATUS);
			iDRETURN = ((System.Nullable<long>)(result.GetParameterValue(1)));
			nAME = ((string)(result.GetParameterValue(2)));
			lASTNAME = ((string)(result.GetParameterValue(3)));
			mAIL = ((string)(result.GetParameterValue(4)));
			nICKNAME = ((string)(result.GetParameterValue(5)));
			uSERTYPE = ((string)(result.GetParameterValue(6)));
			uSERSTATUS = ((string)(result.GetParameterValue(7)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Movies_DB.SP_LOGIN_USUARIO")]
		public int SP_LOGIN_USUARIO([global::System.Data.Linq.Mapping.ParameterAttribute(Name="CORREO_ELECTRONICO", DbType="NVarChar(50)")] string cORREO_ELECTRONICO, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="PASSWORD", DbType="NVarChar(50)")] string pASSWORD, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDRETURN", DbType="Int")] ref System.Nullable<int> iDRETURN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORID", DbType="Int")] ref System.Nullable<int> eRRORID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORDESCRIPCION", DbType="NVarChar(MAX)")] ref string eRRORDESCRIPCION, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NOMBRE", DbType="NVarChar(100)")] ref string nOMBRE, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="APELLIDOS", DbType="NVarChar(100)")] ref string aPELLIDOS, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NICKNAME", DbType="NVarChar(100)")] ref string nICKNAME, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="USERTYPE", DbType="NVarChar(20)")] ref string uSERTYPE, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="USERSTATUS", DbType="NVarChar(20)")] ref string uSERSTATUS)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), cORREO_ELECTRONICO, pASSWORD, iDRETURN, eRRORID, eRRORDESCRIPCION, nOMBRE, aPELLIDOS, nICKNAME, uSERTYPE, uSERSTATUS);
			iDRETURN = ((System.Nullable<int>)(result.GetParameterValue(2)));
			eRRORID = ((System.Nullable<int>)(result.GetParameterValue(3)));
			eRRORDESCRIPCION = ((string)(result.GetParameterValue(4)));
			nOMBRE = ((string)(result.GetParameterValue(5)));
			aPELLIDOS = ((string)(result.GetParameterValue(6)));
			nICKNAME = ((string)(result.GetParameterValue(7)));
			uSERTYPE = ((string)(result.GetParameterValue(8)));
			uSERSTATUS = ((string)(result.GetParameterValue(9)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Movies_DB.SP_CREAR_COMENTARIO")]
		public int SP_CREAR_COMENTARIO([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDUSUARIO", DbType="BigInt")] System.Nullable<long> iDUSUARIO, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDMOVIE", DbType="BigInt")] System.Nullable<long> iDMOVIE, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="COMENTARIO", DbType="NVarChar(MAX)")] string cOMENTARIO, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="RATING", DbType="Decimal(3,2)")] System.Nullable<decimal> rATING, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDRETURN", DbType="BigInt")] ref System.Nullable<long> iDRETURN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORID", DbType="Int")] ref System.Nullable<int> eRRORID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORDESCRIPCION", DbType="NVarChar(MAX)")] ref string eRRORDESCRIPCION)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDUSUARIO, iDMOVIE, cOMENTARIO, rATING, iDRETURN, eRRORID, eRRORDESCRIPCION);
			iDRETURN = ((System.Nullable<long>)(result.GetParameterValue(4)));
			eRRORID = ((System.Nullable<int>)(result.GetParameterValue(5)));
			eRRORDESCRIPCION = ((string)(result.GetParameterValue(6)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Movies_DB.SP_GENEROS")]
		public ISingleResult<SP_GENEROSResult> SP_GENEROS()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_GENEROSResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Movies_DB.SP_CREAR_PELICULA")]
		public int SP_CREAR_PELICULA([global::System.Data.Linq.Mapping.ParameterAttribute(Name="NAME", DbType="NVarChar(50)")] string nAME, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DIRECTOR", DbType="NVarChar(50)")] string dIRECTOR, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MOVIETIME", DbType="Int")] System.Nullable<int> mOVIETIME, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CREATEDAT", DbType="Date")] System.Nullable<System.DateTime> cREATEDAT, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SYNOPSIS", DbType="NVarChar(MAX)")] string sYNOPSIS, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MOVIETYPES", DbType="NVarChar(MAX)")] string mOVIETYPES, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="URL", DbType="NVarChar(255)")] string uRL, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDRETURN", DbType="BigInt")] ref System.Nullable<long> iDRETURN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORID", DbType="Int")] ref System.Nullable<int> eRRORID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORDESCRIPCION", DbType="NVarChar(MAX)")] ref string eRRORDESCRIPCION)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), nAME, dIRECTOR, mOVIETIME, cREATEDAT, sYNOPSIS, mOVIETYPES, uRL, iDRETURN, eRRORID, eRRORDESCRIPCION);
			iDRETURN = ((System.Nullable<long>)(result.GetParameterValue(7)));
			eRRORID = ((System.Nullable<int>)(result.GetParameterValue(8)));
			eRRORDESCRIPCION = ((string)(result.GetParameterValue(9)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Movies_DB.SP_MOSTRAR_PELICULAS")]
		public ISingleResult<SP_MOSTRAR_PELICULASResult> SP_MOSTRAR_PELICULAS()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<SP_MOSTRAR_PELICULASResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Movies_DB.SP_Mostrar_Pelicula_Especifica")]
		public int SP_Mostrar_Pelicula_Especifica([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDMOVIEESPECIFICA", DbType="BigInt")] System.Nullable<long> iDMOVIEESPECIFICA, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NAME", DbType="NVarChar(50)")] ref string nAME, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="RATING", DbType="Decimal(3,2)")] ref System.Nullable<decimal> rATING, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DIRECTOR", DbType="NVarChar(50)")] ref string dIRECTOR, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MOVIETIME", DbType="Int")] ref System.Nullable<int> mOVIETIME, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="INSERTDATE", DbType="Date")] ref System.Nullable<System.DateTime> iNSERTDATE, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SYNOPSIS", DbType="NVarChar(MAX)")] ref string sYNOPSIS, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="GENEROS", DbType="NVarChar(255)")] ref string gENEROS, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="URL", DbType="NVarChar(255)")] ref string uRL)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDMOVIEESPECIFICA, nAME, rATING, dIRECTOR, mOVIETIME, iNSERTDATE, sYNOPSIS, gENEROS, uRL);
			nAME = ((string)(result.GetParameterValue(1)));
			rATING = ((System.Nullable<decimal>)(result.GetParameterValue(2)));
			dIRECTOR = ((string)(result.GetParameterValue(3)));
			mOVIETIME = ((System.Nullable<int>)(result.GetParameterValue(4)));
			iNSERTDATE = ((System.Nullable<System.DateTime>)(result.GetParameterValue(5)));
			sYNOPSIS = ((string)(result.GetParameterValue(6)));
			gENEROS = ((string)(result.GetParameterValue(7)));
			uRL = ((string)(result.GetParameterValue(8)));
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Movies_DB.SP_MOSTRAR_COMENTARIOS")]
		public ISingleResult<SP_MOSTRAR_COMENTARIOSResult> SP_MOSTRAR_COMENTARIOS([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDMOVIE", DbType="BigInt")] System.Nullable<long> iDMOVIE, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDRETURN", DbType="Int")] ref System.Nullable<int> iDRETURN, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORID", DbType="Int")] ref System.Nullable<int> eRRORID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="ERRORDESCRIPCION", DbType="NVarChar(MAX)")] ref string eRRORDESCRIPCION)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDMOVIE, iDRETURN, eRRORID, eRRORDESCRIPCION);
			iDRETURN = ((System.Nullable<int>)(result.GetParameterValue(1)));
			eRRORID = ((System.Nullable<int>)(result.GetParameterValue(2)));
			eRRORDESCRIPCION = ((string)(result.GetParameterValue(3)));
			return ((ISingleResult<SP_MOSTRAR_COMENTARIOSResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Movies_DB.SP_PELICULA_INICIO")]
		public ISingleResult<SP_PELICULA_INICIOResult> SP_PELICULA_INICIO([global::System.Data.Linq.Mapping.ParameterAttribute(Name="FIRSTID", DbType="BigInt")] ref System.Nullable<long> fIRSTID, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="NAME", DbType="NVarChar(50)")] ref string nAME, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="DIRECTOR", DbType="NVarChar(50)")] ref string dIRECTOR, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="MOVIETIME", DbType="Int")] ref System.Nullable<int> mOVIETIME, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="CREATEDAT", DbType="Date")] ref System.Nullable<System.DateTime> cREATEDAT, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="SYNOPSIS", DbType="NVarChar(MAX)")] ref string sYNOPSIS, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="GENEROS", DbType="NVarChar(MAX)")] ref string gENEROS, [global::System.Data.Linq.Mapping.ParameterAttribute(Name="URL", DbType="NVarChar(MAX)")] ref string uRL)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), fIRSTID, nAME, dIRECTOR, mOVIETIME, cREATEDAT, sYNOPSIS, gENEROS, uRL);
			fIRSTID = ((System.Nullable<long>)(result.GetParameterValue(0)));
			nAME = ((string)(result.GetParameterValue(1)));
			dIRECTOR = ((string)(result.GetParameterValue(2)));
			mOVIETIME = ((System.Nullable<int>)(result.GetParameterValue(3)));
			cREATEDAT = ((System.Nullable<System.DateTime>)(result.GetParameterValue(4)));
			sYNOPSIS = ((string)(result.GetParameterValue(5)));
			gENEROS = ((string)(result.GetParameterValue(6)));
			uRL = ((string)(result.GetParameterValue(7)));
			return ((ISingleResult<SP_PELICULA_INICIOResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="Movies_DB.SP_FILTRAR_GENERO")]
		public ISingleResult<SP_FILTRAR_GENEROResult> SP_FILTRAR_GENERO([global::System.Data.Linq.Mapping.ParameterAttribute(Name="IDGENERO", DbType="BigInt")] System.Nullable<long> iDGENERO)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), iDGENERO);
			return ((ISingleResult<SP_FILTRAR_GENEROResult>)(result.ReturnValue));
		}
	}
	
	public partial class SP_GENEROSResult
	{
		
		private long _IdMovieType;
		
		private string _Name;
		
		public SP_GENEROSResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdMovieType", DbType="BigInt NOT NULL")]
		public long IdMovieType
		{
			get
			{
				return this._IdMovieType;
			}
			set
			{
				if ((this._IdMovieType != value))
				{
					this._IdMovieType = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
	}
	
	public partial class SP_MOSTRAR_PELICULASResult
	{
		
		private long _IdMovie;
		
		private string _Name;
		
		private System.Nullable<decimal> _Rating;
		
		private string _Director;
		
		private int _MovieTime;
		
		private System.DateTime _InsertDate;
		
		private string _Synopsis;
		
		private string _Generos;
		
		private string _URL;
		
		public SP_MOSTRAR_PELICULASResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdMovie", DbType="BigInt NOT NULL")]
		public long IdMovie
		{
			get
			{
				return this._IdMovie;
			}
			set
			{
				if ((this._IdMovie != value))
				{
					this._IdMovie = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rating", DbType="Decimal(38,6)")]
		public System.Nullable<decimal> Rating
		{
			get
			{
				return this._Rating;
			}
			set
			{
				if ((this._Rating != value))
				{
					this._Rating = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Director", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Director
		{
			get
			{
				return this._Director;
			}
			set
			{
				if ((this._Director != value))
				{
					this._Director = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MovieTime", DbType="Int NOT NULL")]
		public int MovieTime
		{
			get
			{
				return this._MovieTime;
			}
			set
			{
				if ((this._MovieTime != value))
				{
					this._MovieTime = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InsertDate", DbType="DateTime NOT NULL")]
		public System.DateTime InsertDate
		{
			get
			{
				return this._InsertDate;
			}
			set
			{
				if ((this._InsertDate != value))
				{
					this._InsertDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Synopsis", DbType="NVarChar(MAX)")]
		public string Synopsis
		{
			get
			{
				return this._Synopsis;
			}
			set
			{
				if ((this._Synopsis != value))
				{
					this._Synopsis = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Generos", DbType="NVarChar(4000)")]
		public string Generos
		{
			get
			{
				return this._Generos;
			}
			set
			{
				if ((this._Generos != value))
				{
					this._Generos = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_URL", DbType="NVarChar(255)")]
		public string URL
		{
			get
			{
				return this._URL;
			}
			set
			{
				if ((this._URL != value))
				{
					this._URL = value;
				}
			}
		}
	}
	
	public partial class SP_MOSTRAR_COMENTARIOSResult
	{
		
		private long _IdComments;
		
		private string _Nickname;
		
		private long _FkIdMovie;
		
		private System.DateTime _InsertDate;
		
		private string _Comment;
		
		private System.Nullable<decimal> _CommentRating;
		
		private byte _Deleted;
		
		public SP_MOSTRAR_COMENTARIOSResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdComments", DbType="BigInt NOT NULL")]
		public long IdComments
		{
			get
			{
				return this._IdComments;
			}
			set
			{
				if ((this._IdComments != value))
				{
					this._IdComments = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nickname", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string Nickname
		{
			get
			{
				return this._Nickname;
			}
			set
			{
				if ((this._Nickname != value))
				{
					this._Nickname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FkIdMovie", DbType="BigInt NOT NULL")]
		public long FkIdMovie
		{
			get
			{
				return this._FkIdMovie;
			}
			set
			{
				if ((this._FkIdMovie != value))
				{
					this._FkIdMovie = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InsertDate", DbType="DateTime NOT NULL")]
		public System.DateTime InsertDate
		{
			get
			{
				return this._InsertDate;
			}
			set
			{
				if ((this._InsertDate != value))
				{
					this._InsertDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Comment", DbType="NVarChar(MAX)")]
		public string Comment
		{
			get
			{
				return this._Comment;
			}
			set
			{
				if ((this._Comment != value))
				{
					this._Comment = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CommentRating", DbType="Decimal(3,2)")]
		public System.Nullable<decimal> CommentRating
		{
			get
			{
				return this._CommentRating;
			}
			set
			{
				if ((this._CommentRating != value))
				{
					this._CommentRating = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Deleted", DbType="TinyInt NOT NULL")]
		public byte Deleted
		{
			get
			{
				return this._Deleted;
			}
			set
			{
				if ((this._Deleted != value))
				{
					this._Deleted = value;
				}
			}
		}
	}
	
	public partial class SP_PELICULA_INICIOResult
	{
		
		private long _IdComments;
		
		private string _Nickname;
		
		private long _FkIdMovie;
		
		private System.DateTime _InsertDate;
		
		private string _Comment;
		
		private byte _Deleted;
		
		private System.Nullable<decimal> _CommentRating;
		
		public SP_PELICULA_INICIOResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdComments", DbType="BigInt NOT NULL")]
		public long IdComments
		{
			get
			{
				return this._IdComments;
			}
			set
			{
				if ((this._IdComments != value))
				{
					this._IdComments = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nickname", DbType="NVarChar(30) NOT NULL", CanBeNull=false)]
		public string Nickname
		{
			get
			{
				return this._Nickname;
			}
			set
			{
				if ((this._Nickname != value))
				{
					this._Nickname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FkIdMovie", DbType="BigInt NOT NULL")]
		public long FkIdMovie
		{
			get
			{
				return this._FkIdMovie;
			}
			set
			{
				if ((this._FkIdMovie != value))
				{
					this._FkIdMovie = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_InsertDate", DbType="DateTime NOT NULL")]
		public System.DateTime InsertDate
		{
			get
			{
				return this._InsertDate;
			}
			set
			{
				if ((this._InsertDate != value))
				{
					this._InsertDate = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Comment", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Comment
		{
			get
			{
				return this._Comment;
			}
			set
			{
				if ((this._Comment != value))
				{
					this._Comment = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Deleted", DbType="TinyInt NOT NULL")]
		public byte Deleted
		{
			get
			{
				return this._Deleted;
			}
			set
			{
				if ((this._Deleted != value))
				{
					this._Deleted = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CommentRating", DbType="Decimal(3,2)")]
		public System.Nullable<decimal> CommentRating
		{
			get
			{
				return this._CommentRating;
			}
			set
			{
				if ((this._CommentRating != value))
				{
					this._CommentRating = value;
				}
			}
		}
	}
	
	public partial class SP_FILTRAR_GENEROResult
	{
		
		private long _IdMovie;
		
		private string _Name;
		
		private System.Nullable<decimal> _Rating;
		
		private string _Director;
		
		private int _MovieTime;
		
		private System.DateTime _CreatedAt;
		
		private string _Synopsis;
		
		private string _MovieTypes;
		
		private string _URL;
		
		public SP_FILTRAR_GENEROResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IdMovie", DbType="BigInt NOT NULL")]
		public long IdMovie
		{
			get
			{
				return this._IdMovie;
			}
			set
			{
				if ((this._IdMovie != value))
				{
					this._IdMovie = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this._Name = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Rating", DbType="Decimal(38,6)")]
		public System.Nullable<decimal> Rating
		{
			get
			{
				return this._Rating;
			}
			set
			{
				if ((this._Rating != value))
				{
					this._Rating = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Director", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Director
		{
			get
			{
				return this._Director;
			}
			set
			{
				if ((this._Director != value))
				{
					this._Director = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MovieTime", DbType="Int NOT NULL")]
		public int MovieTime
		{
			get
			{
				return this._MovieTime;
			}
			set
			{
				if ((this._MovieTime != value))
				{
					this._MovieTime = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedAt", DbType="Date NOT NULL")]
		public System.DateTime CreatedAt
		{
			get
			{
				return this._CreatedAt;
			}
			set
			{
				if ((this._CreatedAt != value))
				{
					this._CreatedAt = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Synopsis", DbType="NVarChar(MAX)")]
		public string Synopsis
		{
			get
			{
				return this._Synopsis;
			}
			set
			{
				if ((this._Synopsis != value))
				{
					this._Synopsis = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MovieTypes", DbType="NVarChar(4000)")]
		public string MovieTypes
		{
			get
			{
				return this._MovieTypes;
			}
			set
			{
				if ((this._MovieTypes != value))
				{
					this._MovieTypes = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_URL", DbType="NVarChar(255)")]
		public string URL
		{
			get
			{
				return this._URL;
			}
			set
			{
				if ((this._URL != value))
				{
					this._URL = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
