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
	/// <summary>Community Page</summary>
	[PublishedContentModel("communityPage")]
	public partial class CommunityPage : PublishedContentModel, IPageHeaderControl, ITopNavigationControl
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "communityPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public CommunityPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<CommunityPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Community List
		///</summary>
		[ImplementPropertyType("communityList")]
		public IEnumerable<IPublishedContent> CommunityList
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("communityList"); }
		}

		///<summary>
		/// Header Mobile Background Image
		///</summary>
		[ImplementPropertyType("headerMobileBackgroundImage")]
		public Umbraco.Web.Models.ImageCropDataSet HeaderMobileBackgroundImage
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("headerMobileBackgroundImage"); }
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("content")]
		public IHtmlString Content
		{
			get { return CustomerPortalCMS.GeneratedModels.PageHeaderControl.GetContent(this); }
		}

		///<summary>
		/// Header Background Image
		///</summary>
		[ImplementPropertyType("headerBackgroundImage")]
		public Umbraco.Web.Models.ImageCropDataSet HeaderBackgroundImage
		{
			get { return CustomerPortalCMS.GeneratedModels.PageHeaderControl.GetHeaderBackgroundImage(this); }
		}

		///<summary>
		/// Page Title
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return CustomerPortalCMS.GeneratedModels.PageHeaderControl.GetPageTitle(this); }
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
