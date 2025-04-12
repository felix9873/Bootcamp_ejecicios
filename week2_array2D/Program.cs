



/*
Console.WriteLine("REGISTRO DE TEMPERATURAS SEMANALES");
Console.WriteLine("==================================\n");

Console.WriteLine("¿Desea introducir las temperaturas manualmente o generarlas aleatoriamente?");
Console.WriteLine("1. Introducir manualmente");
Console.WriteLine("2. Generar aleatoriamente");
Console.Write("Elija una opción (1-2): ");
Console.WriteLine();
Console.WriteLine();

double[,] temperaturas = new double[4, 7];


int opcion;
while (!int.TryParse(Console.ReadLine(), out opcion) || (opcion != 1 && opcion != 2))
{
    Console.Write("Por favor, introduzca 1 o 2: ");
}

if (opcion == 1)
{
    
    IntroducirTemperaturas(temperaturas);

    Console.WriteLine();

    MostrarTemperaturas(temperaturas);

    MediaSemana(temperaturas);
    MediaDias(temperaturas);
    
    Console.WriteLine();
    DiaCalorYfrio(temperaturas);
}
else
{
    GenerarTemperaturasAleatorias(temperaturas);

    Console.WriteLine();

    MostrarTemperaturas(temperaturas);

    MediaSemana(temperaturas);
    MediaDias(temperaturas);

    Console.WriteLine();
    DiaCalorYfrio(temperaturas);
}

void DiaCalorYfrio(double[,] temperaturas)
{
    double diaMasCaluloroso = temperaturas[0,0];
    double diaMasFrio = temperaturas[0, 0];

    string dayCaluroso = "";
    string dayFrio = "";

    string semanaCaluroso = "";
    string semanaFria = "";

    string[] week = {"semana 1", "semana 2", "semana 3"};

    string[] days = { "lunes", "martes", "miercoles" ,"jueves", "viernes" , "sabado", "domingo"};

    for (int i = 0; i < temperaturas.GetLength(0); i++)
    {
        
        for (int j = 0; j < temperaturas.GetLength(1); j++)
        {
            if (temperaturas[i,j] > diaMasCaluloroso)
            {
                
                dayCaluroso = days[j];

                semanaCaluroso = week[i];

                diaMasCaluloroso = temperaturas [i, j];
                
            }
            if (temperaturas[i,j] < diaMasFrio)
            {
                dayFrio = days[j];

                semanaFria = week[i];

                diaMasFrio = temperaturas[i,j];
            }
        }

    }
    Console.WriteLine($"dia mas caluroso °C {diaMasCaluloroso} dia {dayCaluroso} semana {semanaCaluroso}");
    Console.WriteLine($"dia mas frio °C {diaMasFrio} dia {dayFrio} semana {semanaFria}");
}

void MediaDias(double[,] temperaturas)
{

    double sum = 0;


    double[] daysMedia = new double[7];

    for (int i = 0; i < temperaturas.GetLength(0); i++)
    {

        for (int j = 0; j < temperaturas.GetLength(1); j++)
        {
            
           if(j == 0)
           {
                sum += temperaturas[i, j];
                daysMedia[0] = sum / temperaturas.GetLength(0);
           }
           else if (j == 1)
           {
                sum += temperaturas[i, j];
                daysMedia[1] = sum / temperaturas.GetLength(0);
            }
           else if (j == 2)
           {
                sum += temperaturas[i, j];
                daysMedia[2] = sum / temperaturas.GetLength(0);
            }
           else if (j == 3)
           {
                sum += temperaturas[i, j];
                daysMedia[3] = sum / temperaturas.GetLength(0);
            }
           else if (j == 4)
           {
                sum += temperaturas[i, j];
                daysMedia[4] = sum / temperaturas.GetLength(0);
            }
           else if (j == 5)
           {
                sum += temperaturas[i, j];
                daysMedia[5] = sum / temperaturas.GetLength(0);
            }
           else if (j == 6)
           {
                sum += temperaturas[i, j];
                daysMedia[6] = sum / temperaturas.GetLength(0);
            }

        }

        
    }
    Console.WriteLine();

    Console.WriteLine($"lunes media de temperatura °C {daysMedia[0]}");
    Console.WriteLine($"martes media de temperatura °C {daysMedia[1]}");
    Console.WriteLine($"miercoles media de temperatura °C {daysMedia[2]}");
    Console.WriteLine($"jueves media de temperatura °C {daysMedia[3]}");
    Console.WriteLine($"viernes media de temperatura °C {daysMedia[4]}");
    Console.WriteLine($"sabado media de temperatura  °C {daysMedia[5]}");
    Console.WriteLine($"domingo media de temperatura °C {daysMedia[0]}");
}

void MostrarTemperaturas(double[,] temperaturas)
{
    Console.WriteLine("                                       temperaturas                                             ");
    Console.WriteLine();
    Console.WriteLine("           lunes       martes      miercoles   jueves      viernes     sabados     domingo");
    Console.WriteLine();

    int week = 1;
    for (int i = 0; i < temperaturas.GetLength(0); i++)
    {

        Console.Write($"semana: {week}  ");
        week++;

        for (int j = 0; j < temperaturas.GetLength(1); j++)
        {


            if (temperaturas[i, j] >= 100 && temperaturas[i, j] >= 1000)
            {
                Console.Write($"|{temperaturas[i, j]}|      ");
            }
            else if(temperaturas[i, j] >= 100)
            {
                Console.Write($"|{temperaturas[i, j]}|       ");
            }
            else if (temperaturas[i, j] >= 10)
            {
                Console.Write($"|{temperaturas[i, j]}|        ");
            }
            else if (temperaturas[i, j] >= 0 && temperaturas[i, j] <= 10)
            {
                Console.Write($"|{temperaturas[i, j]}|         ");
            }
            else if (temperaturas[i, j] >= 10 && temperaturas[i, j] >= 1000)
            {
                Console.Write($"|{temperaturas[i, j]}|                   ");
            }
            else if (temperaturas[i, j] >= 10000)
            {
                Console.Write($"|{temperaturas[i, j]}|");
            }
            else
            {
                Console.Write($"|{temperaturas[i, j]}|        ");
            }
        }
        Console.WriteLine();

    }
    
}

void IntroducirTemperaturas(double[,] temperaturas)
{
    
    for (int i = 0; i < temperaturas.GetLength(0); i++)
    {
        
        for (int j = 0; j < temperaturas.GetLength(1); j++)
        {
            
            bool isValid = false;
            
            while (!isValid)
            {

                Console.Write("ingresa las temperaturas: ");
                double temperatura = Convert.ToDouble(Console.ReadLine());
                temperaturas[i,j] = temperatura;
               
                isValid = true;

            }

        }
        
    }
}

void GenerarTemperaturasAleatorias(double[,] temperaturas)
{

    for (int i = 0; i < temperaturas.GetLength(0); i++)
    {

        for (int j = 0; j < temperaturas.GetLength(1); j++)
        {
            Random r = new Random();
            temperaturas[i, j] =  r.Next(10, 36);
            
        }

    }
}

void MediaSemana(double[,] temperaturas)
{
    double sum = 0;
    

    double[] weekMedia = new double[4];
    for (int i = 0; i < temperaturas.GetLength(0); i++)
    {

        for (int j = 0; j < temperaturas.GetLength(1); j++)
        {
            if(i == 0)
            {
                sum += temperaturas[i, j];

                weekMedia[0] = sum / temperaturas.GetLength(1);
            }
            else if(i == 1)
            {
                sum += temperaturas[i, j];

                weekMedia[1] = sum / temperaturas.GetLength(1);
            }
            else if (i == 2)
            {
                sum += temperaturas[i, j];

                weekMedia[2] = sum / temperaturas.GetLength(1);
            }
            else if (i == 3)
            {
                sum += temperaturas[i, j];

                weekMedia[3] = sum / temperaturas.GetLength(1);
            }

            
        }
        

    }

    Console.WriteLine();

    Console.WriteLine("media de temperaturas semana 1: " + weekMedia[0]);
    Console.WriteLine("media de temperaturas semana 2: " + weekMedia[1]);
    Console.WriteLine("media de temperaturas semana 3: " + weekMedia[2]);
    Console.WriteLine("media de temperaturas semana 4: " + weekMedia[3]);
}

*/
/*

int i, j, filas;
Console.WriteLine("Ingresa el numero de filas");
filas = Convert.ToInt32(Console.ReadLine());

int spaces = filas;

for (i = 1; i <= filas; i++)
{
    for (int k = spaces; k > 0; k--)
    {
        Console.Write("-");  
    }
    spaces--;
    for (j = 1; j <= i; j++)
    {
        Console.Write("* ");
    }
    
    Console.Write("\n");
}


Console.WriteLine("Se acabo el bucle");
*/
/*
 * 1
 * 1 2
 * 1 2 3
 * 1 2 3 4
 */

int[] numbers = {2,7,11,15 };

int[] result =TwoSum(numbers, 26);

foreach (var item in result)
{
    Console.WriteLine(item);
}

int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> numToIndex = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        int complement = target - nums[i];

        Console.WriteLine("complement " + complement);

        if (numToIndex.ContainsKey(complement))
        {
            return new int[] { numToIndex[complement], i };
        }

        if (!numToIndex.ContainsKey(nums[i]))
        {
            numToIndex[nums[i]] = i;
        }
    }

    // In case there is no solution, which shouldn't happen as per the problem statement
    throw new ArgumentException("No two sum solution found.");
}
