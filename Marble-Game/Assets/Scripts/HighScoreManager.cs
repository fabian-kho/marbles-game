 using System.IO;
 using UnityEngine;
 
 [CreateAssetMenu(menuName = "ScriptableObjects/HighScoreManager", order = 1)]
 public class HighScoreManager : ScriptableObject
 {
     private string filePath;
 
     [SerializeField]
     private string fileName = "highScores" ;
     
     [SerializeField]
     public int highScore = 0;
 
     private string FilePath
     {
         get
         {
             if ( string.IsNullOrEmpty( filePath ) )
                 filePath = Path.Combine( Application.persistentDataPath, fileName );
             return filePath;
         }
     } 
     public void Save()
     {
         File.WriteAllText( FilePath, JsonUtility.ToJson( this ) );
     }
 
     public void Load()
     {
         string path = Path.Combine( Application.persistentDataPath, "highScores" );
 
         if ( File.Exists( FilePath ) )
         {
             JsonUtility.FromJsonOverwrite( File.ReadAllText( FilePath ), this );
         }
     }
 }