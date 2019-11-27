//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace CustomerPortalCMS.GeneratedModels
{
	// Mixin content Type 1220 with alias "landingPageControls"
	/// <summary>Landing Page Controls</summary>
	public partial interface ILandingPageControls : IPublishedContent
	{
		/// <summary>Greeting</summary>
		string Greeting { get; }

		/// <summary>pageContent</summary>
		IHtmlString PageContent { get; }
	}

	/// <summary>Landing Page Controls</summary>
	[PublishedContentModel("landingPageControls")]
	public partial class LandingPageControls : PublishedContentModel, ILandingPageControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "landingPageControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public LandingPageControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<LandingPageControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Greeting: One line greeting
		///</summary>
		[ImplementPropertyType("greeting")]
		public string Greeting
		{
			get { return GetGreeting(this); }
		}

		/// <summary>Static getter for Greeting</summary>
		public static string GetGreeting(ILandingPageControls that) { return that.GetPropertyValue<string>("greeting"); }

		///<summary>
		/// pageContent
		///</summary>
		[ImplementPropertyType("pageContent")]
		public IHtmlString PageContent
		{
			get { return GetPageContent(this); }
		}

		/// <summary>Static getter for pageContent</summary>
		public static IHtmlString GetPageContent(ILandingPageControls that) { return that.GetPropertyValue<IHtmlString>("pageContent"); }
	}
}
