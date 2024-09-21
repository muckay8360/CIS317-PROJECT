/*******************************************************************
* Name: Mucahit Kaya
* Date: 9/21/2024
* Assignment: CIS317 PROJECT Exercise Calculator
*
* Database for data storage of Exercise List with methods to
* add and remove exercise to the list.
*
*/

public class ExerciseData
{
    private List<Exercise> exerciseList = new List<Exercise>();
    
    public void AddExercise(Exercise exercise){
        exerciseList.Add(exercise);
    }

    public List<Exercise> GetAllExercise(){
        return exerciseList;
    }
}