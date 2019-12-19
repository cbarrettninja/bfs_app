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
	// Mixin content Type 1297 with alias "careersJobsCol12Controls"
	/// <summary>Careers Jobs Col-12 Controls</summary>
	public partial interface ICareersJobsCol12Controls : IPublishedContent
	{
		/// <summary>Career 1 Description</summary>
		IHtmlString Career1Description { get; }

		/// <summary>Career 1 Image</summary>
		IPublishedContent Career1Image { get; }

		/// <summary>Career 1 Link</summary>
		Umbraco.Web.Models.RelatedLinks Career1Link { get; }

		/// <summary>Career 1 Second Image</summary>
		IPublishedContent Career1SecondImage { get; }

		/// <summary>Career 1 Title</summary>
		string Career1Title { get; }

		/// <summary>Career 2 Description</summary>
		IHtmlString Career2Description { get; }

		/// <summary>Career 2 Image</summary>
		IPublishedContent Career2Image { get; }

		/// <summary>Career 2 Link</summary>
		Umbraco.Web.Models.RelatedLinks Career2Link { get; }

		/// <summary>Career 2 Second Image</summary>
		IPublishedContent Career2SecondImage { get; }

		/// <summary>Career 2 Title</summary>
		string Career2Title { get; }

		/// <summary>Featured Careers Heading</summary>
		string FeaturedCareersHeading { get; }
	}

	/// <summary>Careers Jobs Col-12 Controls</summary>
	[PublishedContentModel("careersJobsCol12Controls")]
	public partial class CareersJobsCol12Controls : PublishedContentModel, ICareersJobsCol12Controls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "careersJobsCol12Controls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public CareersJobsCol12Controls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<CareersJobsCol12Controls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Career 1 Description: Enter a description for this career
		///</summary>
		[ImplementPropertyType("career1Description")]
		public IHtmlString Career1Description
		{
			get { return GetCareer1Description(this); }
		}

		/// <summary>Static getter for Career 1 Description</summary>
		public static IHtmlString GetCareer1Description(ICareersJobsCol12Controls that) { return that.GetPropertyValue<IHtmlString>("career1Description"); }

		///<summary>
		/// Career 1 Image: Choose an image for this featured career
		///</summary>
		[ImplementPropertyType("career1Image")]
		public IPublishedContent Career1Image
		{
			get { return GetCareer1Image(this); }
		}

		/// <summary>Static getter for Career 1 Image</summary>
		public static IPublishedContent GetCareer1Image(ICareersJobsCol12Controls that) { return that.GetPropertyValue<IPublishedContent>("career1Image"); }

		///<summary>
		/// Career 1 Link: Choose a Link for this career (the caption text will be used for the button link)
		///</summary>
		[ImplementPropertyType("career1Link")]
		public Umbraco.Web.Models.RelatedLinks Career1Link
		{
			get { return GetCareer1Link(this); }
		}

		/// <summary>Static getter for Career 1 Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetCareer1Link(ICareersJobsCol12Controls that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("career1Link"); }

		///<summary>
		/// Career 1 Second Image: Choose a second image to appear for this featured career
		///</summary>
		[ImplementPropertyType("career1SecondImage")]
		public IPublishedContent Career1SecondImage
		{
			get { return GetCareer1SecondImage(this); }
		}

		/// <summary>Static getter for Career 1 Second Image</summary>
		public static IPublishedContent GetCareer1SecondImage(ICareersJobsCol12Controls that) { return that.GetPropertyValue<IPublishedContent>("career1SecondImage"); }

		///<summary>
		/// Career 1 Title: Enter a title for this career
		///</summary>
		[ImplementPropertyType("career1Title")]
		public string Career1Title
		{
			get { return GetCareer1Title(this); }
		}

		/// <summary>Static getter for Career 1 Title</summary>
		public static string GetCareer1Title(ICareersJobsCol12Controls that) { return that.GetPropertyValue<string>("career1Title"); }

		///<summary>
		/// Career 2 Description: Enter a description for this career
		///</summary>
		[ImplementPropertyType("career2Description")]
		public IHtmlString Career2Description
		{
			get { return GetCareer2Description(this); }
		}

		/// <summary>Static getter for Career 2 Description</summary>
		public static IHtmlString GetCareer2Description(ICareersJobsCol12Controls that) { return that.GetPropertyValue<IHtmlString>("career2Description"); }

		///<summary>
		/// Career 2 Image: Choose an image for this featured career
		///</summary>
		[ImplementPropertyType("career2Image")]
		public IPublishedContent Career2Image
		{
			get { return GetCareer2Image(this); }
		}

		/// <summary>Static getter for Career 2 Image</summary>
		public static IPublishedContent GetCareer2Image(ICareersJobsCol12Controls that) { return that.GetPropertyValue<IPublishedContent>("career2Image"); }

		///<summary>
		/// Career 2 Link: Choose a Link for this career (the caption text will be used for the button link)
		///</summary>
		[ImplementPropertyType("career2Link")]
		public Umbraco.Web.Models.RelatedLinks Career2Link
		{
			get { return GetCareer2Link(this); }
		}

		/// <summary>Static getter for Career 2 Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetCareer2Link(ICareersJobsCol12Controls that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("career2Link"); }

		///<summary>
		/// Career 2 Second Image: Choose a second image to appear for this featured career
		///</summary>
		[ImplementPropertyType("career2SecondImage")]
		public IPublishedContent Career2SecondImage
		{
			get { return GetCareer2SecondImage(this); }
		}

		/// <summary>Static getter for Career 2 Second Image</summary>
		public static IPublishedContent GetCareer2SecondImage(ICareersJobsCol12Controls that) { return that.GetPropertyValue<IPublishedContent>("career2SecondImage"); }

		///<summary>
		/// Career 2 Title: Enter a title for this career
		///</summary>
		[ImplementPropertyType("career2Title")]
		public string Career2Title
		{
			get { return GetCareer2Title(this); }
		}

		/// <summary>Static getter for Career 2 Title</summary>
		public static string GetCareer2Title(ICareersJobsCol12Controls that) { return that.GetPropertyValue<string>("career2Title"); }

		///<summary>
		/// Featured Careers Heading: Enter in the Featured Careers Heading
		///</summary>
		[ImplementPropertyType("featuredCareersHeading")]
		public string FeaturedCareersHeading
		{
			get { return GetFeaturedCareersHeading(this); }
		}

		/// <summary>Static getter for Featured Careers Heading</summary>
		public static string GetFeaturedCareersHeading(ICareersJobsCol12Controls that) { return that.GetPropertyValue<string>("featuredCareersHeading"); }
	}
}