using EntityLayer.Concrete.People;
using EntityLayer.Concrete.System;

namespace EntityLayer.Models
{
    public class PersonModel
    {
        public Person Person { get; set; }
        public SysUser SysUser { get; set; }
        public PersonCard PersonCard { get; set; }
        public List<PersonAddress> PersonAddresses { get; set; }
        public List<PersonEdu> PersonEdus { get; set; }
        public List<PersonPass> PersonPasses { get; set; }
        public List<PersonVisa> PersonVisas { get; set; }
        public List<PersonSocial> PersonSocials { get; set; }
        public List<PersonLeave> PersonLeaves { get; set; }
        public List<PersonDocument> PersonDocuments { get; set; }
        public List<SysPosition> SysPositions { get; set; }

        public PersonModel() 
        {
            Person = new Person();
            SysUser = new SysUser();
            PersonCard = new PersonCard();
            PersonAddresses = new List<PersonAddress>();
            PersonEdus = new List<PersonEdu>();
            PersonPasses = new List<PersonPass>();
            PersonVisas = new List<PersonVisa>();
            PersonSocials = new List<PersonSocial>();
            PersonLeaves = new List<PersonLeave>();
            PersonDocuments = new List<PersonDocument>();
            SysPositions = new List<SysPosition>();
        }
    }
}