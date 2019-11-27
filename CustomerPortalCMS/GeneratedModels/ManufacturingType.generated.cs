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
	/// <summary>Manufacturing Type</summary>
	[PublishedContentModel("manufacturingType")]
	public partial class ManufacturingType : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "manufacturingType";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ManufacturingType(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ManufacturingType, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Active?
		///</summary>
		[ImplementPropertyType("active")]
		public bool Active
		{
			get { return this.GetPropertyValue<bool>("active"); }
		}

		///<summary>
		/// Manufacturing Image
		///</summary>
		[ImplementPropertyType("typeImage")]
		public IPublishedContent TypeImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("typeImage"); }
		}

		///<summary>
		/// Manufacturing Name
		///</summary>
		[ImplementPropertyType("typeName")]
		public string TypeName
		{
			get { return this.GetPropertyValue<string>("typeName"); }
		}
	}
}
