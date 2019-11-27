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
	// Mixin content Type 13087 with alias "careersJobsCol6Controls1"
	/// <summary>Careers Jobs Col-6 Controls-WithCrop</summary>
	public partial interface ICareersJobsCol6Controls1 : IPublishedContent
	{
		/// <summary>Job 1 Description</summary>
		IHtmlString Job1Description { get; }

		/// <summary>Job 1 Image</summary>
		Umbraco.Web.Models.ImageCropDataSet Job1Image { get; }

		/// <summary>Job 1 Image Caption</summary>
		string Job1ImageCaption { get; }

		/// <summary>Job 1 Image Video Link</summary>
		Umbraco.Web.Models.RelatedLinks Job1ImageVideoLink { get; }

		/// <summary>Job 1 Link</summary>
		Umbraco.Web.Models.RelatedLinks Job1Link { get; }

		/// <summary>Job 1 Title</summary>
		string Job1Title { get; }

		/// <summary>Job 2 Description</summary>
		IHtmlString Job2Description { get; }

		/// <summary>Job 2 Image</summary>
		Umbraco.Web.Models.ImageCropDataSet Job2Image { get; }

		/// <summary>Job 2 Image Caption</summary>
		string Job2ImageCaption { get; }

		/// <summary>Job 2 Image Video Link</summary>
		Umbraco.Web.Models.RelatedLinks Job2ImageVideoLink { get; }

		/// <summary>Job 2 Link</summary>
		Umbraco.Web.Models.RelatedLinks Job2Link { get; }

		/// <summary>Job 2 Title</summary>
		string Job2Title { get; }

		/// <summary>Job 3 Description</summary>
		IHtmlString Job3Description { get; }

		/// <summary>Job 3 Image</summary>
		Umbraco.Web.Models.ImageCropDataSet Job3Image { get; }

		/// <summary>Job 3 Image Caption</summary>
		string Job3ImageCaption { get; }

		/// <summary>Job 3 Image Video Link</summary>
		Umbraco.Web.Models.RelatedLinks Job3ImageVideoLink { get; }

		/// <summary>Job 3 Link</summary>
		Umbraco.Web.Models.RelatedLinks Job3Link { get; }

		/// <summary>Job 3 Title</summary>
		string Job3Title { get; }

		/// <summary>Job 4 Description</summary>
		IHtmlString Job4Description { get; }

		/// <summary>Job 4 Image</summary>
		Umbraco.Web.Models.ImageCropDataSet Job4Image { get; }

		/// <summary>Job 4 Image Caption</summary>
		string Job4ImageCaption { get; }

		/// <summary>Job 4 Image Video Link</summary>
		Umbraco.Web.Models.RelatedLinks Job4ImageVideoLink { get; }

		/// <summary>Job 4 Link</summary>
		Umbraco.Web.Models.RelatedLinks Job4Link { get; }

		/// <summary>Job 4 Title</summary>
		string Job4Title { get; }

		/// <summary>Job 5 Description</summary>
		IHtmlString Job5Description { get; }

		/// <summary>Job 5 Image</summary>
		Umbraco.Web.Models.ImageCropDataSet Job5Image { get; }

		/// <summary>Job 5 Image Caption</summary>
		string Job5ImageCaption { get; }

		/// <summary>Job 5 Image Video Link</summary>
		Umbraco.Web.Models.RelatedLinks Job5ImageVideoLink { get; }

		/// <summary>Job 5 Link</summary>
		Umbraco.Web.Models.RelatedLinks Job5Link { get; }

		/// <summary>Job 5 Title</summary>
		string Job5Title { get; }

		/// <summary>Job 6 Description</summary>
		IHtmlString Job6Description { get; }

		/// <summary>Job 6 Image</summary>
		Umbraco.Web.Models.ImageCropDataSet Job6Image { get; }

		/// <summary>Job 6 Image Caption</summary>
		string Job6ImageCaption { get; }

		/// <summary>Job 6 Image Video Link</summary>
		Umbraco.Web.Models.RelatedLinks Job6ImageVideoLink { get; }

		/// <summary>Job 6 Link</summary>
		Umbraco.Web.Models.RelatedLinks Job6Link { get; }

		/// <summary>Job 6 Title</summary>
		string Job6Title { get; }

		/// <summary>Job Heading</summary>
		string JobHeading { get; }
	}

	/// <summary>Careers Jobs Col-6 Controls-WithCrop</summary>
	[PublishedContentModel("careersJobsCol6Controls1")]
	public partial class CareersJobsCol6Controls1 : PublishedContentModel, ICareersJobsCol6Controls1
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "careersJobsCol6Controls1";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public CareersJobsCol6Controls1(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<CareersJobsCol6Controls1, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Job 1 Description: Enter a description for this position
		///</summary>
		[ImplementPropertyType("job1Description")]
		public IHtmlString Job1Description
		{
			get { return GetJob1Description(this); }
		}

		/// <summary>Static getter for Job 1 Description</summary>
		public static IHtmlString GetJob1Description(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<IHtmlString>("job1Description"); }

		///<summary>
		/// Job 1 Image: Choose an image for this Job
		///</summary>
		[ImplementPropertyType("job1Image")]
		public Umbraco.Web.Models.ImageCropDataSet Job1Image
		{
			get { return GetJob1Image(this); }
		}

		/// <summary>Static getter for Job 1 Image</summary>
		public static Umbraco.Web.Models.ImageCropDataSet GetJob1Image(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("job1Image"); }

		///<summary>
		/// Job 1 Image Caption: Enter a caption for this image (optional)
		///</summary>
		[ImplementPropertyType("job1ImageCaption")]
		public string Job1ImageCaption
		{
			get { return GetJob1ImageCaption(this); }
		}

		/// <summary>Static getter for Job 1 Image Caption</summary>
		public static string GetJob1ImageCaption(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<string>("job1ImageCaption"); }

		///<summary>
		/// Job 1 Image Video Link
		///</summary>
		[ImplementPropertyType("job1ImageVideoLink")]
		public Umbraco.Web.Models.RelatedLinks Job1ImageVideoLink
		{
			get { return GetJob1ImageVideoLink(this); }
		}

		/// <summary>Static getter for Job 1 Image Video Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetJob1ImageVideoLink(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("job1ImageVideoLink"); }

		///<summary>
		/// Job 1 Link: Choose a URL to link to (*the link caption text will be used for the text in the button)
		///</summary>
		[ImplementPropertyType("job1Link")]
		public Umbraco.Web.Models.RelatedLinks Job1Link
		{
			get { return GetJob1Link(this); }
		}

		/// <summary>Static getter for Job 1 Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetJob1Link(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("job1Link"); }

		///<summary>
		/// Job 1 Title: Enter a title for this job
		///</summary>
		[ImplementPropertyType("job1Title")]
		public string Job1Title
		{
			get { return GetJob1Title(this); }
		}

		/// <summary>Static getter for Job 1 Title</summary>
		public static string GetJob1Title(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<string>("job1Title"); }

		///<summary>
		/// Job 2 Description: Enter a description for this position
		///</summary>
		[ImplementPropertyType("job2Description")]
		public IHtmlString Job2Description
		{
			get { return GetJob2Description(this); }
		}

		/// <summary>Static getter for Job 2 Description</summary>
		public static IHtmlString GetJob2Description(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<IHtmlString>("job2Description"); }

		///<summary>
		/// Job 2 Image: Choose an image for this Job
		///</summary>
		[ImplementPropertyType("job2Image")]
		public Umbraco.Web.Models.ImageCropDataSet Job2Image
		{
			get { return GetJob2Image(this); }
		}

		/// <summary>Static getter for Job 2 Image</summary>
		public static Umbraco.Web.Models.ImageCropDataSet GetJob2Image(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("job2Image"); }

		///<summary>
		/// Job 2 Image Caption: Enter a caption for this image (optional)
		///</summary>
		[ImplementPropertyType("job2ImageCaption")]
		public string Job2ImageCaption
		{
			get { return GetJob2ImageCaption(this); }
		}

		/// <summary>Static getter for Job 2 Image Caption</summary>
		public static string GetJob2ImageCaption(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<string>("job2ImageCaption"); }

		///<summary>
		/// Job 2 Image Video Link
		///</summary>
		[ImplementPropertyType("job2ImageVideoLink")]
		public Umbraco.Web.Models.RelatedLinks Job2ImageVideoLink
		{
			get { return GetJob2ImageVideoLink(this); }
		}

		/// <summary>Static getter for Job 2 Image Video Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetJob2ImageVideoLink(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("job2ImageVideoLink"); }

		///<summary>
		/// Job 2 Link: Choose a URL to link to (*the link caption text will be used for the text in the button)
		///</summary>
		[ImplementPropertyType("job2Link")]
		public Umbraco.Web.Models.RelatedLinks Job2Link
		{
			get { return GetJob2Link(this); }
		}

		/// <summary>Static getter for Job 2 Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetJob2Link(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("job2Link"); }

		///<summary>
		/// Job 2 Title: Enter a title for this job
		///</summary>
		[ImplementPropertyType("job2Title")]
		public string Job2Title
		{
			get { return GetJob2Title(this); }
		}

		/// <summary>Static getter for Job 2 Title</summary>
		public static string GetJob2Title(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<string>("job2Title"); }

		///<summary>
		/// Job 3 Description: Enter a description for this position
		///</summary>
		[ImplementPropertyType("job3Description")]
		public IHtmlString Job3Description
		{
			get { return GetJob3Description(this); }
		}

		/// <summary>Static getter for Job 3 Description</summary>
		public static IHtmlString GetJob3Description(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<IHtmlString>("job3Description"); }

		///<summary>
		/// Job 3 Image: Choose an image for this Job
		///</summary>
		[ImplementPropertyType("job3Image")]
		public Umbraco.Web.Models.ImageCropDataSet Job3Image
		{
			get { return GetJob3Image(this); }
		}

		/// <summary>Static getter for Job 3 Image</summary>
		public static Umbraco.Web.Models.ImageCropDataSet GetJob3Image(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("job3Image"); }

		///<summary>
		/// Job 3 Image Caption: Enter a caption for this image (optional)
		///</summary>
		[ImplementPropertyType("job3ImageCaption")]
		public string Job3ImageCaption
		{
			get { return GetJob3ImageCaption(this); }
		}

		/// <summary>Static getter for Job 3 Image Caption</summary>
		public static string GetJob3ImageCaption(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<string>("job3ImageCaption"); }

		///<summary>
		/// Job 3 Image Video Link
		///</summary>
		[ImplementPropertyType("job3ImageVideoLink")]
		public Umbraco.Web.Models.RelatedLinks Job3ImageVideoLink
		{
			get { return GetJob3ImageVideoLink(this); }
		}

		/// <summary>Static getter for Job 3 Image Video Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetJob3ImageVideoLink(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("job3ImageVideoLink"); }

		///<summary>
		/// Job 3 Link: Choose a URL to link to (*the link caption text will be used for the text in the button)
		///</summary>
		[ImplementPropertyType("job3Link")]
		public Umbraco.Web.Models.RelatedLinks Job3Link
		{
			get { return GetJob3Link(this); }
		}

		/// <summary>Static getter for Job 3 Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetJob3Link(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("job3Link"); }

		///<summary>
		/// Job 3 Title: Enter a title for this job
		///</summary>
		[ImplementPropertyType("job3Title")]
		public string Job3Title
		{
			get { return GetJob3Title(this); }
		}

		/// <summary>Static getter for Job 3 Title</summary>
		public static string GetJob3Title(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<string>("job3Title"); }

		///<summary>
		/// Job 4 Description: Enter a description for this position
		///</summary>
		[ImplementPropertyType("job4Description")]
		public IHtmlString Job4Description
		{
			get { return GetJob4Description(this); }
		}

		/// <summary>Static getter for Job 4 Description</summary>
		public static IHtmlString GetJob4Description(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<IHtmlString>("job4Description"); }

		///<summary>
		/// Job 4 Image: Choose an image for this Job
		///</summary>
		[ImplementPropertyType("job4Image")]
		public Umbraco.Web.Models.ImageCropDataSet Job4Image
		{
			get { return GetJob4Image(this); }
		}

		/// <summary>Static getter for Job 4 Image</summary>
		public static Umbraco.Web.Models.ImageCropDataSet GetJob4Image(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("job4Image"); }

		///<summary>
		/// Job 4 Image Caption: Enter a caption for this image (optional)
		///</summary>
		[ImplementPropertyType("job4ImageCaption")]
		public string Job4ImageCaption
		{
			get { return GetJob4ImageCaption(this); }
		}

		/// <summary>Static getter for Job 4 Image Caption</summary>
		public static string GetJob4ImageCaption(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<string>("job4ImageCaption"); }

		///<summary>
		/// Job 4 Image Video Link
		///</summary>
		[ImplementPropertyType("job4ImageVideoLink")]
		public Umbraco.Web.Models.RelatedLinks Job4ImageVideoLink
		{
			get { return GetJob4ImageVideoLink(this); }
		}

		/// <summary>Static getter for Job 4 Image Video Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetJob4ImageVideoLink(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("job4ImageVideoLink"); }

		///<summary>
		/// Job 4 Link: Choose a URL to link to (*the link caption text will be used for the text in the button)
		///</summary>
		[ImplementPropertyType("job4Link")]
		public Umbraco.Web.Models.RelatedLinks Job4Link
		{
			get { return GetJob4Link(this); }
		}

		/// <summary>Static getter for Job 4 Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetJob4Link(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("job4Link"); }

		///<summary>
		/// Job 4 Title: Enter a title for this job
		///</summary>
		[ImplementPropertyType("job4Title")]
		public string Job4Title
		{
			get { return GetJob4Title(this); }
		}

		/// <summary>Static getter for Job 4 Title</summary>
		public static string GetJob4Title(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<string>("job4Title"); }

		///<summary>
		/// Job 5 Description: Enter a description for this position
		///</summary>
		[ImplementPropertyType("job5Description")]
		public IHtmlString Job5Description
		{
			get { return GetJob5Description(this); }
		}

		/// <summary>Static getter for Job 5 Description</summary>
		public static IHtmlString GetJob5Description(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<IHtmlString>("job5Description"); }

		///<summary>
		/// Job 5 Image: Choose an image for this Job
		///</summary>
		[ImplementPropertyType("job5Image")]
		public Umbraco.Web.Models.ImageCropDataSet Job5Image
		{
			get { return GetJob5Image(this); }
		}

		/// <summary>Static getter for Job 5 Image</summary>
		public static Umbraco.Web.Models.ImageCropDataSet GetJob5Image(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("job5Image"); }

		///<summary>
		/// Job 5 Image Caption: Enter a caption for this image (optional)
		///</summary>
		[ImplementPropertyType("job5ImageCaption")]
		public string Job5ImageCaption
		{
			get { return GetJob5ImageCaption(this); }
		}

		/// <summary>Static getter for Job 5 Image Caption</summary>
		public static string GetJob5ImageCaption(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<string>("job5ImageCaption"); }

		///<summary>
		/// Job 5 Image Video Link
		///</summary>
		[ImplementPropertyType("job5ImageVideoLink")]
		public Umbraco.Web.Models.RelatedLinks Job5ImageVideoLink
		{
			get { return GetJob5ImageVideoLink(this); }
		}

		/// <summary>Static getter for Job 5 Image Video Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetJob5ImageVideoLink(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("job5ImageVideoLink"); }

		///<summary>
		/// Job 5 Link: Choose a URL to link to (*the link caption text will be used for the text in the button)
		///</summary>
		[ImplementPropertyType("job5Link")]
		public Umbraco.Web.Models.RelatedLinks Job5Link
		{
			get { return GetJob5Link(this); }
		}

		/// <summary>Static getter for Job 5 Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetJob5Link(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("job5Link"); }

		///<summary>
		/// Job 5 Title: Enter a title for this job
		///</summary>
		[ImplementPropertyType("job5Title")]
		public string Job5Title
		{
			get { return GetJob5Title(this); }
		}

		/// <summary>Static getter for Job 5 Title</summary>
		public static string GetJob5Title(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<string>("job5Title"); }

		///<summary>
		/// Job 6 Description: Enter a description for this position
		///</summary>
		[ImplementPropertyType("job6Description")]
		public IHtmlString Job6Description
		{
			get { return GetJob6Description(this); }
		}

		/// <summary>Static getter for Job 6 Description</summary>
		public static IHtmlString GetJob6Description(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<IHtmlString>("job6Description"); }

		///<summary>
		/// Job 6 Image: Choose an image for this Job
		///</summary>
		[ImplementPropertyType("job6Image")]
		public Umbraco.Web.Models.ImageCropDataSet Job6Image
		{
			get { return GetJob6Image(this); }
		}

		/// <summary>Static getter for Job 6 Image</summary>
		public static Umbraco.Web.Models.ImageCropDataSet GetJob6Image(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("job6Image"); }

		///<summary>
		/// Job 6 Image Caption: Enter a caption for this image (optional)
		///</summary>
		[ImplementPropertyType("job6ImageCaption")]
		public string Job6ImageCaption
		{
			get { return GetJob6ImageCaption(this); }
		}

		/// <summary>Static getter for Job 6 Image Caption</summary>
		public static string GetJob6ImageCaption(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<string>("job6ImageCaption"); }

		///<summary>
		/// Job 6 Image Video Link
		///</summary>
		[ImplementPropertyType("job6ImageVideoLink")]
		public Umbraco.Web.Models.RelatedLinks Job6ImageVideoLink
		{
			get { return GetJob6ImageVideoLink(this); }
		}

		/// <summary>Static getter for Job 6 Image Video Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetJob6ImageVideoLink(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("job6ImageVideoLink"); }

		///<summary>
		/// Job 6 Link: Choose a URL to link to (*the link caption text will be used for the text in the button)
		///</summary>
		[ImplementPropertyType("job6Link")]
		public Umbraco.Web.Models.RelatedLinks Job6Link
		{
			get { return GetJob6Link(this); }
		}

		/// <summary>Static getter for Job 6 Link</summary>
		public static Umbraco.Web.Models.RelatedLinks GetJob6Link(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("job6Link"); }

		///<summary>
		/// Job 6 Title: Enter a title for this job
		///</summary>
		[ImplementPropertyType("job6Title")]
		public string Job6Title
		{
			get { return GetJob6Title(this); }
		}

		/// <summary>Static getter for Job 6 Title</summary>
		public static string GetJob6Title(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<string>("job6Title"); }

		///<summary>
		/// Job Heading: Enter the heading for this section
		///</summary>
		[ImplementPropertyType("jobHeading")]
		public string JobHeading
		{
			get { return GetJobHeading(this); }
		}

		/// <summary>Static getter for Job Heading</summary>
		public static string GetJobHeading(ICareersJobsCol6Controls1 that) { return that.GetPropertyValue<string>("jobHeading"); }
	}
}
