using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Commerce.Catalog.ContentTypes;
using EPiServer.Commerce.Catalog.DataAnnotations;

namespace CMSSite.Models.Catalog
{
    [CatalogContentType(DisplayName = "NikeShoe", GUID = "59fc3c73-772e-4ef4-86e0-453f337904a7", MetaClassName="NikeShoeMetaClass")]
    public class NikeShoeProduct : ProductContent
    {
                       

                [Display(Name = "Product Name")]
                public virtual string ProductName { get; set; }

                [CultureSpecific]
                [Display(Name = "Main body")]
                public virtual XhtmlString MainContent { get; set; }

    }
}