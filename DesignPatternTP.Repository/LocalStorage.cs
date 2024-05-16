using DesignPatternTP.Models;
using DesignPatternTP.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTP.Repository
{
    public class LocalStorage : IStorage
    {
        private static LocalStorage instance = null;
        private LocalStorage() { }
        public static LocalStorage Instance {
            get { 
                if (instance == null)
                {
                    instance = new LocalStorage();
                }
                return instance;
            } 
        }

        public List<Employee> Employees { get; set; } = new List<Employee>(
            [
            new Employee() {ID = "1", FirstName = "David", LastName = "Wallace", Salary = 5310,},
            new Employee() {ID = "2", FirstName = "Jan", LastName = "Levinson", Salary = 3900,},
            new Employee() {ID = "3", FirstName = "Dwight", LastName = "Shrute", Salary = 1850,},
            new Employee() {ID = "4", FirstName = "Jim", LastName = "Halpert", Salary = 1850,},
            new Employee() {ID = "5", FirstName = "Michael", LastName = "Scott", Salary = 2560,},
            new Employee() {ID = "6", FirstName = "Meredith", LastName = "Palmer", Salary = 1650,},
            new Employee() {ID = "7", FirstName = "Pam", LastName = "Beesly", Salary = 1500,},
            new Employee() {ID = "8", FirstName = "Kevin", LastName = "Malone", Salary = 1590,},
            new Employee() {ID = "9", FirstName = "Kelly", LastName = "Kapoor", Salary = 1450,},
            new Employee() {ID = "10", FirstName = "Angela", LastName = "Martin", Salary = 1700,},
        ]
        );
    }
}
