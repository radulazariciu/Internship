using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Commerce.Catalog.DataAnnotations;
using EPiServer.Commerce.Catalog.ContentTypes;

using EPiServer.Web;
using CMSSite.Models.Media;

namespace CMSSite.Models.Catalog
{
    [CatalogContentType(DisplayName = "NikeShoeVariant", GUID = "0950ce18-7e97-458a-b789-0a79aa6388a3", Description = "", MetaClassName = "NikeShoeProduct")]
    public class NikeShoeVariant : VariationContent
    {

        [Display(Name = "Main Content")]
        [CultureSpecific]
        public virtual XhtmlString MainContent { get; set; }

        [Display(Name = "Color")]
        [CultureSpecific]
        public virtual string Color { get; set; }

        [Display(Name = "Size")]
        [CultureSpecific]
        public virtual string Size { get; set; }

        [Display(Name = "Price")]
        [CultureSpecific]
        public virtual int Price { get; set; }

        [UIHint(UIHint.Image)]
        [Display(
            Name = "PageImage",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 40)]
        public virtual ContentReference PageImage { get; set; }
    }
}