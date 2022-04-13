using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text ScoreText;
    public Text HighScoreText;
    int score = 0;
    int highscore = 0;

    private void Awake(){
        //set instance of this Manager.
        instance= this;
    }


    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = score.ToString() + "Points";
        highscore = PlayerPrefs.GetInt("highscore", 0);
        HighScoreText.text = "Highscore: " + highscore.ToString();
    }

    public void AddPoint(){

        score +=1;
        ScoreText.text = "Score: " + score.ToString();
        if(highscore<score)
        PlayerPrefs.SetInt("highscore", score);
    }
}
