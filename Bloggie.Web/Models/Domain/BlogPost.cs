namespace Bloggie.Web.Models.Domain
{
    public class BlogPost
    {
        /*
         * A way to create a prop is prop then twice
         */

        public Guid Id { get; set; }
        public string Heading { get; set; }
        public string PageTitle { get; set; }
        public string Content { get; set; }
        public string ShortDescription { get; set; }
        public string FeaturedImageUrl { get; set; }
        public string UrlHandle{ get; set; }
        public DateTime PublishedDate { get; set; }
        public string Author { get; set; }
        public bool Visible { get; set; }

        //This will draw a relationship between blogposts and tags.
        public ICollection<Tag> Tags { get; set; }
    }
}
