using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models.DBModels
{
    public class Reservations
    {
        [Key]
        public int reservation_id { get; set; }
        public int book_id { get; set; }
        public int member_id { get; set; }
        public DateTime reservation_date { get; set; }
        [NotMapped]
        public List<Books> ListBook { get; set; }
        [NotMapped]
        public List<Members> ListMember { get; set; }
        [NotMapped]
        public string bookName { get; set; }
        [NotMapped]
        public string memberName { get; set; }

    }
}
