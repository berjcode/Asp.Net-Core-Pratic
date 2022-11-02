using MessagePack;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
namespace Turkcell.Models
{
    public class Profile
    {

        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string ProfilImage { get; set; }
        public string Password { get; set; }


    }

   
}
