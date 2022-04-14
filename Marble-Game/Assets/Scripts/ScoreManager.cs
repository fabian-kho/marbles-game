using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    [SerializeField] CharacterStats stats; //Scriptableobject
    public Text ScoreText;
    public Text HighScoreText;
    int score = 0;
    int highscore = 0;
    private void Awake(){
        
        instance= this; //set instance of this Manager.
        stats.Load();   //Loads Highscore from Json File
    }


    // Start is called before the first frame update
    void Start()
    {
        score = stats.GetScore();
        ScoreText.text = score.ToString() + " Points";
        highscore = stats.GetHighScore();
        HighScoreText.text = "Highscore: " + highscore.ToString();
        
    }

    //Adds Point and sets a new Highscore if score is larger then Highscore
    public void AddPoint(){

        score +=1;
        ScoreText.text = score.ToString() + " Points";
        stats.SetScore(score);
        stats.Save();
        if(highscore<score){
            stats.SetHighScore(score);  //Set new Highscore.
            HighScoreText.text = "Highscore: " + highscore.ToString();
            stats.SetScore(0);
            stats.Save();               //save new Highscore in Json-File
        }
    }
}