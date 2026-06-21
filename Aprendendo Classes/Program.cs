Random dice = new Random();
int roll0 = dice.Next(int.Parse(Console.ReadLine()));//gera um numero aleatorio entre 0 e o valor digitado pelo usuario.
int roll1 = dice.Next();//gera um numero aleatorio entre 0 e o valor maximo de um inteiro.
int roll2 = dice.Next(101);//gera um numero aleatorio entre 0 e 100.
int roll3 = dice.Next(50, 101);//gera um numero aleatorio entre 50 e 100.

Console.WriteLine($"First roll: {roll0}");
Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
//entendendo o que é uma classe, metodo e objeto.