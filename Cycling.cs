/*******************************************************************
* Name: Mucahit Kaya
* Date: 9/21/2024
* Assignment: CIS317 PROJECT Exercise Calculator
*
* Cycling class inheriting class Aerobic 
* Initialzie Cycling with 2 parameters , exercise name is static
*
*/

public class Cycling : AerobicExercise
{
    public Cycling(float time, float weight)
        : base(time, "Cycling", weight) {} 
    public override float CalculateCalories()
    {
        return 0.08f *  Weight * Time;
    }     
}
