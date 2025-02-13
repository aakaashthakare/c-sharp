﻿// See https://aka.ms/new-console-template for more information



using Design_Patterns;


Console.WriteLine("Hello, World!");
FictionBook fictionBook1 = FictionBook.GetInstance<FictionBook>();
FictionBook fictionBook2 = FictionBook.GetInstance<FictionBook>();
NonFictionBook nonFictionBook1 = NonFictionBook.GetInstance<NonFictionBook>();
NonFictionBook nonFictionBook2 = NonFictionBook.GetInstance<NonFictionBook>();
if (fictionBook1 == fictionBook2 && nonFictionBook1 == nonFictionBook2)
{
    Console.WriteLine("Singeton is working.....");
}
fictionBook1.Say();
nonFictionBook1.Say();


Person person = new PersonBuilder()
    .WithFirstName("John")
    .WithLastName("Doe")
    .WithAge(30)
    .WithAddress("123 Main St.")
    .Build();

person.sayHello();

