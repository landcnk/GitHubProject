using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class QuizSceneManager : MonoBehaviour
{
    public Text scoreText;
    public Text questionText;
    public TMP_Text buttonText1;
    public TMP_Text buttonText2;

    public string question = "";
    public string answer1 = "";
    public string answer2 = "";

    public Text textSummary;

    [TextArea]
    public string[] textList = new string[3];

    public int correctAnswer = -1;
    static public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        questionText.text = question;
        buttonText1.text = answer1;
        buttonText2.text = answer2;
        OnSummaryScene();
    }

    public void OnButtonYesClick()
    {
        if (correctAnswer == 1)
        {
            score++;
            SceneManager.LoadScene(4);
        }
     
    }

    public void OnButton11YesClick()
    {
        if (correctAnswer == 1)
        {
            score++;
            SceneManager.LoadScene(15);
        }

    }

    public void OnButton11NoClick()
    {
        if (correctAnswer == 2)
            score++;
        else
        {
            SceneManager.LoadScene(15);
        }
    }

    public void OnButton10YesClick()
    {
        if (correctAnswer == 1)
        {
            score++;
            SceneManager.LoadScene(14);
        }

    }

    public void OnButton10NoClick()
    {
        if (correctAnswer == 2)
            score++;
        else
        {
            SceneManager.LoadScene(14);
        }
    }

    public void OnButton9YesClick()
    {
        if (correctAnswer == 1)
        {
            score++;
            SceneManager.LoadScene(13);
        }

    }

    public void OnButton9NoClick()
    {
        if (correctAnswer == 2)
            score++;
        else
        {
            SceneManager.LoadScene(13);
        }
    }

    public void OnButton8YesClick()
    {
        if (correctAnswer == 1)
        {
            score++;
            SceneManager.LoadScene(12);
        }

    }

    public void OnButton8NoClick()
    {
        if (correctAnswer == 2)
            score++;
        else
        {
            SceneManager.LoadScene(12);
        }
    }

    public void OnButton7YesClick()
    {
        if (correctAnswer == 1)
        {
            score++;
            SceneManager.LoadScene(11);
        }

    }

    public void OnButton7NoClick()
    {
        if (correctAnswer == 2)
            score++;
        else
        {
            SceneManager.LoadScene(11);
        }
    }

    public void OnButton6YesClick()
    {
        if (correctAnswer == 1)
        {
            score++;
            SceneManager.LoadScene(10);
        }

    }

    public void OnButton6NoClick()
    {
        if (correctAnswer == 2)
            score++;
        else
        {
            SceneManager.LoadScene(10);
        }
    }

    public void OnButton5YesClick()
    {
        if (correctAnswer == 1)
        {
            score++;
            SceneManager.LoadScene(9);
        }

    }

    public void OnButton5NoClick()
    {
        if (correctAnswer == 2)
            score++;
        else
        {
            SceneManager.LoadScene(9);
        }
    }
    public void OnButton4YesClick()
    {
        if (correctAnswer == 1)
        {
            score++;
            SceneManager.LoadScene(8);
        }

    }

    public void OnButton4NoClick()
    {
        if (correctAnswer == 2)
            score++;
        else
        {
            SceneManager.LoadScene(8);
        }
    }

    public void OnButton3YesClick()
    {
        if (correctAnswer == 1)
        {
            score++;
            SceneManager.LoadScene(7);
        }

    }

    public void OnButton3NoClick()
    {
        if (correctAnswer == 2)
            score++;
        else
        {
            SceneManager.LoadScene(7);
        }
    }

    public void OnButton2YesClick()
    {
        if (correctAnswer == 1)
        {
            score++;
            SceneManager.LoadScene(6);
        }

    }

    public void OnButton2NoClick()
    {
        if (correctAnswer == 2)
            score++;
        else
        {
            SceneManager.LoadScene(6);
        }
    }

    public void OnButton1YesClick()
    {
        if (correctAnswer == 1)
        {
            score++;
            SceneManager.LoadScene(5);
        }

    }

    public void OnButton1NoClick()
    {
        if (correctAnswer == 2)
            score++;
        else
        {
            SceneManager.LoadScene(5);
        }
    }

    public void OnButtonNoClick()
    {
        if (correctAnswer == 2)
            score++;
        else
        {
            SceneManager.LoadScene(4);
        }
    }

    public void OnSummaryScene()
    {
        if(score >= 9 && score <= 12)
        {
            textSummary.text = textList[0];
        }
        else if(score >= 5 && score <= 8)
        {
            textSummary.text = textList[1];
        }
        else if(score >= 0 && score <= 4)
        {
            textSummary.text = textList[2];
        }
    }
    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }
}
