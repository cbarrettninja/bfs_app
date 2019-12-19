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
	/// <summary>Leadership Users List</summary>
	[PublishedContentModel("leadershipUsersList")]
	public partial class LeadershipUsersList : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "leadershipUsersList";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public LeadershipUsersList(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<LeadershipUsersList, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Company User About: Company User About
		///</summary>
		[ImplementPropertyType("companyUserAbout")]
		public IHtmlString CompanyUserAbout
		{
			get { return this.GetPropertyValue<IHtmlString>("companyUserAbout"); }
		}

		///<summary>
		/// Company User Name: Company User Name
		///</summary>
		[ImplementPropertyType("companyUserName")]
		public string CompanyUserName
		{
			get { return this.GetPropertyValue<string>("companyUserName"); }
		}

		///<summary>
		/// Company User Picture: Dimesions:- 340x425
		///</summary>
		[ImplementPropertyType("companyUserPicture")]
		public Umbraco.Web.Models.ImageCropDataSet CompanyUserPicture
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("companyUserPicture"); }
		}

		///<summary>
		/// Company User Position: Company User Position
		///</summary>
		[ImplementPropertyType("companyUserPosition")]
		public string CompanyUserPosition
		{
			get { return this.GetPropertyValue<string>("companyUserPosition"); }
		}
	}
}