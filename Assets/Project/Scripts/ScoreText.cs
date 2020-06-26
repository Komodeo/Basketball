using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreText : MonoBehaviour
{

    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //display score on scoreboard
        if (ScoreArea.score < 10)
            {
            scoreText.text = ("00" + ScoreArea.score.ToString());
            }
        else
        {
            if (ScoreArea.score < 100)
            {
                scoreText.text = ("0" + ScoreArea.score.ToString());
            }
            else
            {
                scoreText.text = (ScoreArea.score.ToString());
            }
        }
    }
}
