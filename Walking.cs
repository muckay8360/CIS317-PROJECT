/*******************************************************************
* Name: Mucahit Kaya
* Date: 9/21/2024
* Assignment: CIS317 PROJECT Exercise Calculator
*
* Walking class inheriting class Aerobic 
* Initialzie Waling with 2 parameters , exercise name is static
*
*/

public class Walking : AerobicExercise
{
    public Walking(float time, float weight)
        : base(time, "Walking", weight) {}
   
     public override float CalculateCalories()
    {
        return 0.023f *  Weight * Time;
    }              
}
