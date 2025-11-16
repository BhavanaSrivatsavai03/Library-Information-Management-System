using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models.DBModels
{
    public class Loans
    {
        [Key]
        public int loan_id { get; set; }
        public int book_id { get; set; }
        public int member_id { get; set; }
        public DateTime loan_date { get; set; }
        public DateTime due_date { get; set; }
        public DateTime return_date { get; set; }
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
