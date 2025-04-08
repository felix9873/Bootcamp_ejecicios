
/*
Console.WriteLine("encontrar el mayor numero");

Console.WriteLine("ingresa 3 numeros");

Console.Write("ingresa el primer numero: ");

int num1 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine();

Console.Write("ingresa el segundo numero: ");
int num2 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine();

Console.Write("ingresa el tercer numero: ");
int num3 = Convert.ToInt16(Console.ReadLine());
int largestNumer ;

if(num1 < num2)
{
    largestNumer = num2;

    if(num2 < num3)
    {
        largestNumer = num3;
        Console.WriteLine($" el mayor numero{largestNumer}");
    }
    else
    {

        Console.WriteLine($" el mayor numero{largestNumer}");
    }
    
}
else
{
    if(num1 > num3)
    {
        largestNumer = num1;
        Console.WriteLine($" el mayor numero{largestNumer}");
    }
    else
    {
        largestNumer = num3;
        Console.WriteLine($" el mayor numero{largestNumer}");
    }
}


Console.WriteLine("calcular el area ");



string inputUser = Console.ReadLine();

switch(inputUser)
{
    case "cuadrado":
        Console.WriteLine("ingresa los lados del cuadrado");

        Console.Write("ingresa el primer lado");
        float input = Convert.ToSingle( Console.ReadLine());
        Console.WriteLine();

        Console.Write("ingresa el segundo lado");
        float input2 = Convert.ToSingle(Console.ReadLine());

        float areaSquare = input * input2;

        Console.WriteLine($"el area del cuadrado es {areaSquare}");

        break;

    case "circulo":
        Console.WriteLine("ingresa el radio del circulo");

        float radius = Convert.ToSingle(Console.ReadLine());
        
        double area = Math.PI * (radius * radius);

        Console.WriteLine($"el area del circulo es {area}");

        break;

    case "rectangulo":

        Console.WriteLine("ingresa la base y la altura del rectangulo");

        Console.Write("ingresa la base del rectangulo");

        float baseRectangle = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("ingresa la altura del rectangulo");

        float height = Convert.ToSingle(Console.ReadLine());

        float areaRectagle = baseRectangle * height;

        Console.WriteLine($"el area del rectangulo {areaRectagle}");



        break;
        
}

*/

// imprimir cuadadro con patronde del 1 al 5

int number = 890;

int c = number / 100;
int d = (number / 10) % 10;
int u = number % 10;

Console.WriteLine("centenas " + c);
Console.WriteLine("decenas " + d);
Console.WriteLine("unidad " + u);
int inicio = 1;



while (inicio <= 5)
{


    int b = 1;
    int checkB = 1;
    int row = 1;

    int p = 1;

    while (b <= 5)
    {

        while (p <= b)
        {

            if (inicio == row && b > 0)
            {

                Console.Write("* ");


            }
            else
            {

                row++;
                Console.Write(b + " ");


            }


            p++;
        }

        b++;
    }


    Console.WriteLine();

    inicio++;

}

Console.Write("ingresa un numero: ");

int multiplicationTable = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= multiplicationTable; i++)
{
    int result = multiplicationTable * i;

    Console.WriteLine(result);
}

Console.WriteLine();

int value = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < value; i++)
{
    for (int j = 1; j < i; j++)
    {
        Console.Write(j + " ");


    }

    for (int k = 0; k < 2; k++)
    {
        if (i > 1) Console.Write("* ");

    }

    Console.WriteLine();
}

Console.WriteLine();

int start = 1;
int valuePattern = Convert.ToInt16(Console.ReadLine());

while (start < valuePattern)
{
    Console.WriteLine();

    int secondValue = 1;

    while (secondValue < start)
    {
        Console.Write(secondValue + " ");
        secondValue++;
    }
    start++;
}

