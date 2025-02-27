using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Employee emp1 = new Employee("Alice", 3000f, "Développeur", "01/01/2020");
        Employee emp2 = new Employee("Bob", 3500f, "Analyste", "01/03/2021");
        Employee emp3 = new Employee("Charlie", 4000f, "Manager", "01/06/2022");

        List<Employee> employees = new List<Employee> { emp1, emp2, emp3 };

        GestionEmployes gestion = new GestionEmployes(employees);

        Directeur directeur = new Directeur(gestion);

        Console.WriteLine("Salaire total : " + directeur.afficherSalaireTotal());
        Console.WriteLine("Salaire moyen : " + directeur.afficherSalaireMoyen());

        Employee emp4 = new Employee("David", 3200f, "Testeur", "01/02/2023");
        if (gestion.Ajouter(emp4))
        {
            Console.WriteLine("Employé ajouté avec succès.");
        }
        else
        {
            Console.WriteLine("L'employé n'a pas pu être ajouté.");
        }

        Console.WriteLine("Salaire total après ajout : " + directeur.afficherSalaireTotal());

        if (gestion.supprimer(emp2))
        {
            Console.WriteLine("Employé supprimé avec succès.");
        }
        else
        {
            Console.WriteLine("L'employé n'a pas pu être supprimé.");
        }

        Console.WriteLine("Salaire total après suppression : " + directeur.afficherSalaireTotal());
        Console.WriteLine("Salaire moyen après suppression : " + directeur.afficherSalaireMoyen());

        Console.ReadKey();
    }
}
