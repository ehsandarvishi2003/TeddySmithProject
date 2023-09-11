using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace TeddySmithProject.Models
{
    public class Address
    {
        [Key]
        public int Id { set; get; }
        public string Street { set; get; }
        public string City { set; get; }
        public string State { set; get; }   
    }
}
