/*******************************************************************
* Name: Mucahit Kaya
* Date: 9/21/2024
* Assignment: CIS317 PROJECT Exercise Calculator
*
* Weightlifting class inheriting class AnaerobicExercise 
* Initialzie Weightlifting with 2 parameters , exercise name is static
*
*/

public class Weightlifting : AerobicExercise
{
    public Weightlifting(float time, float weight)
        : base(time, "Weightlifting", weight) {} 
     public override float CalculateCalories()
    {
        return 0.0243f *  Weight * Time;
    }            
}