using System;

namespace CalorieCalculator.Models
{
    public class CalorieCalculatorModel
    {
        public double Weight { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public double ActivityLevel { get; set; }
        public double BMR { get; private set; }
        public double TDEE { get; private set; }

        public CalorieCalculatorModel()
        {
            Gender = "Male"; // Inicializado con un valor predeterminado
        }

        public void GetUserData()
        {
            Console.WriteLine("Enter your gender (Male/Female): ");
            Gender = Console.ReadLine();

            // Puedes agregar validación aquí para asegurarte de que el valor ingresado sea "Male" o "Female"
        }

        public void CalculateCalories()
        {
            if (Gender == "Male")
            {
                BMR = 88.362 + (13.397 * Weight) + (4.799 * Height) - (5.677 * Age);
            }
            else
            {
                BMR = 447.593 + (9.247 * Weight) + (3.098 * Height) - (4.330 * Age);
            }

            TDEE = BMR * ActivityLevel;
        }
    }
}

