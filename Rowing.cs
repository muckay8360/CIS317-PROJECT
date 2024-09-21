/*******************************************************************
* Name: Mucahit Kaya
* Date: 9/21/2024
* Assignment: CIS317 PROJECT Exercise Calculator
*
* Rowing class inheriting class Aerobic 
* Initialzie Cycling with 2 parameters , exercise name is static
*
*/

public class Rowing : AerobicExercise
{
    public Rowing(float time, float weight)
        : base(time, "Rowing", weight) {} 
     public override float CalculateCalories()
    {
        return 0.0556f *  Weight * Time;
    }            
}