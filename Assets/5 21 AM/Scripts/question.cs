using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class question : MonoBehaviour
{
    public questions[] Questions;
    public TextMeshProUGUI scoreTEXT;
    public TextMeshProUGUI lifeTEXT;
    private int score = 0;
    private float lives=10;
  

    private void Start()
    {
        for(int i = 0; i < 9; i++)
        {
            Questions[i].Question.SetActive(false);
            Questions[i].answered = false;
            
        }

        scoreTEXT.text = "SCORE: " + score.ToString();
        lifeTEXT.text = "LIVES: " + lives.ToString();
      
       
    }

    private void Update()
    {
        scoreTEXT.text = "SCORE: " + score.ToString();
        lifeTEXT.text = "LIVES: " + lives.ToString();
        if (score == 9)
        {
            Debug.Log("YOU WON");
            SceneManager.LoadScene(3);
        }

        if (lives <= 0)
        {
            Debug.Log("GameOver");
            SceneManager.LoadScene(2);
        }

        if (Input.GetKey(KeyCode.Return) && Cursor.lockState == CursorLockMode.None)
        {
            if (Questions[0].answer.text ==Questions[0].ANSWER   && !Questions[0].answered)
            {
                Debug.Log("correct");
                Questions[0].answered = true;
                score++;
                
            }
            if (Questions[0].answer.text != Questions[0].ANSWER  && Questions[0].ONTHIS)
            {
                Debug.Log("INCORRECT");

                lives--;

            }


            if (Questions[1].answer.text == Questions[1].ANSWER && !Questions[1].answered)
            {
                Debug.Log("correct");
                Questions[1].answered = true;
                score++;
            }
            if (Questions[1].answer.text != Questions[1].ANSWER  && Questions[1].ONTHIS)
            {
                Debug.Log("INCORRECT");

                lives--;

            }
            if (Questions[2].answer.text == Questions[2].ANSWER && !Questions[2].answered)
            {
                Debug.Log("correct");
                Questions[2].answered = true;
                score++;
            }
            if (Questions[2].answer.text != Questions[2].ANSWER  && Questions[2].ONTHIS)
            {
                Debug.Log("INCORRECT");

                lives--;

            }
            if (Questions[3].answer.text == Questions[3].ANSWER && !Questions[3].answered)
            {
                Debug.Log("correct");
                Questions[3].answered = true;
                score++;
            }
            if (Questions[3].answer.text != Questions[3].ANSWER  && Questions[3].ONTHIS)
            {
                Debug.Log("INCORRECT");
                lives--;

            }
            if (Questions[4].answer.text == Questions[4].ANSWER && !Questions[4].answered)
            {
                Debug.Log("correct");
                Questions[4].answered = true;
                score++;
            }
            if (Questions[4].answer.text != Questions[4].ANSWER  && Questions[4].ONTHIS)
            {
                Debug.Log("INCORRECT");

                lives--;

            }
            if (Questions[5].answer.text == Questions[5].ANSWER && !Questions[5].answered)
            {
                Debug.Log("correct");
                Questions[5].answered = true;
                score++;
            }
            if (Questions[5].answer.text != Questions[5].ANSWER  && Questions[5].ONTHIS)
            {
                Debug.Log("INCORRECT");

                lives--;

            }
            if (Questions[6].answer.text == Questions[6].ANSWER && !Questions[6].answered)
            {
                Debug.Log("correct");
                Questions[6].answered = true;
                score++;
            }
            if (Questions[6].answer.text != Questions[6].ANSWER  && Questions[6].ONTHIS)
            {
                Debug.Log("INCORRECT");

                lives--;

            }
            if (Questions[7].answer.text == Questions[7].ANSWER && !Questions[7].answered)
            {
                Debug.Log("correct");
                Questions[7].answered = true;
                score++;
            }
            if (Questions[7].answer.text != Questions[7].ANSWER  && Questions[7].ONTHIS)
            {
                Debug.Log("INCORRECT");

                lives--;

            }
            if (Questions[8].answer.text == Questions[8].ANSWER && !Questions[8].answered)
            {
                Debug.Log("correct");
                Questions[8].answered = true;
                score++;
            }
            if (Questions[8].answer.text != Questions[8].ANSWER  && Questions[8].ONTHIS)
            {
                Debug.Log("INCORRECT");

                lives--;

            }








        }//question tracker


       
       
    }


    private void OnTriggerEnter(Collider other)
    {
        for(int i=0; i<9; i++)
        {
            if (other.transform.gameObject == Questions[i].questionpoint)
            {
                Questions[i].Question.SetActive(true);
                Questions[i].ONTHIS = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }
      
    }

    private void OnTriggerExit(Collider other)
    {
        for (int i = 0; i < 9; i++)
        {
            if (other.transform.gameObject == Questions[i].questionpoint)
            {
                Questions[i].Question.SetActive(false);
                Questions[i].ONTHIS = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }

    }

}
