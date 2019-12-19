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
	/// <summary>Bldr Home</summary>
	[PublishedContentModel("bldrhome")]
	public partial class Bldrhome : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "bldrhome";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Bldrhome(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Bldrhome, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Feature 1 Label
		///</summary>
		[ImplementPropertyType("feature1Label")]
		public string Feature1Label
		{
			get { return this.GetPropertyValue<string>("feature1Label"); }
		}

		///<summary>
		/// Feature 1 Thumbnail
		///</summary>
		[ImplementPropertyType("feature1Thumbnail")]
		public Umbraco.Web.Models.ImageCropDataSet Feature1Thumbnail
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("feature1Thumbnail"); }
		}

		///<summary>
		/// Feature 1 Video Image
		///</summary>
		[ImplementPropertyType("feature1VideoImage")]
		public Umbraco.Web.Models.ImageCropDataSet Feature1VideoImage
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("feature1VideoImage"); }
		}

		///<summary>
		/// Feature 1 Video Link
		///</summary>
		[ImplementPropertyType("feature1VideoLink")]
		public string Feature1VideoLink
		{
			get { return this.GetPropertyValue<string>("feature1VideoLink"); }
		}

		///<summary>
		/// Feature 2 Label
		///</summary>
		[ImplementPropertyType("feature2Label")]
		public string Feature2Label
		{
			get { return this.GetPropertyValue<string>("feature2Label"); }
		}

		///<summary>
		/// Feature 2 Thumbnail
		///</summary>
		[ImplementPropertyType("feature2Thumbnail")]
		public Umbraco.Web.Models.ImageCropDataSet Feature2Thumbnail
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("feature2Thumbnail"); }
		}

		///<summary>
		/// Feature 2 Video Image
		///</summary>
		[ImplementPropertyType("feature2VideoImage")]
		public Umbraco.Web.Models.ImageCropDataSet Feature2VideoImage
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("feature2VideoImage"); }
		}

		///<summary>
		/// Feature 2 Video Link
		///</summary>
		[ImplementPropertyType("feature2VideoLink")]
		public string Feature2VideoLink
		{
			get { return this.GetPropertyValue<string>("feature2VideoLink"); }
		}

		///<summary>
		/// Feature 3 Label
		///</summary>
		[ImplementPropertyType("feature3Label")]
		public string Feature3Label
		{
			get { return this.GetPropertyValue<string>("feature3Label"); }
		}

		///<summary>
		/// Feature 3 Thumbnail
		///</summary>
		[ImplementPropertyType("feature3Thumbnail")]
		public Umbraco.Web.Models.ImageCropDataSet Feature3Thumbnail
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("feature3Thumbnail"); }
		}

		///<summary>
		/// Feature 3 Video Image
		///</summary>
		[ImplementPropertyType("feature3VideoImage")]
		public Umbraco.Web.Models.ImageCropDataSet Feature3VideoImage
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("feature3VideoImage"); }
		}

		///<summary>
		/// Feature 3 Video Link
		///</summary>
		[ImplementPropertyType("feature3VideoLink")]
		public string Feature3VideoLink
		{
			get { return this.GetPropertyValue<string>("feature3VideoLink"); }
		}

		///<summary>
		/// Feature 4 Label
		///</summary>
		[ImplementPropertyType("feature4Label")]
		public string Feature4Label
		{
			get { return this.GetPropertyValue<string>("feature4Label"); }
		}

		///<summary>
		/// Feature 4 Thumbnail
		///</summary>
		[ImplementPropertyType("feature4Thumbnail")]
		public Umbraco.Web.Models.ImageCropDataSet Feature4Thumbnail
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("feature4Thumbnail"); }
		}

		///<summary>
		/// Feature 4 Video Image
		///</summary>
		[ImplementPropertyType("feature4VideoImage")]
		public Umbraco.Web.Models.ImageCropDataSet Feature4VideoImage
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("feature4VideoImage"); }
		}

		///<summary>
		/// Feature 4 Video Link
		///</summary>
		[ImplementPropertyType("feature4VideoLink")]
		public string Feature4VideoLink
		{
			get { return this.GetPropertyValue<string>("feature4VideoLink"); }
		}

		///<summary>
		/// Image Gradient Opacity: In Percentage
		///</summary>
		[ImplementPropertyType("imageGradientOpacity")]
		public decimal ImageGradientOpacity
		{
			get { return this.GetPropertyValue<decimal>("imageGradientOpacity"); }
		}

		///<summary>
		/// Image Text Font Color
		///</summary>
		[ImplementPropertyType("imageTextFontColor")]
		public object ImageTextFontColor
		{
			get { return this.GetPropertyValue("imageTextFontColor"); }
		}

		///<summary>
		/// Image Text Font Size: in pixels
		///</summary>
		[ImplementPropertyType("imageTextFontSize")]
		public int ImageTextFontSize
		{
			get { return this.GetPropertyValue<int>("imageTextFontSize"); }
		}

		///<summary>
		/// Image Text Font Size (Mobile): in pixels
		///</summary>
		[ImplementPropertyType("imageTextFontSizeMobile")]
		public int ImageTextFontSizeMobile
		{
			get { return this.GetPropertyValue<int>("imageTextFontSizeMobile"); }
		}

		///<summary>
		/// Image Text Gradient Position
		///</summary>
		[ImplementPropertyType("imageTextGradientPosition")]
		public string ImageTextGradientPosition
		{
			get { return this.GetPropertyValue<string>("imageTextGradientPosition"); }
		}

		///<summary>
		/// Image Text Horizontal Position
		///</summary>
		[ImplementPropertyType("imageTextHorizontalPosition")]
		public string ImageTextHorizontalPosition
		{
			get { return this.GetPropertyValue<string>("imageTextHorizontalPosition"); }
		}

		///<summary>
		/// Image Text Vertical Position
		///</summary>
		[ImplementPropertyType("imageTextVerticalPosition")]
		public string ImageTextVerticalPosition
		{
			get { return this.GetPropertyValue<string>("imageTextVerticalPosition"); }
		}

		///<summary>
		/// Section1 About: Section1 About
		///</summary>
		[ImplementPropertyType("section1About")]
		public IHtmlString Section1About
		{
			get { return this.GetPropertyValue<IHtmlString>("section1About"); }
		}

		///<summary>
		/// Section1 Button Link: Section1 Button Link
		///</summary>
		[ImplementPropertyType("section1ButtonLink")]
		public Umbraco.Web.Models.RelatedLinks Section1ButtonLink
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("section1ButtonLink"); }
		}

		///<summary>
		/// Section1 Image1: Section1Image1
		///</summary>
		[ImplementPropertyType("section1Image1")]
		public Umbraco.Web.Models.ImageCropDataSet Section1Image1
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("section1Image1"); }
		}

		///<summary>
		/// Section1 Image2: Section1Image1
		///</summary>
		[ImplementPropertyType("section1Image2")]
		public Umbraco.Web.Models.ImageCropDataSet Section1Image2
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("section1Image2"); }
		}

		///<summary>
		/// Section1 Title: Section1 Description
		///</summary>
		[ImplementPropertyType("section1Title")]
		public string Section1Title
		{
			get { return this.GetPropertyValue<string>("section1Title"); }
		}

		///<summary>
		/// Section 2 Title
		///</summary>
		[ImplementPropertyType("section2Title")]
		public string Section2Title
		{
			get { return this.GetPropertyValue<string>("section2Title"); }
		}

		///<summary>
		/// Section3 Button
		///</summary>
		[ImplementPropertyType("section3Button")]
		public Umbraco.Web.Models.RelatedLinks Section3Button
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("section3Button"); }
		}

		///<summary>
		/// Section3 Description
		///</summary>
		[ImplementPropertyType("section3Description")]
		public IHtmlString Section3Description
		{
			get { return this.GetPropertyValue<IHtmlString>("section3Description"); }
		}

		///<summary>
		/// Section3 Title
		///</summary>
		[ImplementPropertyType("section3Title")]
		public string Section3Title
		{
			get { return this.GetPropertyValue<string>("section3Title"); }
		}

		///<summary>
		/// Section3 Video Link
		///</summary>
		[ImplementPropertyType("section3VideoLink")]
		public Umbraco.Web.Models.RelatedLinks Section3VideoLink
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("section3VideoLink"); }
		}

		///<summary>
		/// Section3 Video Thumbnail
		///</summary>
		[ImplementPropertyType("section3VideoThumbnail")]
		public Umbraco.Web.Models.ImageCropDataSet Section3VideoThumbnail
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("section3VideoThumbnail"); }
		}

		///<summary>
		/// Services Tab 1 Data
		///</summary>
		[ImplementPropertyType("servicesTab1Data")]
		public IEnumerable<IPublishedContent> ServicesTab1Data
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("servicesTab1Data"); }
		}

		///<summary>
		/// Services Tab 1 Image
		///</summary>
		[ImplementPropertyType("servicesTab1Image")]
		public Umbraco.Web.Models.ImageCropDataSet ServicesTab1Image
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("servicesTab1Image"); }
		}

		///<summary>
		/// Services Tab 1 Title
		///</summary>
		[ImplementPropertyType("servicesTab1Title")]
		public string ServicesTab1Title
		{
			get { return this.GetPropertyValue<string>("servicesTab1Title"); }
		}

		///<summary>
		/// Services Tab 2 Data
		///</summary>
		[ImplementPropertyType("servicesTab2Data")]
		public IEnumerable<IPublishedContent> ServicesTab2Data
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("servicesTab2Data"); }
		}

		///<summary>
		/// Services Tab 2 Image
		///</summary>
		[ImplementPropertyType("servicesTab2Image")]
		public Umbraco.Web.Models.ImageCropDataSet ServicesTab2Image
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("servicesTab2Image"); }
		}

		///<summary>
		/// Services Tab 2 Title
		///</summary>
		[ImplementPropertyType("servicesTab2Title")]
		public string ServicesTab2Title
		{
			get { return this.GetPropertyValue<string>("servicesTab2Title"); }
		}

		///<summary>
		/// Services Tab 3 Data
		///</summary>
		[ImplementPropertyType("servicesTab3Data")]
		public IEnumerable<IPublishedContent> ServicesTab3Data
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("servicesTab3Data"); }
		}

		///<summary>
		/// Services  Tab 3 Image
		///</summary>
		[ImplementPropertyType("servicesTab3Image")]
		public Umbraco.Web.Models.ImageCropDataSet ServicesTab3Image
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("servicesTab3Image"); }
		}

		///<summary>
		/// Services Tab 3 Title
		///</summary>
		[ImplementPropertyType("servicesTab3Title")]
		public string ServicesTab3Title
		{
			get { return this.GetPropertyValue<string>("servicesTab3Title"); }
		}

		///<summary>
		/// Services Title
		///</summary>
		[ImplementPropertyType("servicesTitle")]
		public string ServicesTitle
		{
			get { return this.GetPropertyValue<string>("servicesTitle"); }
		}

		///<summary>
		/// Store Locator Section Title
		///</summary>
		[ImplementPropertyType("storeLocatorSectionTitle")]
		public string StoreLocatorSectionTitle
		{
			get { return this.GetPropertyValue<string>("storeLocatorSectionTitle"); }
		}
	}
}