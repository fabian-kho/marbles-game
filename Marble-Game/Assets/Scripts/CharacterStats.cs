using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

[CreateAssetMenu]

public class CharacterStats : ScriptableObject
{
    [Header("Spieler Stats")]
    public int score = 0;
    public int initScore = 0;
    public int highScore = 0;
    public int initPoints = 1;
    public int health = 10;
    public int initHealth = 10;
    public int collisionCount = 0;
    public int initCollisionCount = 0;
    private string filePath;
     [SerializeField]
     private string fileName = "highScores" ;

    private void Awake()
    {
        Initialize();
    }

    private void OnEnable()
    {
        Initialize();
    }

    public void Initialize()
    {
        score = initScore;
        health = initHealth;
        collisionCount = initCollisionCount;
    }

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

     public int GetHighScore(){
         return highScore;
     }
     public int GetScore(){
        return score;
     }
     public void SetScore(int sCore=0){
        score = sCore;
     }
     public void SetHighScore(int score=0){
            highScore = score;
     }

}
