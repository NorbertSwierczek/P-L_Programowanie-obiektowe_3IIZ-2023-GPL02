using Lab3;

Person person1 = new Person("Andrzej", "Nowak", 32);
Person person2 = new Person("Zbyszek", "Mieszko", 19);

Book book1 = new Book("Tytul1", person1, "2004");
Book book2 = new Book("Tytul2", person2, "1901");
Book book3 = new Book("Tytul3", person2, "2001");

//person1.View();
//person2.View();

//book1.View();
////book2.View();

Reader reader1 = new Reader("Adam", "Nowak", 66, [book1, book2]);
Reader reader2 = new Reader("Aleksander", "Brown", 45, [book2, book3]);

//reader1.ViewBook();
//reader2.ViewBook();

//reader1.View();
//reader2.View();

Person o = new Reader("Natalia", "Kozioł", 25, [book1, book3]);
//o.View();

Reviewer reviewer1 = new Reviewer("Mieczysław", "Nowak", 55, [book1, book3]);
Reviewer reviewer2 = new Reviewer("Adam", "Polak", 39, [book2]);
//reviewer1.View();
//reviewer2.View();

//List<Person> people = new List<Person>([reader1, reader2, reviewer1, reviewer2]);
//foreach (Person person in people)
//{
//    person.View();
//}

