﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp2.Model
{
    public class Employee
    {
        public string ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string JobTitle { get; set; }
        public EmployeeImage Image { get; set; }
        public string Fullname
        {
            get
            {
                return Lastname + " " + Firstname;
            }
        }
    }
        /// <summary>
        /// Lisätään employee olioita käyttöliittymän kautta
        /// </summary>
        public class EmployeeViewModel
        {
            private ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
            public ObservableCollection<Employee> Employees { get { return employees; } }
            //konstruktori
            public EmployeeViewModel()
            {
                // generate dummy data if needed
            }

            //metodi lisää uuden employeen kokoelmaan
            public void AddEmployee(string firstname, string lastname, string jobTitle, EmployeeImage image)
            {
                //luodaan uusi employee
                string id = "0001"; //kaikilla sama ID
                employees.Add(new Employee { ID = id, Firstname = firstname, Lastname = lastname, JobTitle = jobTitle, Image = image });
            }

        }
    }