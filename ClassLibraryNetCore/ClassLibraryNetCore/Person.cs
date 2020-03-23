using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibraryNetCore
{
    public partial class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        
        public string MiddleName { get; set; }
        
        public string LastName { get; set; }
        
        public string TelephonNumber { get; set; }


        private Person()
        {
            // EF
        }

        public static Person Create(int id, string firstName, string middleName, string lastName, string telephonNumber)
        {
            return new Person
            {
                Id = id,
                FirstName = firstName,
                MiddleName = middleName,
                LastName = lastName,
                TelephonNumber = telephonNumber
            };
        }
    }
}
