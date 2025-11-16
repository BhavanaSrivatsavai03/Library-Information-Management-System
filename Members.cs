using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models.DBModels
{
    public class Members
    {
        [Key]
        public int member_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public DateTime join_date { get; set; }
        public string membership_status { get; set; }

    }
}
