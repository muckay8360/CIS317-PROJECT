/*******************************************************************
* Name: Mucahit Kaya
* Date: 9/21/2024
* Assignment: CIS317 PROJECT Exercise Calculator
*
* Hiking class inheriting class Aerobic 
* Initialzie Hiking with 2 parameters , exercise name is static
*
*/

public class Hiking : AerobicExercise
{
    public Hiking(float time, float weight)
        : base(time, "Hiking", weight) {} 
     public override float CalculateCalories()
    {
        return 0.045f *  Weight * Time;
    }       
}
