using System.Collections.Generic;

namespace EstruturasArraysLists
{
    public class StudentModel
    {
        public StudentModel(int id, string FullName, string document, int Grade)
        {
            this.Id = id;
            this.FullName = FullName;
            this.Document = document;
            this.Grade = Grade;

            PhoneNumbers = new List<string> { "56465484", "54198498", "54198498" };
        }

        public int Id { get; set; }

        public string FullName { get; set; }

        public string Document { get; set; }

        public int Grade { get; set; }

        public List<string> PhoneNumbers { get; set; }
    }
}
