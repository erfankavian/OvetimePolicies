using System.ComponentModel.DataAnnotations;

namespace InformationPersonel.Models
{
    public class Person
    {
        //to inja mitonestam mahgdodiat bzaram vali nazashtam
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BasicSalary { get; set; }
        public int Allowance { get; set; }
        public int Transportation { get; set; }
        public DateTime Date { get; set; }



    }
}
