//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>Home Page</summary>
	[PublishedModel("homePage")]
	public partial class HomePage : PublishedContentModel, IPageBlocksProperty, IPageModulesProperty, ISiteGlobalProperties, ISiteModulesProperty, ISiteNavigationProperties
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		public new const string ModelTypeAlias = "homePage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<HomePage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public HomePage(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Blocks
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageBlocks")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedElement> PageBlocks => global::Umbraco.Cms.Web.Common.PublishedModels.PageBlocksProperty.GetPageBlocks(this, _publishedValueFallback);

		///<summary>
		/// Page modules: Configure modules that are specific to this page.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageModules")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedElement> PageModules => global::Umbraco.Cms.Web.Common.PublishedModels.PageModulesProperty.GetPageModules(this, _publishedValueFallback);

		///<summary>
		/// Site title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("siteTitle")]
		public virtual string SiteTitle => global::Umbraco.Cms.Web.Common.PublishedModels.SiteGlobalProperties.GetSiteTitle(this, _publishedValueFallback);

		///<summary>
		/// Site modules: Configure general modules for the website, these are applied across all pages.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("siteModules")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedElement> SiteModules => global::Umbraco.Cms.Web.Common.PublishedModels.SiteModulesProperty.GetSiteModules(this, _publishedValueFallback);

		///<summary>
		/// Footer
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("footer")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedElement> Footer => global::Umbraco.Cms.Web.Common.PublishedModels.SiteNavigationProperties.GetFooter(this, _publishedValueFallback);

		///<summary>
		/// Header
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0+5bfab13dc5a268714aad2426a2b68ab5561a6407")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("header")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.PublishedContent.IPublishedElement> Header => global::Umbraco.Cms.Web.Common.PublishedModels.SiteNavigationProperties.GetHeader(this, _publishedValueFallback);
	}
}
