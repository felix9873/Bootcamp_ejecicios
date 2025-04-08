



double[] grades = new double[10];

Console.WriteLine(grades[0]);

AddGrades(grades);
DisplayGrades(grades);

void AddGrades(double[] grades)
{
    
   

    for (int i = 0; i < grades.Length; i++)
    {
        bool isValid = false;
       

        while(!isValid)
        {
            Console.Write("ingresa las notas de los estudiantes: ");

            double inputGrades = Convert.ToDouble(Console.ReadLine());

            if (inputGrades >= 0 && inputGrades <= 100)
            {
                grades[i] = inputGrades;
                isValid = true;

            }
            else
            {
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
}
