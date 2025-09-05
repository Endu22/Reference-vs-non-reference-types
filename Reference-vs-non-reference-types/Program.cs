using Reference_vs_non_reference_types;

Console.WriteLine("Reference vs non reference example!");

var pikachu = new Monster("Pikachu", 100);
var pikachuCopy = pikachu; // Same reference

pikachu.TakeDamage(30); // Pikachu health is now 70
pikachuCopy.TakeDamage(30); // Pikachu health are now 40

// Output of these are the same since the use the same reference.
Console.WriteLine("Health of {0} is now {1}", pikachu.Name, pikachu.Health);
Console.WriteLine("Health of {0} is now {1}", pikachuCopy.Name, pikachuCopy.Health);

var bulbasaur = new MonsterStruct("Bulbasaur", 100);
var bulbasaurCopy = bulbasaur; // COPY, Not the same reference!

bulbasaur.TakeDamage(10); // Bulbasaur health is now 90
bulbasaurCopy.TakeDamage(20); // bulbasaurCopy health is now 80

Console.WriteLine("Health of {0} is now {1}", bulbasaur.Name, bulbasaur.Health);
Console.WriteLine("Health of copied {0} is now {1}", bulbasaurCopy.Name, bulbasaurCopy.Health);