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
	/// <summary>Footer</summary>
	[PublishedContentModel("footer")]
	public partial class Footer : PublishedContentModel, ITopNavigationControl
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "footer";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Footer(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Footer, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Copyright Text
		///</summary>
		[ImplementPropertyType("copyrightText")]
		public string CopyrightText
		{
			get { return this.GetPropertyValue<string>("copyrightText"); }
		}

		///<summary>
		/// Footer Content
		///</summary>
		[ImplementPropertyType("footerContent")]
		public IHtmlString FooterContent
		{
			get { return this.GetPropertyValue<IHtmlString>("footerContent"); }
		}

		///<summary>
		/// Footer Logo
		///</summary>
		[ImplementPropertyType("footerLogo")]
		public Umbraco.Web.Models.ImageCropDataSet FooterLogo
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("footerLogo"); }
		}

		///<summary>
		/// Links
		///</summary>
		[ImplementPropertyType("links")]
		public IEnumerable<IPublishedContent> Links
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("links"); }
		}

		///<summary>
		/// Main Logo
		///</summary>
		[ImplementPropertyType("mainLogo")]
		public Umbraco.Web.Models.ImageCropDataSet MainLogo
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("mainLogo"); }
		}

		///<summary>
		/// Hide from navigation: When checked, page will be hidden from navigation but still accessible by URL.
		///</summary>
		[ImplementPropertyType("hideFromNavigation")]
		public bool HideFromNavigation
		{
			get { return CustomerPortalCMS.GeneratedModels.TopNavigationControl.GetHideFromNavigation(this); }
		}
	}
}