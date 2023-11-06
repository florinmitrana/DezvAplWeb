using Tema1;

Curs curs1 = new Curs("Algebra", "Miclaus");
Curs curs2 = new Curs("LFA", "Cheval");
Curs curs3 = new Curs("AlgLiniar", "Halanay");
Curs curs4 = new Curs("ASC", "Rusu");

Student student1 = new Student("N1", "p1", 18);
Student student2 = new Student("N2", "p2", 18);
Student student3 = new Student("N3", "p3", 18);
Student student4 = new Student("N4", "p4", 18);

List<Student> studenti = new List<Student>();
studenti.Add(student1);
studenti.Add(student2);
studenti.Add(student3);
studenti.Add(student4);

student1.addCurs(curs1);
student2.addCurs(curs2);
student3.addCurs(curs3);
student4.addCurs(curs4);


foreach (Student student in studenti)
{
    student.afiseazaDetalii();
}
