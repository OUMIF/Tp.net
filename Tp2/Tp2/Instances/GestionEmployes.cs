using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class GestionEmployes
    {

        private List<Employee> employees;
        private static int nombreEmployee;
        static private float sommeSalaire;


        public GestionEmployes(List<Employee> employees)
        {
            this.employees = employees;
            nombreEmployee = 0;
            sommeSalaire = 0;
        }

        public bool Ajouter(Employee employee)
        {
            foreach (Employee emp in employees)
            {
                if (emp.Nom.Equals(employee.Nom))
                {
                    return false;
                }
            }
            employees.Add(employee);
            sommeSalaire += employee.Salaire;
            nombreEmployee++;
            return true;

        }

        
        public bool supprimer(Employee employee)
        {

            foreach (Employee emp in employees)
            {
                if (emp.Nom.Equals(employee.Nom))
                {
                    nombreEmployee--;
                    sommeSalaire -= emp.Salaire;    
                    employees.Remove(emp);
                    return true;
                }  
            }
            return false;
        }

        
        static public float calculerSalaireMoyen()
        {
            return sommeSalaire/nombreEmployee;
        }



        public static int NombreEmployee { get => nombreEmployee; set => nombreEmployee = value; }
        internal List<Employee> Employees { get => employees; set => employees = value; }
        public static float SommeSalaire { get => sommeSalaire; set => sommeSalaire = value; }
    }
}
