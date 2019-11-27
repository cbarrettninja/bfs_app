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
	/// <summary>Distribution Type</summary>
	[PublishedContentModel("distributionType")]
	public partial class DistributionType : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "distributionType";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public DistributionType(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<DistributionType, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Active?: Unchecked if this distribution type is no longer active.
		///</summary>
		[ImplementPropertyType("active")]
		public bool Active
		{
			get { return this.GetPropertyValue<bool>("active"); }
		}

		///<summary>
		/// Location List Item Property Alias: This is the alias for the corresponding Multinode Tree Picker property of the Location List Items
		///</summary>
		[ImplementPropertyType("locationListItemPropertyAlias")]
		public string LocationListItemPropertyAlias
		{
			get { return this.GetPropertyValue<string>("locationListItemPropertyAlias"); }
		}

		///<summary>
		/// Show In Location Search Filters: If checked, this property will be listed in the location search filters
		///</summary>
		[ImplementPropertyType("showInLocationSearchFilters")]
		public bool ShowInLocationSearchFilters
		{
			get { return this.GetPropertyValue<bool>("showInLocationSearchFilters"); }
		}

		///<summary>
		/// Show On Distribution Page: If checked, this distribution category will show up on the main Distributions page linked to the home page
		///</summary>
		[ImplementPropertyType("showOnDistributionPage")]
		public bool ShowOnDistributionPage
		{
			get { return this.GetPropertyValue<bool>("showOnDistributionPage"); }
		}

		///<summary>
		/// Show On Location Details Pages: If checked, this category will show up on location detail pages
		///</summary>
		[ImplementPropertyType("showOnLocationDetailsPages")]
		public bool ShowOnLocationDetailsPages
		{
			get { return this.GetPropertyValue<bool>("showOnLocationDetailsPages"); }
		}

		///<summary>
		/// Distribution Image
		///</summary>
		[ImplementPropertyType("typeImage")]
		public IPublishedContent TypeImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("typeImage"); }
		}

		///<summary>
		/// Distribution Name
		///</summary>
		[ImplementPropertyType("typeName")]
		public string TypeName
		{
			get { return this.GetPropertyValue<string>("typeName"); }
		}
	}
}
