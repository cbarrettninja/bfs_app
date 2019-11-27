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
	// Mixin content Type 1272 with alias "homeFeaturedControls"
	/// <summary>Home Featured Controls</summary>
	public partial interface IHomeFeaturedControls : IPublishedContent
	{
		/// <summary>Feature 1 Button Link</summary>
		Umbraco.Web.Models.RelatedLinks Feature1ButtonLink { get; }

		/// <summary>Feature 1 Direct Video Link</summary>
		Umbraco.Web.Models.RelatedLinks Feature1DirectVideoLink { get; }

		/// <summary>Feature 1 Label</summary>
		string Feature1Label { get; }

		/// <summary>Feature 1 Thumbnail</summary>
		IPublishedContent Feature1Thumbnail { get; }

		/// <summary>Feature 1 Video Link</summary>
		Umbraco.Web.Models.RelatedLinks Feature1VideoLink { get; }

		/// <summary>Feature 2 Button Link</summary>
		Umbraco.Web.Models.RelatedLinks Feature2ButtonLink { get; }

		/// <summary>Feature 2 Direct Video Link</summary>
		Umbraco.Web.Models.RelatedLinks Feature2DirectVideoLink { get; }

		/// <summary>Feature 2 Label</summary>
		string Feature2Label { get; }

		/// <summary>Feature 2 Thumbnail</summary>
		IPublishedContent Feature2Thumbnail { get; }

		/// <summary>Feature 2 Video Link</summary>
		Umbraco.Web.Models.RelatedLinks Feature2VideoLink { get; }

		/// <summary>Feature 3 Button Link</summary>
		Umbraco.Web.Models.RelatedLinks Feature3ButtonLink { get; }

		/// <summary>Feature 3 Direct Video Link</summary>
		Umbraco.Web.Models.RelatedLinks Feature3DirectVideoLink { get; }

		/// <summary>Feature 3 Label</summary>
		string Feature3Label { get; }

		/// <summary>Feature 3 Thumbnail</summary>
		IPublishedContent Feature3Thumbnail { get; }

		/// <summary>Feature 3 Video Link</summary>
		Umbraco.Web.Models.RelatedLinks Feature3VideoLink { get; }

		/// <summary>Feature 4 Button Link</summary>
		Umbraco.Web.Models.RelatedLinks Feature4ButtonLink { get; }

		/// <summary>Feature 4 Direct Video Link</summary>
		Umbraco.Web.Models.RelatedLinks Feature4DirectVideoLink { get; }

		/// <summary>Feature 4 Label</summary>
		string Feature4Label { get; }

		/// <summary>Feature 4 Thumbnail</summary>
		IPublishedContent Feature4Thumbnail { get; }

		/// <summary>Feature 4 Video Link</summary>
		Umbraco.Web.Models.RelatedLinks Feature4VideoLink { get; }
	}

	/// <summary>Home Featured Controls</summary>
	[PublishedContentModel("homeFeaturedControls")]
	public partial class HomeFeaturedControls : PublishedContentModel, IHomeFeaturedControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "homeFeaturedControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public HomeFeaturedControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<HomeFeaturedControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Feature 1 Button Link: Enter the link for the "Learn More" button if it should appear
		///</summary>
		[ImplementPropertyType("feature1ButtonLink")]
		public Umbraco.Web.Models.RelatedLinks Feature1ButtonLink
		{
			get { return GetFeature1ButtonLink(this); }
		}

		/// <summary>Static getter for Feature 1 Button Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetFeature1ButtonLink(IHomeFeaturedControls that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("feature1ButtonLink"); }

		///<summary>
		/// Feature 1 Direct Video Link: Choose the video to play in the popup
		///</summary>
		[ImplementPropertyType("feature1DirectVideoLink")]
		public Umbraco.Web.Models.RelatedLinks Feature1DirectVideoLink
		{
			get { return GetFeature1DirectVideoLink(this); }
		}

		/// <summary>Static getter for Feature 1 Direct Video Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetFeature1DirectVideoLink(IHomeFeaturedControls that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("feature1DirectVideoLink"); }

		///<summary>
		/// Feature 1 Label: Enter the text for feature 1.
		///</summary>
		[ImplementPropertyType("feature1Label")]
		public string Feature1Label
		{
			get { return GetFeature1Label(this); }
		}

		/// <summary>Static getter for Feature 1 Label</summary>
		public static string GetFeature1Label(IHomeFeaturedControls that) { return that.GetPropertyValue<string>("feature1Label"); }

		///<summary>
		/// Feature 1 Thumbnail: Choose the thumbnail image for feature 1
		///</summary>
		[ImplementPropertyType("feature1Thumbnail")]
		public IPublishedContent Feature1Thumbnail
		{
			get { return GetFeature1Thumbnail(this); }
		}

		/// <summary>Static getter for Feature 1 Thumbnail</summary>
		public static IPublishedContent GetFeature1Thumbnail(IHomeFeaturedControls that) { return that.GetPropertyValue<IPublishedContent>("feature1Thumbnail"); }

		///<summary>
		/// Feature 1 Video Link: If this should link to a video, enter the link here.
		///</summary>
		[ImplementPropertyType("feature1VideoLink")]
		public Umbraco.Web.Models.RelatedLinks Feature1VideoLink
		{
			get { return GetFeature1VideoLink(this); }
		}

		/// <summary>Static getter for Feature 1 Video Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetFeature1VideoLink(IHomeFeaturedControls that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("feature1VideoLink"); }

		///<summary>
		/// Feature 2 Button Link: Enter the link for the "Learn More" button if it should appear.
		///</summary>
		[ImplementPropertyType("feature2ButtonLink")]
		public Umbraco.Web.Models.RelatedLinks Feature2ButtonLink
		{
			get { return GetFeature2ButtonLink(this); }
		}

		/// <summary>Static getter for Feature 2 Button Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetFeature2ButtonLink(IHomeFeaturedControls that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("feature2ButtonLink"); }

		///<summary>
		/// Feature 2 Direct Video Link: Choose the video to play in the popup
		///</summary>
		[ImplementPropertyType("feature2DirectVideoLink")]
		public Umbraco.Web.Models.RelatedLinks Feature2DirectVideoLink
		{
			get { return GetFeature2DirectVideoLink(this); }
		}

		/// <summary>Static getter for Feature 2 Direct Video Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetFeature2DirectVideoLink(IHomeFeaturedControls that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("feature2DirectVideoLink"); }

		///<summary>
		/// Feature 2 Label: Enter the text for feature 2
		///</summary>
		[ImplementPropertyType("feature2Label")]
		public string Feature2Label
		{
			get { return GetFeature2Label(this); }
		}

		/// <summary>Static getter for Feature 2 Label</summary>
		public static string GetFeature2Label(IHomeFeaturedControls that) { return that.GetPropertyValue<string>("feature2Label"); }

		///<summary>
		/// Feature 2 Thumbnail: Choose the thumbnail picture for feature 2.
		///</summary>
		[ImplementPropertyType("feature2Thumbnail")]
		public IPublishedContent Feature2Thumbnail
		{
			get { return GetFeature2Thumbnail(this); }
		}

		/// <summary>Static getter for Feature 2 Thumbnail</summary>
		public static IPublishedContent GetFeature2Thumbnail(IHomeFeaturedControls that) { return that.GetPropertyValue<IPublishedContent>("feature2Thumbnail"); }

		///<summary>
		/// Feature 2 Video Link: If this should link to a video, enter the link here.
		///</summary>
		[ImplementPropertyType("feature2VideoLink")]
		public Umbraco.Web.Models.RelatedLinks Feature2VideoLink
		{
			get { return GetFeature2VideoLink(this); }
		}

		/// <summary>Static getter for Feature 2 Video Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetFeature2VideoLink(IHomeFeaturedControls that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("feature2VideoLink"); }

		///<summary>
		/// Feature 3 Button Link: Enter the link for the "Learn More" button if it should appear.
		///</summary>
		[ImplementPropertyType("feature3ButtonLink")]
		public Umbraco.Web.Models.RelatedLinks Feature3ButtonLink
		{
			get { return GetFeature3ButtonLink(this); }
		}

		/// <summary>Static getter for Feature 3 Button Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetFeature3ButtonLink(IHomeFeaturedControls that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("feature3ButtonLink"); }

		///<summary>
		/// Feature 3 Direct Video Link: Choose the video to play in the popup
		///</summary>
		[ImplementPropertyType("feature3DirectVideoLink")]
		public Umbraco.Web.Models.RelatedLinks Feature3DirectVideoLink
		{
			get { return GetFeature3DirectVideoLink(this); }
		}

		/// <summary>Static getter for Feature 3 Direct Video Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetFeature3DirectVideoLink(IHomeFeaturedControls that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("feature3DirectVideoLink"); }

		///<summary>
		/// Feature 3 Label: Enter the text for feature 3
		///</summary>
		[ImplementPropertyType("feature3Label")]
		public string Feature3Label
		{
			get { return GetFeature3Label(this); }
		}

		/// <summary>Static getter for Feature 3 Label</summary>
		public static string GetFeature3Label(IHomeFeaturedControls that) { return that.GetPropertyValue<string>("feature3Label"); }

		///<summary>
		/// Feature 3 Thumbnail: Choose the thumbnail image for feature 3
		///</summary>
		[ImplementPropertyType("feature3Thumbnail")]
		public IPublishedContent Feature3Thumbnail
		{
			get { return GetFeature3Thumbnail(this); }
		}

		/// <summary>Static getter for Feature 3 Thumbnail</summary>
		public static IPublishedContent GetFeature3Thumbnail(IHomeFeaturedControls that) { return that.GetPropertyValue<IPublishedContent>("feature3Thumbnail"); }

		///<summary>
		/// Feature 3 Video Link: If this should link to a list of videos enter the link here.
		///</summary>
		[ImplementPropertyType("feature3VideoLink")]
		public Umbraco.Web.Models.RelatedLinks Feature3VideoLink
		{
			get { return GetFeature3VideoLink(this); }
		}

		/// <summary>Static getter for Feature 3 Video Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetFeature3VideoLink(IHomeFeaturedControls that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("feature3VideoLink"); }

		///<summary>
		/// Feature 4 Button Link: Enter the link for the "Learn More" button if it should appear.
		///</summary>
		[ImplementPropertyType("feature4ButtonLink")]
		public Umbraco.Web.Models.RelatedLinks Feature4ButtonLink
		{
			get { return GetFeature4ButtonLink(this); }
		}

		/// <summary>Static getter for Feature 4 Button Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetFeature4ButtonLink(IHomeFeaturedControls that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("feature4ButtonLink"); }

		///<summary>
		/// Feature 4 Direct Video Link: Choose the video to play in the popup
		///</summary>
		[ImplementPropertyType("feature4DirectVideoLink")]
		public Umbraco.Web.Models.RelatedLinks Feature4DirectVideoLink
		{
			get { return GetFeature4DirectVideoLink(this); }
		}

		/// <summary>Static getter for Feature 4 Direct Video Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetFeature4DirectVideoLink(IHomeFeaturedControls that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("feature4DirectVideoLink"); }

		///<summary>
		/// Feature 4 Label: Enter the text for feature 4.
		///</summary>
		[ImplementPropertyType("feature4Label")]
		public string Feature4Label
		{
			get { return GetFeature4Label(this); }
		}

		/// <summary>Static getter for Feature 4 Label</summary>
		public static string GetFeature4Label(IHomeFeaturedControls that) { return that.GetPropertyValue<string>("feature4Label"); }

		///<summary>
		/// Feature 4 Thumbnail: Choose the thumbnail image for feature 4
		///</summary>
		[ImplementPropertyType("feature4Thumbnail")]
		public IPublishedContent Feature4Thumbnail
		{
			get { return GetFeature4Thumbnail(this); }
		}

		/// <summary>Static getter for Feature 4 Thumbnail</summary>
		public static IPublishedContent GetFeature4Thumbnail(IHomeFeaturedControls that) { return that.GetPropertyValue<IPublishedContent>("feature4Thumbnail"); }

		///<summary>
		/// Feature 4 Video Link: If this should link to a list of videos enter the link here
		///</summary>
		[ImplementPropertyType("feature4VideoLink")]
		public Umbraco.Web.Models.RelatedLinks Feature4VideoLink
		{
			get { return GetFeature4VideoLink(this); }
		}

		/// <summary>Static getter for Feature 4 Video Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetFeature4VideoLink(IHomeFeaturedControls that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("feature4VideoLink"); }
	}
}
