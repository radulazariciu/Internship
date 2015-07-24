using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;
using EPiServer.XForms;
using EPiServer;
using EPiServer.Framework.DataAnnotations;


namespace CMSSite.Models.Pages
{
    [ContentType(DisplayName = "PDP", GUID = "9e5b989e-3894-4e93-bc0a-aaf96103ece6", Description = "")]
    public class PDP : PageData
    {

        // ------------------------------------------------

        // PropertyLongString (PropertyString)

        // ------------------------------------------------

        [Display(

            Name = "Heading",

            Description = "",

            GroupName = SystemTabNames.Content,

            Order = 10)]

        public virtual string Heading { get; set; }





        // ------------------------------------------------

        // PropertyXhtmlString

        // ------------------------------------------------

        [Display(

            Name = "Main body",

            Description = "",

            GroupName = SystemTabNames.Content,

            Order = 20)]

        public virtual XhtmlString MainBody { get; set; }





        //// ------------------------------------------------

        //// PropertyUrl

        //// ------------------------------------------------

        //[BackingType(typeof(PropertyUrl))]

        //[Display(

        //    Name = "Link",

        //    Description = "",

        //    GroupName = SystemTabNames.Content,

        //    Order = 30)]

        //public virtual Url Link { get; set; }

        
        [UIHint(UIHint.Image)]
        [Display(
            Name = "PageImage",
            Description = "",
            GroupName = SystemTabNames.Content,
            Order = 40)]
        public virtual ContentReference PageImage { get; set; }





        //// ------------------------------------------------

        //// PropertyUrl (Document)

        //// ------------------------------------------------

        //[UIHint(UIHint.Document)]

        //[Display(

        //    Name = "File",

        //    Description = "",

        //    GroupName = SystemTabNames.Content,

        //    Order = 50)]

        //public virtual Url File { get; set; }





        //// ------------------------------------------------

        //// PropertyPageReference

        //// ------------------------------------------------

        //[Display(

        //    Name = "Sitemap page",

        //    Description = "",

        //    GroupName = SystemTabNames.Content,

        //    Order = 55)]

        //public virtual PageReference SitemapPageLink { get; set; }





        //// ------------------------------------------------

        //// PropertyLinkCollection

        //// ------------------------------------------------

        //[Display(

        //    Name = "Links",

        //    Description = "",

        //    GroupName = SystemTabNames.Content,

        //    Order = 60)]

        //public virtual LinkItemCollection Links { get; set; }





        //// ------------------------------------------------

        //// PropertyContentArea

        //// ------------------------------------------------

        //[Display(

        //    Name = "Right block area",

        //    Description = "",

        //    GroupName = SystemTabNames.Content,

        //    Order = 70)]

        //public virtual ContentArea RightBlockArea { get; set; }





        // ------------------------------------------------

        // PropertyBoolean

        // ------------------------------------------------

        [Display(

            Name = "Show teaser",

            Description = "",

            GroupName = SystemTabNames.Content,

            Order = 80)]

        public virtual Boolean ShowTeaser { get; set; }





        //// ------------------------------------------------

        //// PropertyCategory

        //// ------------------------------------------------

        //[Display(

        //    Name = "Selected categories",

        //    Description = "",

        //    GroupName = SystemTabNames.Content,

        //    Order = 90)]

        //public virtual CategoryList SelectedCategories { get; set; }





        //// ------------------------------------------------

        //// PropertyDate

        //// ------------------------------------------------

        //[Display(

        //    Name = "Event start time",

        //    Description = "",

        //    GroupName = SystemTabNames.Content,

        //    Order = 100)]

        //public virtual DateTime EventStartTime { get; set; }





        // ------------------------------------------------

        // PropertyFloatNumber

        // ------------------------------------------------

        [Display(

            Name = "Price",

            Description = "",

            GroupName = SystemTabNames.Content,

            Order = 110)]

        public virtual Double Price { get; set; }





        // ------------------------------------------------

        // PropertyNumber

        // ------------------------------------------------

        [Display(

            Name = "Votes",

            Description = "",

            GroupName = SystemTabNames.Content,

            Order = 120)]

        public virtual Int32 Votes { get; set; }





        //// ------------------------------------------------

        //// PropertyPageType

        //// ------------------------------------------------

        //[Display(

        //    Name = "Filter for page type",

        //    Description = "",

        //    GroupName = SystemTabNames.Content,

        //    Order = 130)]

        //public virtual PageType FilterPageType { get; set; }





        // ------------------------------------------------

        // PropertyXForm

        // ------------------------------------------------

        [Display(

            Name = "Form",

            Description = "",

            GroupName = SystemTabNames.Content,

            Order = 140)]

        public virtual XForm Form { get; set; }





        // ------------------------------------------------

        // PropertyString

        // Only use if you really have to.

        // Use PropertyLongString instead with [StringLength(255)]

        // ------------------------------------------------

        //[BackingType(typeof(PropertyString))]

        //[Display(

        //    Name = "Short intro",

        //    Description = "",

        //    GroupName = SystemTabNames.Content,

        //    Order = 150)]

        //public virtual string ShortIntro { get; set; }    

               
    }
}