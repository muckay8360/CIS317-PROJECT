/*******************************************************************
* Name: Mucahit Kaya
* Date: 9/21/2024
* Assignment: CIS317 PROJECT Exercise Calculator
*
* AerobicExercise class inheriting abstract class Exercise 
* Methods are AerobicExercise to initialize class, calculatecalories,
* and to String method to print string representation.
*/

public class AerobicExercise : Exercise
{
    public AerobicExercise(float time, string exerciseName, float weight) :
    base(time, exerciseName, weight) {}

    public override float CalculateCalories()
    {
        return 0.0175f * 8 * Weight * (Time / 60);
    }
    public override string ToString()
    {
        return base.ToString();
    }
}

