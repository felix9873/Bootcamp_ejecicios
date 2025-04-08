



double[] grades = new double[10];


AddGrades(grades);

DisplayGrades(grades);

AvegareGrades(grades);


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