// Solution for: https://open.kattis.com/problems/fizzbuzz

int x = int.Parse(args[0]);
int y = int.Parse(args[1]);
int n = int.Parse(args[2]);

for (int i = 1; i <= n; i++)
{
    string message = i % x == 0 && i % y == 0 ? "FizzBuzz" : i % x == 0 ? "Fizz" : i % y == 0 ? "Buzz" : i.ToString(); 
    Console.WriteLine(message);
}
