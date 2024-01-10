namespace Bloggie.Web.Models.Domain
{
    public class Tag
    {

        /*
         * Name and DisplayName are two different properties.
         * They might look similar but they have a different purpose
         */

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }

        public ICollection<BlogPost> BlogPosts { get; set; }
    }
}
