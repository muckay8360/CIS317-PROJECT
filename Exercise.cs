/*******************************************************************
* Name: Mucahit Kaya
* Date: 9/21/2024
* Assignment: CIS317 PROJECT Exercise Calculator
*
* Exercise class inheriting method CalculateCalories 
* has variables Time, ExerciseName, and Weight.
* Methods are Exercise to initialize class, calculatecalories,
* and to String method to print string representation.
*/

public abstract class Exercise : ICalorieCalculator
{
    public int ID { get;}
    public float Time { get; set; }
    public string ExerciseName { get; set; }
    public float Weight { get; set; }

    public Exercise( int id, float time, string exerciseName, float weight){
        ID = id;
        Time = time;
        ExerciseName = exerciseName;
        Weight = weight;
    }
    public Exercise( float time, string exerciseName, float weight){
        Time = time;
        ExerciseName = exerciseName;
        Weight = weight;
    }    

    public abstract float CalculateCalories();
    public override string ToString(){
        return string.Format("Exercise: {0}, Time: {1} minutes, Weight: {2} lbs, Calories Burned: {3}",
        ExerciseName, Time, Weight, CalculateCalories());
    }
}