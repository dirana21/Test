using Test;

Human? person1 = Human.Create(
    "Dmytro",
    "Levchenko",
    new DateTime(1998,04,05), null, 56423);
Sorter.SortClassInfo(person1);
Console.ReadLine();