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
	/// <summary>Bldrs Why Builders?</summary>
	[PublishedContentModel("whyBuilders1")]
	public partial class WhyBuilders1 : PublishedContentModel, IBannerControls, ICareerContentControls, ICareerVisionControls, ICareerWhyBuildersIntroControls, ITopNavigationControl
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "whyBuilders1";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public WhyBuilders1(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<WhyBuilders1, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Banner Caption: Enter a caption for this banner (optional)
		///</summary>
		[ImplementPropertyType("bannerCaption")]
		public string BannerCaption
		{
			get { return CustomerPortalCMS.GeneratedModels.BannerControls.GetBannerCaption(this); }
		}

		///<summary>
		/// Banner Image: Choose an image for this banner
		///</summary>
		[ImplementPropertyType("bannerImage")]
		public IPublishedContent BannerImage
		{
			get { return CustomerPortalCMS.GeneratedModels.BannerControls.GetBannerImage(this); }
		}

		///<summary>
		/// Logo Over Banner: If this is clicked a logo will appear over the banner.
		///</summary>
		[ImplementPropertyType("logoOverBanner")]
		public bool LogoOverBanner
		{
			get { return CustomerPortalCMS.GeneratedModels.BannerControls.GetLogoOverBanner(this); }
		}

		///<summary>
		/// Career Content
		///</summary>
		[ImplementPropertyType("careerContent")]
		public IHtmlString CareerContent
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerContentControls.GetCareerContent(this); }
		}

		///<summary>
		/// Value 1 Desc: Enter a description for value 1
		///</summary>
		[ImplementPropertyType("value1Desc")]
		public IHtmlString Value1Desc
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerVisionControls.GetValue1Desc(this); }
		}

		///<summary>
		/// Value 1 Image: Choose an image for Value 1
		///</summary>
		[ImplementPropertyType("value1Image")]
		public IPublishedContent Value1Image
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerVisionControls.GetValue1Image(this); }
		}

		///<summary>
		/// Value 2 Desc: Enter a description for value 2
		///</summary>
		[ImplementPropertyType("value2Desc")]
		public IHtmlString Value2Desc
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerVisionControls.GetValue2Desc(this); }
		}

		///<summary>
		/// Value 2 Image: Choose an image for Value 2
		///</summary>
		[ImplementPropertyType("value2Image")]
		public IPublishedContent Value2Image
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerVisionControls.GetValue2Image(this); }
		}

		///<summary>
		/// Value 3 Desc: Enter a description for value 3
		///</summary>
		[ImplementPropertyType("value3Desc")]
		public IHtmlString Value3Desc
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerVisionControls.GetValue3Desc(this); }
		}

		///<summary>
		/// Value 3 Image: Choose an image for Value 3
		///</summary>
		[ImplementPropertyType("value3Image")]
		public IPublishedContent Value3Image
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerVisionControls.GetValue3Image(this); }
		}

		///<summary>
		/// Value 4 Desc: Enter a description for value 4
		///</summary>
		[ImplementPropertyType("value4Desc")]
		public IHtmlString Value4Desc
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerVisionControls.GetValue4Desc(this); }
		}

		///<summary>
		/// Value 4 Image: Choose an image for Value 4
		///</summary>
		[ImplementPropertyType("value4Image")]
		public IPublishedContent Value4Image
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerVisionControls.GetValue4Image(this); }
		}

		///<summary>
		/// Value 5 Desc: Enter a description for value 5
		///</summary>
		[ImplementPropertyType("value5Desc")]
		public IHtmlString Value5Desc
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerVisionControls.GetValue5Desc(this); }
		}

		///<summary>
		/// Value 5 Image: Choose an image for Value 5
		///</summary>
		[ImplementPropertyType("value5Image")]
		public IPublishedContent Value5Image
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerVisionControls.GetValue5Image(this); }
		}

		///<summary>
		/// Value 6 Desc: Enter a description for value 6
		///</summary>
		[ImplementPropertyType("value6Desc")]
		public IHtmlString Value6Desc
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerVisionControls.GetValue6Desc(this); }
		}

		///<summary>
		/// Value 6 Image: Choose an image for Value 6
		///</summary>
		[ImplementPropertyType("value6Image")]
		public IPublishedContent Value6Image
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerVisionControls.GetValue6Image(this); }
		}

		///<summary>
		/// Vision Description: Enter a description of Builders vision
		///</summary>
		[ImplementPropertyType("visionDescription")]
		public IHtmlString VisionDescription
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerVisionControls.GetVisionDescription(this); }
		}

		///<summary>
		/// Left Column Image: Choose a image for the left column
		///</summary>
		[ImplementPropertyType("leftColumnImage")]
		public IPublishedContent LeftColumnImage
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerWhyBuildersIntroControls.GetLeftColumnImage(this); }
		}

		///<summary>
		/// Left Column Quote: Enter the quote for the left column
		///</summary>
		[ImplementPropertyType("leftColumnQuote")]
		public IHtmlString LeftColumnQuote
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerWhyBuildersIntroControls.GetLeftColumnQuote(this); }
		}

		///<summary>
		/// Left Column Quote By: Left column quote by (optional)
		///</summary>
		[ImplementPropertyType("leftColumnQuoteBy")]
		public string LeftColumnQuoteBy
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerWhyBuildersIntroControls.GetLeftColumnQuoteBy(this); }
		}

		///<summary>
		/// Right Column Bottom Text: Enter the text to appear on the right side after the quote
		///</summary>
		[ImplementPropertyType("rightColumnBottomText")]
		public IHtmlString RightColumnBottomText
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerWhyBuildersIntroControls.GetRightColumnBottomText(this); }
		}

		///<summary>
		/// Right Column Quote: Enter the quote for the right column
		///</summary>
		[ImplementPropertyType("rightColumnQuote")]
		public IHtmlString RightColumnQuote
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerWhyBuildersIntroControls.GetRightColumnQuote(this); }
		}

		///<summary>
		/// Right Column Quote By: Right column quote by (optional)
		///</summary>
		[ImplementPropertyType("rightColumnQuoteBy")]
		public string RightColumnQuoteBy
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerWhyBuildersIntroControls.GetRightColumnQuoteBy(this); }
		}

		///<summary>
		/// Right Column Top Text: Enter the text to appear on the right side before the quote
		///</summary>
		[ImplementPropertyType("rightColumnTopText")]
		public IHtmlString RightColumnTopText
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerWhyBuildersIntroControls.GetRightColumnTopText(this); }
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
