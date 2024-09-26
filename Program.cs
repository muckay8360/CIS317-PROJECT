/*******************************************************************
* Name: Mucahit Kaya
* Date: 9/21/2024
* Assignment: CIS317 PROJECT Exercise Calculator
*
* Main Class application
*
*/
using System.Data.SQLite;
public class ExerciseCalculator
{
static void Main(string[] args)
{
    const string dbExercise = "MucahitKaya.db";
SQLiteConnection conn = SQLiteDatabase.Connect(dbExercise);
if (conn != null)
{
ExerciseDb.CreateTable(conn);

Console.WriteLine("\nExercise Calculator\n");
int input = 0;
ExerciseData QualifyingExercises = new ExerciseData();
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
  

    Exercise walking = new Walking(exercisetime, wght);
    Exercise hiking = new Hiking(exercisetime, wght);
    Exercise cycling = new Cycling(exercisetime, wght);
    Exercise rowing = new Rowing(exercisetime, wght);
    Exercise weightlifting = new Weightlifting(exercisetime, wght); 
    Exercise swimming = new Swimming(exercisetime, wght);       
    ExerciseDb.AddExercise(conn, walking);
    ExerciseDb.AddExercise(conn, hiking);
    ExerciseDb.AddExercise(conn, cycling);
    ExerciseDb.AddExercise(conn, rowing);
    ExerciseDb.AddExercise(conn, weightlifting); 
    ExerciseDb.AddExercise(conn, swimming);                 
    
    foreach (Exercise e in ExerciseDb.GetAllExercises(conn))
    {
        if (e.CalculateCalories() >= targetcalorie)
        { 
            QualifyingExercises.AddExercise(e);
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

string delete = "DELETE FROM Exercises";
using(var command = new SQLiteCommand(delete, conn)){
    command.ExecuteNonQuery();
}
}


 
}

}