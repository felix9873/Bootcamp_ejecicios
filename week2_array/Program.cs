



double[] grades = new double[10];


AddGrades(grades);

DisplayGrades(grades);

AvegareGrades(grades);

ApprovedStudent(grades);

FindMaxAndMinGrade(grades);

RangeGrades(grades);



void AddGrades(double[] grades)
{
    
   

    for (int i = 0; i < grades.Length; i++)
    {
        bool isValid = false;
       

        while(!isValid)
        {
            Console.WriteLine();
            Console.Write("ingresa las notas de los estudiantes: ");
            double inputGrades = Convert.ToDouble(Console.ReadLine());
           
          

            if (inputGrades >= 0 && inputGrades <= 100)
            {
                grades[i] = inputGrades;
                isValid = true;

            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("la notas tienen que tener un valor entre 0 y 100");
               
            }
        }
        

       
    }
    Console.WriteLine();
}

void DisplayGrades(double[] grades)
{
    for (int i = 0; i < grades.Length; i++)
    {
        Console.WriteLine($"student {i + 1} grades: {grades[i]} ");
    }
    Console.WriteLine();
}


void AvegareGrades(double[] grades)
{
    double sum = 0;
    double avegare = 0;

    for (int i = 0; i < grades.Length; i++)
    {
        sum += grades[i];
        avegare = sum / grades.Length;

    }
    Console.WriteLine($"avegare grades {avegare}");
}

void ApprovedStudent(double[] grades)
{
    int studentApproved = 0;

    for (int i = 0; i < grades.Length; i++)
    {
        if (grades[i] >= 60)
        {
            studentApproved++;
        }
    }

    Console.WriteLine($"nro de studiantes aprobaron {studentApproved}");
}

void FindMaxAndMinGrade(double[] grades)
{
    double max = grades[0];
    double min = grades[0];

    foreach (double grade in grades) 
    { 
        if(grade > max)
        {
            max = grade;
        }
        if (grade < min) 
        { 
            min = grade;
        }

    }

    Console.WriteLine($"la nota mas alta es: {max} y la nota minima es: {min}");
}

void RangeGrades(double[] grades)
{
    int[] range = new int[5];

    foreach (double grade in grades)
    {
        if (grade < 60)
        {
            range[0]++;
        }
        else if (grade < 70)
        {
            range[1]++;
        }
        else if (grade < 80)
        {
            range[2]++;
        }
        else if (grade < 90)
        {
            range[3]++;
        }
        else
        {
            range[4]++;
        }

        Console.WriteLine("Distribución por rangos:");
        Console.WriteLine($"- Reprobado (0-59): {range[0]} estudiantes");
        Console.WriteLine($"- Suficiente (60-69): {range[1]} estudiantes");
        Console.WriteLine($"- Bien (70-79): {range[2]} estudiantes");
        Console.WriteLine($"- Notable (80-89): {range[3]} estudiantes");
        Console.WriteLine($"- Excelente (90-100): {range[4]} estudiantes");

        Console.WriteLine("\nGráfica de distribución:");
        string[] etiquetas = { "Reprobado", "Suficiente", "Bien    ", "Notable ", "Excelente" };

        for (int i = 0; i < range.Length; i++)
        {
            Console.Write($"{etiquetas[i]}: ");
            for (int j = 0; j < range[i]; j++)
            {
                Console.Write("■ ");
            }
            Console.WriteLine($" ({range[i]})");
        }
    }
}