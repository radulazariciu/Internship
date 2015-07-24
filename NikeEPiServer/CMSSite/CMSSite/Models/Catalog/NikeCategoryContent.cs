using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Commerce.Catalog.DataAnnotations;
using EPiServer.Commerce.Catalog.ContentTypes;

namespace CMSSite.Models.Catalog
{
    [CatalogContentType(GUID = "12f7856a-c861-4134-8fbf-84a8b3770975", MetaClassName = "NikeCatalogNode")]
    public class NikeCategoryContent : NodeContent
    {
       
    }
}