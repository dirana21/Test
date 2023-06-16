using Test;

Human? person1 = Human.Create(
    "Dmytro",
    "Levchenko",
    new DateTime(1998,04,05),studentID:1245);
ConsolePrint.PrintInfo($"{person1}");
Console.ReadLine();