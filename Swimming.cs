/*******************************************************************
* Name: Mucahit Kaya
* Date: 9/21/2024
* Assignment: CIS317 PROJECT Exercise Calculator
*
* Swimming class inheriting class AnaerobicExercise 
* Initialzie Swimming with 2 parameters , exercise name is static
*
*/

public class Swimming : AerobicExercise
{
    public Swimming(float time, float weight)
        : base(time, "Swimming", weight) {} 
     public override float CalculateCalories()
    {
        return 0.048f *  Weight * Time;
    }            
}