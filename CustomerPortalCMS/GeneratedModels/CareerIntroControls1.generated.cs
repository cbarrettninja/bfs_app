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
	// Mixin content Type 13086 with alias "careerIntroControls1"
	/// <summary>Career Intro Controls-WithCrop</summary>
	public partial interface ICareerIntroControls1 : IPublishedContent
	{
		/// <summary>Career Intro Paragraph 1</summary>
		IHtmlString CareerIntroParagraph1 { get; }

		/// <summary>Career Intro Paragraph 2</summary>
		IHtmlString CareerIntroParagraph2 { get; }

		/// <summary>Career Sub Menu 1 Image</summary>
		Umbraco.Web.Models.ImageCropDataSet CareerSubMenu1Image { get; }

		/// <summary>Career Sub Menu 1 Link</summary>
		Umbraco.Web.Models.RelatedLinks CareerSubMenu1Link { get; }

		/// <summary>Career Sub Menu 1 Text</summary>
		string CareerSubMenu1Text { get; }

		/// <summary>Career Sub Menu 2 Image</summary>
		Umbraco.Web.Models.ImageCropDataSet CareerSubMenu2Image { get; }

		/// <summary>Career Sub Menu 2 Link</summary>
		Umbraco.Web.Models.RelatedLinks CareerSubMenu2Link { get; }

		/// <summary>Career Sub Menu 2 Text</summary>
		string CareerSubMenu2Text { get; }

		/// <summary>Career Sub Menu 3 Image</summary>
		Umbraco.Web.Models.ImageCropDataSet CareerSubMenu3Image { get; }

		/// <summary>Career Sub Menu 3 Link</summary>
		Umbraco.Web.Models.RelatedLinks CareerSubMenu3Link { get; }

		/// <summary>Career Sub Menu 3 Text</summary>
		string CareerSubMenu3Text { get; }

		/// <summary>Career Sub Menu 4 Image</summary>
		Umbraco.Web.Models.ImageCropDataSet CareerSubMenu4Image { get; }

		/// <summary>Career Sub Menu 4 Link</summary>
		Umbraco.Web.Models.RelatedLinks CareerSubMenu4Link { get; }

		/// <summary>Career Sub Menu 4 Text</summary>
		string CareerSubMenu4Text { get; }

		/// <summary>Career Sub Menu 5 Image</summary>
		Umbraco.Web.Models.ImageCropDataSet CareerSubMenu5Image { get; }

		/// <summary>Career Sub Menu 5 Link</summary>
		Umbraco.Web.Models.RelatedLinks CareerSubMenu5Link { get; }

		/// <summary>Career Sub Menu 5 Text</summary>
		string CareerSubMenu5Text { get; }
	}

	/// <summary>Career Intro Controls-WithCrop</summary>
	[PublishedContentModel("careerIntroControls1")]
	public partial class CareerIntroControls1 : PublishedContentModel, ICareerIntroControls1
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "careerIntroControls1";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public CareerIntroControls1(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<CareerIntroControls1, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Career Intro Paragraph 1: Enter the introduction text for the first paragraph
		///</summary>
		[ImplementPropertyType("careerIntroParagraph1")]
		public IHtmlString CareerIntroParagraph1
		{
			get { return GetCareerIntroParagraph1(this); }
		}

		/// <summary>Static getter for Career Intro Paragraph 1</summary>
		public static IHtmlString GetCareerIntroParagraph1(ICareerIntroControls1 that) { return that.GetPropertyValue<IHtmlString>("careerIntroParagraph1"); }

		///<summary>
		/// Career Intro Paragraph 2: Enter the introduction text for the second paragraph
		///</summary>
		[ImplementPropertyType("careerIntroParagraph2")]
		public IHtmlString CareerIntroParagraph2
		{
			get { return GetCareerIntroParagraph2(this); }
		}

		/// <summary>Static getter for Career Intro Paragraph 2</summary>
		public static IHtmlString GetCareerIntroParagraph2(ICareerIntroControls1 that) { return that.GetPropertyValue<IHtmlString>("careerIntroParagraph2"); }

		///<summary>
		/// Career Sub Menu 1 Image: Select a image for this sub menu
		///</summary>
		[ImplementPropertyType("careerSubMenu1Image")]
		public Umbraco.Web.Models.ImageCropDataSet CareerSubMenu1Image
		{
			get { return GetCareerSubMenu1Image(this); }
		}

		/// <summary>Static getter for Career Sub Menu 1 Image</summary>
		public static Umbraco.Web.Models.ImageCropDataSet GetCareerSubMenu1Image(ICareerIntroControls1 that) { return that.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("careerSubMenu1Image"); }

		///<summary>
		/// Career Sub Menu 1 Link: Select or enter the URL to link to
		///</summary>
		[ImplementPropertyType("careerSubMenu1Link")]
		public Umbraco.Web.Models.RelatedLinks CareerSubMenu1Link
		{
			get { return GetCareerSubMenu1Link(this); }
		}

		/// <summary>Static getter for Career Sub Menu 1 Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetCareerSubMenu1Link(ICareerIntroControls1 that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("careerSubMenu1Link"); }

		///<summary>
		/// Career Sub Menu 1 Text: Enter the text for the first sub menu image
		///</summary>
		[ImplementPropertyType("careerSubMenu1Text")]
		public string CareerSubMenu1Text
		{
			get { return GetCareerSubMenu1Text(this); }
		}

		/// <summary>Static getter for Career Sub Menu 1 Text</summary>
		public static string GetCareerSubMenu1Text(ICareerIntroControls1 that) { return that.GetPropertyValue<string>("careerSubMenu1Text"); }

		///<summary>
		/// Career Sub Menu 2 Image: Select a image for this sub menu
		///</summary>
		[ImplementPropertyType("careerSubMenu2Image")]
		public Umbraco.Web.Models.ImageCropDataSet CareerSubMenu2Image
		{
			get { return GetCareerSubMenu2Image(this); }
		}

		/// <summary>Static getter for Career Sub Menu 2 Image</summary>
		public static Umbraco.Web.Models.ImageCropDataSet GetCareerSubMenu2Image(ICareerIntroControls1 that) { return that.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("careerSubMenu2Image"); }

		///<summary>
		/// Career Sub Menu 2 Link: Select or enter the URL to link
		///</summary>
		[ImplementPropertyType("careerSubMenu2Link")]
		public Umbraco.Web.Models.RelatedLinks CareerSubMenu2Link
		{
			get { return GetCareerSubMenu2Link(this); }
		}

		/// <summary>Static getter for Career Sub Menu 2 Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetCareerSubMenu2Link(ICareerIntroControls1 that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("careerSubMenu2Link"); }

		///<summary>
		/// Career Sub Menu 2 Text: Enter the text for the second sub menu image
		///</summary>
		[ImplementPropertyType("careerSubMenu2Text")]
		public string CareerSubMenu2Text
		{
			get { return GetCareerSubMenu2Text(this); }
		}

		/// <summary>Static getter for Career Sub Menu 2 Text</summary>
		public static string GetCareerSubMenu2Text(ICareerIntroControls1 that) { return that.GetPropertyValue<string>("careerSubMenu2Text"); }

		///<summary>
		/// Career Sub Menu 3 Image: Select a image for this sub menu
		///</summary>
		[ImplementPropertyType("careerSubMenu3Image")]
		public Umbraco.Web.Models.ImageCropDataSet CareerSubMenu3Image
		{
			get { return GetCareerSubMenu3Image(this); }
		}

		/// <summary>Static getter for Career Sub Menu 3 Image</summary>
		public static Umbraco.Web.Models.ImageCropDataSet GetCareerSubMenu3Image(ICareerIntroControls1 that) { return that.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("careerSubMenu3Image"); }

		///<summary>
		/// Career Sub Menu 3 Link: Select or enter the URL to link
		///</summary>
		[ImplementPropertyType("careerSubMenu3Link")]
		public Umbraco.Web.Models.RelatedLinks CareerSubMenu3Link
		{
			get { return GetCareerSubMenu3Link(this); }
		}

		/// <summary>Static getter for Career Sub Menu 3 Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetCareerSubMenu3Link(ICareerIntroControls1 that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("careerSubMenu3Link"); }

		///<summary>
		/// Career Sub Menu 3 Text: Enter the text for the third sub menu image
		///</summary>
		[ImplementPropertyType("careerSubMenu3Text")]
		public string CareerSubMenu3Text
		{
			get { return GetCareerSubMenu3Text(this); }
		}

		/// <summary>Static getter for Career Sub Menu 3 Text</summary>
		public static string GetCareerSubMenu3Text(ICareerIntroControls1 that) { return that.GetPropertyValue<string>("careerSubMenu3Text"); }

		///<summary>
		/// Career Sub Menu 4 Image: Select the image for this sub menu
		///</summary>
		[ImplementPropertyType("careerSubMenu4Image")]
		public Umbraco.Web.Models.ImageCropDataSet CareerSubMenu4Image
		{
			get { return GetCareerSubMenu4Image(this); }
		}

		/// <summary>Static getter for Career Sub Menu 4 Image</summary>
		public static Umbraco.Web.Models.ImageCropDataSet GetCareerSubMenu4Image(ICareerIntroControls1 that) { return that.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("careerSubMenu4Image"); }

		///<summary>
		/// Career Sub Menu 4 Link: Select or enter the URL to link
		///</summary>
		[ImplementPropertyType("careerSubMenu4Link")]
		public Umbraco.Web.Models.RelatedLinks CareerSubMenu4Link
		{
			get { return GetCareerSubMenu4Link(this); }
		}

		/// <summary>Static getter for Career Sub Menu 4 Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetCareerSubMenu4Link(ICareerIntroControls1 that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("careerSubMenu4Link"); }

		///<summary>
		/// Career Sub Menu 4 Text: Enter the text for the fourth sub menu image
		///</summary>
		[ImplementPropertyType("careerSubMenu4Text")]
		public string CareerSubMenu4Text
		{
			get { return GetCareerSubMenu4Text(this); }
		}

		/// <summary>Static getter for Career Sub Menu 4 Text</summary>
		public static string GetCareerSubMenu4Text(ICareerIntroControls1 that) { return that.GetPropertyValue<string>("careerSubMenu4Text"); }

		///<summary>
		/// Career Sub Menu 5 Image: Select the image for this sub menu
		///</summary>
		[ImplementPropertyType("careerSubMenu5Image")]
		public Umbraco.Web.Models.ImageCropDataSet CareerSubMenu5Image
		{
			get { return GetCareerSubMenu5Image(this); }
		}

		/// <summary>Static getter for Career Sub Menu 5 Image</summary>
		public static Umbraco.Web.Models.ImageCropDataSet GetCareerSubMenu5Image(ICareerIntroControls1 that) { return that.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("careerSubMenu5Image"); }

		///<summary>
		/// Career Sub Menu 5 Link: Select or enter the URL to link
		///</summary>
		[ImplementPropertyType("careerSubMenu5Link")]
		public Umbraco.Web.Models.RelatedLinks CareerSubMenu5Link
		{
			get { return GetCareerSubMenu5Link(this); }
		}

		/// <summary>Static getter for Career Sub Menu 5 Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetCareerSubMenu5Link(ICareerIntroControls1 that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("careerSubMenu5Link"); }

		///<summary>
		/// Career Sub Menu 5 Text: Enter the text for the fifth sub menu image
		///</summary>
		[ImplementPropertyType("careerSubMenu5Text")]
		public string CareerSubMenu5Text
		{
			get { return GetCareerSubMenu5Text(this); }
		}

		/// <summary>Static getter for Career Sub Menu 5 Text</summary>
		public static string GetCareerSubMenu5Text(ICareerIntroControls1 that) { return that.GetPropertyValue<string>("careerSubMenu5Text"); }
	}
}
