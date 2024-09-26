/*******************************************************************
* Name: Mucahit Kaya
* Date: 9/21/2024
* Assignment: CIS317 PROJECT Exercise Calculator
*
* Class to handle all interactions with the People table in the
* database, including creating the table if it doesn't exist and all
* CRUD (Create, Read Update, Delete) operations on the People table.
* Note that the interactions are all done using standard SQL syntax
* that is then executed by the SQLite library.
*/
using System.Data.SQLite;
public class ExerciseDb
{
public static void CreateTable(SQLiteConnection conn)
{
// SQL statement for creating a new table
string sql =
"CREATE TABLE IF NOT EXISTS Exercises (\n"
+ " ID integer PRIMARY KEY autoincrement\n"
+ " ,Time float\n"
+ " ,ExerciseName varchar(40)\n"
+ " ,Weight float);";
SQLiteCommand cmd = conn.CreateCommand();
cmd.CommandText = sql;
cmd.ExecuteNonQuery();
}
public static void AddExercise(SQLiteConnection conn, Exercise e)
{
string sql = string.Format(
"INSERT INTO Exercises(Time, ExerciseName, Weight) "
+ "VALUES('{0}','{1}',{2})",
e.Time, e.ExerciseName, e.Weight);
SQLiteCommand cmd = conn.CreateCommand();
cmd.CommandText = sql;
cmd.ExecuteNonQuery();
}
public static void UpdateExercise(SQLiteConnection conn, Exercise e)
{
string sql = string.Format(
"UPDATE Exercises SET Time='{0}', ExerciseName='{1}', Weight={2}"
+ " WHERE ID={3}", e.Time, e.ExerciseName, e.Weight, e.ID);
SQLiteCommand cmd = conn.CreateCommand();
cmd.CommandText = sql;
cmd.ExecuteNonQuery();
}
public static void DeleteExercise(SQLiteConnection conn, int id)
{
string sql = string.Format("DELETE from People WHERE ID = {0}", id);
SQLiteCommand cmd = conn.CreateCommand();
cmd.CommandText = sql;
cmd.ExecuteNonQuery();
}
public static List<Exercise> GetAllExercises(SQLiteConnection conn)
{

List<Exercise> exercises = new List<Exercise>();
string sql = "SELECT * FROM Exercises";
using (var command = new SQLiteCommand(sql, conn))
using (var rdr = command.ExecuteReader())


while (rdr.Read())
{
    string type = rdr["ExerciseName"].ToString();

    switch (type)
    {
        case "Cycling":    
            exercises.Add(new Cycling(
            rdr.GetInt32(0),
            rdr.GetFloat(1),
            rdr.GetFloat(3)           
        ));
        break;
        case "Hiking":    
            exercises.Add(new Hiking(
            rdr.GetInt32(0),
            rdr.GetFloat(1),
            rdr.GetFloat(3)
        ));  
        break;
        case "Rowing":    
            exercises.Add(new Rowing(
            rdr.GetInt32(0),
            rdr.GetFloat(1),
            rdr.GetFloat(3)
        ));
        break; 
        case "Swimming":    
            exercises.Add(new Swimming(
            rdr.GetInt32(0),
            rdr.GetFloat(1),
            rdr.GetFloat(3)
        ));
        break;  
        case "Walking":    
            exercises.Add(new Walking(
            rdr.GetInt32(0),
            rdr.GetFloat(1),
            rdr.GetFloat(3)
        ));
        break; 
        case "Weightlifting":    
            exercises.Add(new Walking(
            rdr.GetInt32(0),
            rdr.GetFloat(1),
            rdr.GetFloat(3)
        ));
        break;    

        default: 
        throw new Exception("Unknown exercise") ;                                
    }



}
return exercises;
}
public static Exercise GetExercise(SQLiteConnection conn, int id)
{
string sql = string.Format("SELECT * FROM Exercises WHERE ID = {0}", id);
using (var command = new SQLiteCommand(sql, conn))
using (var rdr = command.ExecuteReader())
if (rdr.Read())
{
   string type = rdr["ExerciseName"].ToString();
   
    switch (type)
    {
        case "Cycling":    
            return new Cycling(
            rdr.GetInt32(0),
            rdr.GetFloat(1),
            rdr.GetFloat(3)
        );
        break;
        case "Hiking":    
            return new Hiking(
            rdr.GetInt32(0),
            rdr.GetFloat(1),
            rdr.GetFloat(3)
        );
        break; 
        case "Rowing":    
            return new Rowing(
            rdr.GetInt32(0),
            rdr.GetFloat(1),
            rdr.GetFloat(3)
        );
        break; 
        case "Swimming":    
            return new Swimming(
            rdr.GetInt32(0),
            rdr.GetFloat(1),
            rdr.GetFloat(3)
         );
        break;
        case "Walking":    
           return new Walking(
            rdr.GetInt32(0),
            rdr.GetFloat(1),
              rdr.GetFloat(3)
        );
        break;
        case "Weightlifting":    
            return new Walking(
            rdr.GetInt32(0),
            rdr.GetFloat(1),
            rdr.GetFloat(3)
        );
        break;                                            
    }
    return new AerobicExercise(-1, -1, string.Empty, -1);
}
else
{
return new AerobicExercise(-1, -1, string.Empty, -1);
}
}
}