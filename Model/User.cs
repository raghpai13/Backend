using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Model
{
    public class User
    {
        [Key]
        public string EmailID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password {  get; set; }
        public string Occupation {  get; set; }
        public int MonthlyIncome {  get; set; }
        public string Photo {  get; set; }
        public int Balance { get; set; }

    }
}
