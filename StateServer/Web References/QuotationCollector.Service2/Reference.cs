﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.573
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 1.1.4322.573.
// 
namespace iExchange.StateServer.QuotationCollector
{
	using System.Diagnostics;
	using System.Xml.Serialization;
	using System;
	using System.Web.Services.Protocols;
	using System.ComponentModel;
	using System.Web.Services;

	using iExchange.Common;

	/// <remarks/>
	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.ComponentModel.DesignerCategoryAttribute("code")]
	[System.Web.Services.WebServiceBindingAttribute(Name = "Service2Soap", Namespace = "http://www.iExchange.com")]
	public class Service2 : System.Web.Services.Protocols.SoapHttpClientProtocol
	{

		/// <remarks/>
		public Service2()
		{
			string urlSetting = System.Configuration.ConfigurationSettings.AppSettings["iExchange.StateServer.QuotationCollector.Service2"];
			if ((urlSetting != null))
			{
				this.Url = string.Concat(urlSetting, "");
			}
			else
			{
				this.Url = "http://localhost/iExchange/QuotationCollector/Service2.asmx";
			}
		}

		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.iExchange.com/HelloWorld", RequestNamespace = "http://www.iExchange.com", ResponseNamespace = "http://www.iExchange.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public string HelloWorld()
		{
			object[] results = this.Invoke("HelloWorld", new object[0]);
			return ((string)(results[0]));
		}

		/// <remarks/>
		public System.IAsyncResult BeginHelloWorld(System.AsyncCallback callback, object asyncState)
		{
			return this.BeginInvoke("HelloWorld", new object[0], callback, asyncState);
		}

		/// <remarks/>
		public string EndHelloWorld(System.IAsyncResult asyncResult)
		{
			object[] results = this.EndInvoke(asyncResult);
			return ((string)(results[0]));
		}

		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.iExchange.com/UnRegister", RequestNamespace = "http://www.iExchange.com", ResponseNamespace = "http://www.iExchange.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void UnRegister(Token token)
		{
			this.Invoke("UnRegister", new object[] {
                        token});
		}

		/// <remarks/>
		public System.IAsyncResult BeginUnRegister(Token token, System.AsyncCallback callback, object asyncState)
		{
			return this.BeginInvoke("UnRegister", new object[] {
                        token}, callback, asyncState);
		}

		/// <remarks/>
		public void EndUnRegister(System.IAsyncResult asyncResult)
		{
			this.EndInvoke(asyncResult);
		}

		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.iExchange.com/AddCommand", RequestNamespace = "http://www.iExchange.com", ResponseNamespace = "http://www.iExchange.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void AddCommand(Token token, Command command)
		{
			this.Invoke("AddCommand", new object[] {
                        token,
                        command});
		}

		/// <remarks/>
		public System.IAsyncResult BeginAddCommand(Token token, Command command, System.AsyncCallback callback, object asyncState)
		{
			return this.BeginInvoke("AddCommand", new object[] {
                        token,
                        command}, callback, asyncState);
		}

		/// <remarks/>
		public void EndAddCommand(System.IAsyncResult asyncResult)
		{
			this.EndInvoke(asyncResult);
		}

		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.iExchange.com/Login", RequestNamespace = "http://www.iExchange.com", ResponseNamespace = "http://www.iExchange.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void Login(Token token)
		{
			this.Invoke("Login", new object[] {
                        token});
		}

		/// <remarks/>
		public System.IAsyncResult BeginLogin(Token token, System.AsyncCallback callback, object asyncState)
		{
			return this.BeginInvoke("Login", new object[] {
                        token}, callback, asyncState);
		}

		/// <remarks/>
		public void EndLogin(System.IAsyncResult asyncResult)
		{
			this.EndInvoke(asyncResult);
		}

		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.iExchange.com/Logout", RequestNamespace = "http://www.iExchange.com", ResponseNamespace = "http://www.iExchange.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public void Logout(Token token)
		{
			this.Invoke("Logout", new object[] {
                        token});
		}

		/// <remarks/>
		public System.IAsyncResult BeginLogout(Token token, System.AsyncCallback callback, object asyncState)
		{
			return this.BeginInvoke("Logout", new object[] {
                        token}, callback, asyncState);
		}

		/// <remarks/>
		public void EndLogout(System.IAsyncResult asyncResult)
		{
			this.EndInvoke(asyncResult);
		}

		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.iExchange.com/SetActiveSource", RequestNamespace = "http://www.iExchange.com", ResponseNamespace = "http://www.iExchange.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool SetActiveSource(string source)
		{
			object[] results = this.Invoke("SetActiveSource", new object[] {
                        source});
			return ((bool)(results[0]));
		}

		/// <remarks/>
		public System.IAsyncResult BeginSetActiveSource(string source, System.AsyncCallback callback, object asyncState)
		{
			return this.BeginInvoke("SetActiveSource", new object[] {
                        source}, callback, asyncState);
		}

		/// <remarks/>
		public bool EndSetActiveSource(System.IAsyncResult asyncResult)
		{
			object[] results = this.EndInvoke(asyncResult);
			return ((bool)(results[0]));
		}

		/// <remarks/>
		[System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.iExchange.com/SetActiveSourceInstrument", RequestNamespace = "http://www.iExchange.com", ResponseNamespace = "http://www.iExchange.com", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
		public bool SetActiveSourceInstrument(System.Xml.XmlNode sourceInstrumentNodes)
		{
			object[] results = this.Invoke("SetActiveSourceInstrument", new object[] {
                        sourceInstrumentNodes});
			return ((bool)(results[0]));
		}

		/// <remarks/>
		public System.IAsyncResult BeginSetActiveSourceInstrument(System.Xml.XmlNode sourceInstrumentNodes, System.AsyncCallback callback, object asyncState)
		{
			return this.BeginInvoke("SetActiveSourceInstrument", new object[] {
                        sourceInstrumentNodes}, callback, asyncState);
		}

		/// <remarks/>
		public bool EndSetActiveSourceInstrument(System.IAsyncResult asyncResult)
		{
			object[] results = this.EndInvoke(asyncResult);
			return ((bool)(results[0]));
		}
	}
}
