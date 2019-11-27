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
	// Mixin content Type 13085 with alias "horizontalBrandsControl1"
	/// <summary>Horizontal Brands Control-WithCrop</summary>
	public partial interface IHorizontalBrandsControl1 : IPublishedContent
	{
		/// <summary>Brand Image 1</summary>
		IPublishedContent BrandImage1 { get; }

		/// <summary>Brand Image 2</summary>
		IPublishedContent BrandImage2 { get; }

		/// <summary>Brand Image 3</summary>
		IPublishedContent BrandImage3 { get; }

		/// <summary>Brand Image 4</summary>
		IPublishedContent BrandImage4 { get; }

		/// <summary>Brand Image 5</summary>
		IPublishedContent BrandImage5 { get; }

		/// <summary>Brand Image 6</summary>
		IPublishedContent BrandImage6 { get; }

		/// <summary>Brand Link 1</summary>
		Umbraco.Web.Models.RelatedLinks BrandLink1 { get; }

		/// <summary>Brand Link 2</summary>
		Umbraco.Web.Models.RelatedLinks BrandLink2 { get; }

		/// <summary>Brand Link 3</summary>
		Umbraco.Web.Models.RelatedLinks BrandLink3 { get; }

		/// <summary>Brand Link 4</summary>
		Umbraco.Web.Models.RelatedLinks BrandLink4 { get; }

		/// <summary>Brand Link 5</summary>
		Umbraco.Web.Models.RelatedLinks BrandLink5 { get; }

		/// <summary>Brand Link 6</summary>
		Umbraco.Web.Models.RelatedLinks BrandLink6 { get; }
	}

	/// <summary>Horizontal Brands Control-WithCrop</summary>
	[PublishedContentModel("horizontalBrandsControl1")]
	public partial class HorizontalBrandsControl1 : PublishedContentModel, IHorizontalBrandsControl1
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "horizontalBrandsControl1";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public HorizontalBrandsControl1(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<HorizontalBrandsControl1, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Brand Image 1: Choose a brand logo
		///</summary>
		[ImplementPropertyType("brandImage1")]
		public IPublishedContent BrandImage1
		{
			get { return GetBrandImage1(this); }
		}

		/// <summary>Static getter for Brand Image 1</summary>
		public static IPublishedContent GetBrandImage1(IHorizontalBrandsControl1 that) { return that.GetPropertyValue<IPublishedContent>("brandImage1"); }

		///<summary>
		/// Brand Image 2: Choose a brand logo
		///</summary>
		[ImplementPropertyType("brandImage2")]
		public IPublishedContent BrandImage2
		{
			get { return GetBrandImage2(this); }
		}

		/// <summary>Static getter for Brand Image 2</summary>
		public static IPublishedContent GetBrandImage2(IHorizontalBrandsControl1 that) { return that.GetPropertyValue<IPublishedContent>("brandImage2"); }

		///<summary>
		/// Brand Image 3: Choose a brand logo
		///</summary>
		[ImplementPropertyType("brandImage3")]
		public IPublishedContent BrandImage3
		{
			get { return GetBrandImage3(this); }
		}

		/// <summary>Static getter for Brand Image 3</summary>
		public static IPublishedContent GetBrandImage3(IHorizontalBrandsControl1 that) { return that.GetPropertyValue<IPublishedContent>("brandImage3"); }

		///<summary>
		/// Brand Image 4: Choose a brand logo
		///</summary>
		[ImplementPropertyType("brandImage4")]
		public IPublishedContent BrandImage4
		{
			get { return GetBrandImage4(this); }
		}

		/// <summary>Static getter for Brand Image 4</summary>
		public static IPublishedContent GetBrandImage4(IHorizontalBrandsControl1 that) { return that.GetPropertyValue<IPublishedContent>("brandImage4"); }

		///<summary>
		/// Brand Image 5: Choose a brand logo
		///</summary>
		[ImplementPropertyType("brandImage5")]
		public IPublishedContent BrandImage5
		{
			get { return GetBrandImage5(this); }
		}

		/// <summary>Static getter for Brand Image 5</summary>
		public static IPublishedContent GetBrandImage5(IHorizontalBrandsControl1 that) { return that.GetPropertyValue<IPublishedContent>("brandImage5"); }

		///<summary>
		/// Brand Image 6: Choose a brand logo
		///</summary>
		[ImplementPropertyType("brandImage6")]
		public IPublishedContent BrandImage6
		{
			get { return GetBrandImage6(this); }
		}

		/// <summary>Static getter for Brand Image 6</summary>
		public static IPublishedContent GetBrandImage6(IHorizontalBrandsControl1 that) { return that.GetPropertyValue<IPublishedContent>("brandImage6"); }

		///<summary>
		/// Brand Link 1: Choose a Link for this image (optional)
		///</summary>
		[ImplementPropertyType("brandLink1")]
		public Umbraco.Web.Models.RelatedLinks BrandLink1
		{
			get { return GetBrandLink1(this); }
		}

		/// <summary>Static getter for Brand Link 1</summary>
		public static Umbraco.Web.Models.RelatedLinks GetBrandLink1(IHorizontalBrandsControl1 that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("brandLink1"); }

		///<summary>
		/// Brand Link 2: Choose a Link for this image (optional)
		///</summary>
		[ImplementPropertyType("brandLink2")]
		public Umbraco.Web.Models.RelatedLinks BrandLink2
		{
			get { return GetBrandLink2(this); }
		}

		/// <summary>Static getter for Brand Link 2</summary>
		public static Umbraco.Web.Models.RelatedLinks GetBrandLink2(IHorizontalBrandsControl1 that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("brandLink2"); }

		///<summary>
		/// Brand Link 3: Choose a Link for this image (optional)
		///</summary>
		[ImplementPropertyType("brandLink3")]
		public Umbraco.Web.Models.RelatedLinks BrandLink3
		{
			get { return GetBrandLink3(this); }
		}

		/// <summary>Static getter for Brand Link 3</summary>
		public static Umbraco.Web.Models.RelatedLinks GetBrandLink3(IHorizontalBrandsControl1 that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("brandLink3"); }

		///<summary>
		/// Brand Link 4: Choose a Link for this image (optional)
		///</summary>
		[ImplementPropertyType("brandLink4")]
		public Umbraco.Web.Models.RelatedLinks BrandLink4
		{
			get { return GetBrandLink4(this); }
		}

		/// <summary>Static getter for Brand Link 4</summary>
		public static Umbraco.Web.Models.RelatedLinks GetBrandLink4(IHorizontalBrandsControl1 that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("brandLink4"); }

		///<summary>
		/// Brand Link 5: Choose a Link for this image (optional)
		///</summary>
		[ImplementPropertyType("brandLink5")]
		public Umbraco.Web.Models.RelatedLinks BrandLink5
		{
			get { return GetBrandLink5(this); }
		}

		/// <summary>Static getter for Brand Link 5</summary>
		public static Umbraco.Web.Models.RelatedLinks GetBrandLink5(IHorizontalBrandsControl1 that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("brandLink5"); }

		///<summary>
		/// Brand Link 6: Choose a Link for this image (optional)
		///</summary>
		[ImplementPropertyType("brandLink6")]
		public Umbraco.Web.Models.RelatedLinks BrandLink6
		{
			get { return GetBrandLink6(this); }
		}

		/// <summary>Static getter for Brand Link 6</summary>
		public static Umbraco.Web.Models.RelatedLinks GetBrandLink6(IHorizontalBrandsControl1 that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("brandLink6"); }
	}
}
