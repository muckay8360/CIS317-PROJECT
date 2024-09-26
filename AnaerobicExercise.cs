/*******************************************************************
* Name: Mucahit Kaya
* Date: 9/21/2024
* Assignment: CIS317 PROJECT Exercise Calculator
*
* AnaerobicExercise class inheriting abstract class Exercise 
* Methods are AerobicExercise to initialize class, calculatecalories,
* and to String method to print string representation.
*/

public class AnaerobicExercise : Exercise
{
        public AnaerobicExercise(int id, float time, string exerciseName, float weight) :
    base(id, time, exerciseName, weight) {}
    public AnaerobicExercise(float time, string exerciseName, float weight) :
    base(time, exerciseName, weight) {}

    public override float CalculateCalories()
    {
        return 0.045f *  Weight * Time;
    }
    public override string ToString()
    {
        return base.ToString();
    }
}
