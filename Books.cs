using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models.DBModels
{
    public class Books
    {
        [Key]
        public int book_id { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public string isbn { get; set; }
        public int publication_year { get; set; }
        public string category { get; set; }
        public int available_copies { get; set; }

    }
}
