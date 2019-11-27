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
	/// <summary>Bldrs Why Builders -WithCrop</summary>
	[PublishedContentModel("whyBuilders11")]
	public partial class WhyBuilders11 : PublishedContentModel, IBannerControls11, ICareerContentControls, ICareerVisionControls1, ICareerWhyBuildersIntroControls1, ITopNavigationControl
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "whyBuilders11";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public WhyBuilders11(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<WhyBuilders11, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Banner Caption: Enter a caption for this banner (optional)
		///</summary>
		[ImplementPropertyType("bannerCaption")]
		public string BannerCaption
		{
			get { return CustomerPortalCMS.GeneratedModels.BannerControls11.GetBannerCaption(this); }
		}

		///<summary>
		/// Banner Image: Choose an image for this banner
		///</summary>
		[ImplementPropertyType("bannerImage")]
		public Umbraco.Web.Models.ImageCropDataSet BannerImage
		{
			get { return CustomerPortalCMS.GeneratedModels.BannerControls11.GetBannerImage(this); }
		}

		///<summary>
		/// Logo Over Banner: If this is clicked a logo will appear over the banner.
		///</summary>
		[ImplementPropertyType("logoOverBanner")]
		public bool LogoOverBanner
		{
			get { return CustomerPortalCMS.GeneratedModels.BannerControls11.GetLogoOverBanner(this); }
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
			get { return CustomerPortalCMS.GeneratedModels.CareerVisionControls1.GetValue1Desc(this); }
		}

		///<summary>
		/// Value 1 Image: Choose an image for Value 1
		///</summary>
		[ImplementPropertyType("value1Image")]
		public Umbraco.Web.Models.ImageCropDataSet Value1Image
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerVisionControls1.GetValue1Image(this); }
		}

		///<summary>
		/// Value 2 Desc: Enter a description for value 2
		///</summary>
		[ImplementPropertyType("value2Desc")]
		public IHtmlString Value2Desc
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerVisionControls1.GetValue2Desc(this); }
		}

		///<summary>
		/// Value 2 Image: Choose an image for Value 2
		///</summary>
		[ImplementPropertyType("value2Image")]
		public Umbraco.Web.Models.ImageCropDataSet Value2Image
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerVisionControls1.GetValue2Image(this); }
		}

		///<summary>
		/// Value 3 Desc: Enter a description for value 3
		///</summary>
		[ImplementPropertyType("value3Desc")]
		public IHtmlString Value3Desc
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerVisionControls1.GetValue3Desc(this); }
		}

		///<summary>
		/// Value 3 Image: Choose an image for Value 3
		///</summary>
		[ImplementPropertyType("value3Image")]
		public Umbraco.Web.Models.ImageCropDataSet Value3Image
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerVisionControls1.GetValue3Image(this); }
		}

		///<summary>
		/// Value 4 Desc: Enter a description for value 4
		///</summary>
		[ImplementPropertyType("value4Desc")]
		public IHtmlString Value4Desc
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerVisionControls1.GetValue4Desc(this); }
		}

		///<summary>
		/// Value 4 Image: Choose an image for Value 4
		///</summary>
		[ImplementPropertyType("value4Image")]
		public Umbraco.Web.Models.ImageCropDataSet Value4Image
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerVisionControls1.GetValue4Image(this); }
		}

		///<summary>
		/// Value 5 Desc: Enter a description for value 5
		///</summary>
		[ImplementPropertyType("value5Desc")]
		public IHtmlString Value5Desc
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerVisionControls1.GetValue5Desc(this); }
		}

		///<summary>
		/// Value 5 Image: Choose an image for Value 5
		///</summary>
		[ImplementPropertyType("value5Image")]
		public Umbraco.Web.Models.ImageCropDataSet Value5Image
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerVisionControls1.GetValue5Image(this); }
		}

		///<summary>
		/// Value 6 Desc: Enter a description for value 6
		///</summary>
		[ImplementPropertyType("value6Desc")]
		public IHtmlString Value6Desc
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerVisionControls1.GetValue6Desc(this); }
		}

		///<summary>
		/// Value 6 Image: Choose an image for Value 6
		///</summary>
		[ImplementPropertyType("value6Image")]
		public Umbraco.Web.Models.ImageCropDataSet Value6Image
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerVisionControls1.GetValue6Image(this); }
		}

		///<summary>
		/// Vision Description: Enter a description of Builders vision
		///</summary>
		[ImplementPropertyType("visionDescription")]
		public IHtmlString VisionDescription
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerVisionControls1.GetVisionDescription(this); }
		}

		///<summary>
		/// Left Column Image: Choose a image for the left column
		///</summary>
		[ImplementPropertyType("leftColumnImage")]
		public Umbraco.Web.Models.ImageCropDataSet LeftColumnImage
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerWhyBuildersIntroControls1.GetLeftColumnImage(this); }
		}

		///<summary>
		/// Left Column Quote: Enter the quote for the left column
		///</summary>
		[ImplementPropertyType("leftColumnQuote")]
		public IHtmlString LeftColumnQuote
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerWhyBuildersIntroControls1.GetLeftColumnQuote(this); }
		}

		///<summary>
		/// Left Column Quote By: Left column quote by (optional)
		///</summary>
		[ImplementPropertyType("leftColumnQuoteBy")]
		public string LeftColumnQuoteBy
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerWhyBuildersIntroControls1.GetLeftColumnQuoteBy(this); }
		}

		///<summary>
		/// Right Column Bottom Text: Enter the text to appear on the right side after the quote
		///</summary>
		[ImplementPropertyType("rightColumnBottomText")]
		public IHtmlString RightColumnBottomText
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerWhyBuildersIntroControls1.GetRightColumnBottomText(this); }
		}

		///<summary>
		/// Right Column Quote: Enter the quote for the right column
		///</summary>
		[ImplementPropertyType("rightColumnQuote")]
		public IHtmlString RightColumnQuote
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerWhyBuildersIntroControls1.GetRightColumnQuote(this); }
		}

		///<summary>
		/// Right Column Quote By: Right column quote by (optional)
		///</summary>
		[ImplementPropertyType("rightColumnQuoteBy")]
		public string RightColumnQuoteBy
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerWhyBuildersIntroControls1.GetRightColumnQuoteBy(this); }
		}

		///<summary>
		/// Right Column Top Text: Enter the text to appear on the right side before the quote
		///</summary>
		[ImplementPropertyType("rightColumnTopText")]
		public IHtmlString RightColumnTopText
		{
			get { return CustomerPortalCMS.GeneratedModels.CareerWhyBuildersIntroControls1.GetRightColumnTopText(this); }
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
