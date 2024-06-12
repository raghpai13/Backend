using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Model
{
    public class CatMapUser
    {
        [Key]
        public int Id { get; set; }
        public User User { get; set; }
        public Category Category { get; set; }
    }
}
