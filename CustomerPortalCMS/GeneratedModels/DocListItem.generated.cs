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
	/// <summary>Doc List Item</summary>
	[PublishedContentModel("docListItem")]
	public partial class DocListItem : PublishedContentModel, ITopNavigationControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "docListItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public DocListItem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<DocListItem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Document Name
		///</summary>
		[ImplementPropertyType("documentName")]
		public string DocumentName
		{
			get { return this.GetPropertyValue<string>("documentName"); }
		}

		///<summary>
		/// File
		///</summary>
		[ImplementPropertyType("file")]
		public string File
		{
			get { return this.GetPropertyValue<string>("file"); }
		}

		///<summary>
		/// ReleaseDate
		///</summary>
		[ImplementPropertyType("releaseDate")]
		public DateTime ReleaseDate
		{
			get { return this.GetPropertyValue<DateTime>("releaseDate"); }
		}

		///<summary>
		/// Hide If No Customer Selected?  (CP Sales Node Only!): (This is being replaced with Hide from navigation) Click this if you do not want this page to appear in the top nav
		///</summary>
		[ImplementPropertyType("excludeFromTopNavigation")]
		public bool ExcludeFromTopNavigation
		{
			get { return CustomerPortalCMS.GeneratedModels.TopNavigationControls.GetExcludeFromTopNavigation(this); }
		}

		///<summary>
		/// Hide from navigation: When checked, page will be hidden from navigation but still accessible by URL.
		///</summary>
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide
		{
			get { return CustomerPortalCMS.GeneratedModels.TopNavigationControls.GetUmbracoNaviHide(this); }
		}
	}
}
