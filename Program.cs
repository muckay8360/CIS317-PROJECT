/*******************************************************************
* Name: Mucahit Kaya
* Date: 9/21/2024
* Assignment: CIS317 PROJECT Exercise Calculator
*
* Main Class application
*
*/
public class ExerciseCalculator
{
static void Main(string[] args)
{

Console.WriteLine("\nExercise Calculator\n");
 int input = 0;

while (input == 0) {
    float wght;
    Console.Write("Please input your current Weight:");
    wght = float.Parse(Console.ReadLine());
    
    float exercisetime;
    Console.Write("Please input your exercise time in minutes:");
    exercisetime = float.Parse(Console.ReadLine());

    
    float targetcalorie;
    Console.Write("Please input your target calorie loss:");
    targetcalorie = float.Parse(Console.ReadLine());
    ExerciseData exerciseData = new ExerciseData();
    ExerciseData QualifyingExercises = new ExerciseData();

    Exercise walking = new Walking(exercisetime, wght);
    Exercise hiking = new Hiking(exercisetime, wght);
    Exercise cycling = new Cycling(exercisetime, wght);
    Exercise rowing = new Rowing(exercisetime, wght);
    Exercise weightlifting = new Weightlifting(exercisetime, wght); 
    Exercise swimming = new Swimming(exercisetime, wght);       
    exerciseData.AddExercise(walking);
    exerciseData.AddExercise(hiking);
    exerciseData.AddExercise(cycling);
    exerciseData.AddExercise(rowing);
    exerciseData.AddExercise(weightlifting);
    exerciseData.AddExercise(swimming);
    var exercises = exerciseData.GetAllExercise();

    foreach (var exercise in exercises){
        if(exercise.CalculateCalories() >= targetcalorie){
            QualifyingExercises.AddExercise(exercise);
        }
    }
    var exerciselist = QualifyingExercises.GetAllExercise();

    Console.WriteLine("\nFollowing Exercises Meet Your Calorie Loss Target: \n");
    if(exerciselist.Count == 0){
        Console.WriteLine("\nUnfortunately None of the Exercises meet your criteria.");
    }
    else{
        foreach(var exercise in exerciselist){
            Console.WriteLine(exercise.ToString());
        }
    }
   Console.Write("\nType 0 for another calculation or Type any other number to quit: ");
    input = Convert.ToInt32(Console.ReadLine());
}
}
}
