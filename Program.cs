
// создать два делегата
// во второй делегат сложить сложение,
// вычитание и умножение.
// все осуществить через лямбда выражения


one f = () => { Console.WriteLine("helloy"); };
two t = (int a, int b) => 
{
    Console.WriteLine($"{a} + {b} = {a+b}");
};

t+= (int a, int b) =>
{
    Console.WriteLine($"{a} - {b} = {a - b}");
};


t(1, 2);





public delegate void one();
public delegate void two(int a, int b);