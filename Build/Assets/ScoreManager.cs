using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text ScoreText, ErrorText;
    private int score;
    private List<string> CorrectCards;
    public AudioClip MusicClip;
    public AudioSource MusicSource;
    public AudioClip SuccessClip;
    public AudioSource SuccessSource;
    public AudioClip CongratsClip;
    public AudioSource CongratsSource;
    // Use this for initialization
    void Start()
    {
        score = 0;
        CorrectCards = new List<string>();
        MusicSource.clip = MusicClip;
        SuccessSource.clip = SuccessClip;
        CongratsSource.clip = CongratsClip;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Debug.Log("Touching");
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {

                Debug.Log(" you touched " + hit.collider.gameObject.name);
                if (hit.collider.gameObject.name == "Right_Cat")
                {
                    ErrorText.text = "";
                    Debug.Log("Correct");
                    SuccessSource.Play();
                    if (!CorrectCards.Contains("Cat"))
                    {
                        score++;
                        CorrectCards.Add("Cat");
                    }
                    Debug.Log(score);
                }
                else if (hit.collider.gameObject.name == "Wrong_Bear" || hit.collider.gameObject.name == "Wrong_Rabbit")
                {
                    ErrorText.text = "Try again.";
                    Debug.Log("Wrong");
                    MusicSource.Play();
                }

                if (hit.collider.gameObject.name == "Right_Bear")
                {
                    Debug.Log("Correct");
                    SuccessSource.Play();
                    ErrorText.text = "";

                    if (!CorrectCards.Contains("Bear"))
                    {
                        score++;
                        CorrectCards.Add("Bear");
                    }
                    Debug.Log(score);
                }
                else if (hit.collider.gameObject.name == "Wrong_Elephant" || hit.collider.gameObject.name == "Wrong_Cat")
                {
                    Debug.Log("Wrong");
                    ErrorText.text = "Try again.";
                    MusicSource.Play();
                }

                //Bear card
                if (hit.collider.gameObject.name == "Right_Bear")
                {
                    ErrorText.text = "";
                    Debug.Log("Correct");
                    SuccessSource.Play();

                    if (!CorrectCards.Contains("Bear"))
                    {
                        score++;
                        CorrectCards.Add("Bear");
                    }
                    Debug.Log(score);
                }
                else if (hit.collider.gameObject.name == "Wrong_Elephant" || hit.collider.gameObject.name == "Wrong_Cat")
                {
                    Debug.Log("Wrong");
                    ErrorText.text = "Try again.";
                    MusicSource.Play();
                }

                //Rabbit card
                if (hit.collider.gameObject.name == "Right_Rabbit")
                {
                    Debug.Log("Correct");
                    ErrorText.text = "";
                    SuccessSource.Play();

                    if (!CorrectCards.Contains("Rabbit"))
                    {
                        score++;
                        CorrectCards.Add("Rabbit");
                    }
                    Debug.Log(score);
                }
                else if (hit.collider.gameObject.name == "Wrong_Fish" || hit.collider.gameObject.name == "Wrong_Butterfly")
                {
                    Debug.Log("Wrong");
                    ErrorText.text = "Try again.";
                    MusicSource.Play();
                }

                //Fish card
                if (hit.collider.gameObject.name == "Right_Fish")
                {
                    Debug.Log("Correct");
                    ErrorText.text = "";
                    SuccessSource.Play();

                    if (!CorrectCards.Contains("Fish"))
                    {
                        score++;
                        CorrectCards.Add("Fish");
                    }
                    Debug.Log(score);
                }
                else if (hit.collider.gameObject.name == "Wrong_Rabbit" || hit.collider.gameObject.name == "Wrong_Cat")
                {
                    Debug.Log("Wrong");
                    ErrorText.text = "Try again.";
                    MusicSource.Play();
                }


                //Shark card
                if (hit.collider.gameObject.name == "Right_Shark")
                {
                    Debug.Log("Correct");
                    ErrorText.text = "";
                    SuccessSource.Play();

                    if (!CorrectCards.Contains("Shark"))
                    {
                        score++;
                        CorrectCards.Add("Shark");
                    }
                    Debug.Log(score);
                }
                else if (hit.collider.gameObject.name == "Wrong_Dolphin" || hit.collider.gameObject.name == "Wrong_Fish")
                {
                    Debug.Log("Wrong");
                    ErrorText.text = "Try again.";
                    MusicSource.Play();
                }

                //Dolphin card
                if (hit.collider.gameObject.name == "Right_Dolphin")
                {
                    Debug.Log("Correct");
                    ErrorText.text = "";
                    SuccessSource.Play();

                    if (!CorrectCards.Contains("Dolphin"))
                    {
                        score++;
                        CorrectCards.Add("Dolphin");
                    }
                    Debug.Log(score);
                }
                else if (hit.collider.gameObject.name == "Wrong_Whale" || hit.collider.gameObject.name == "Wrong_Shark")
                {
                    Debug.Log("Wrong");
                    ErrorText.text = "Try again.";
                    MusicSource.Play();
                }
                if (hit.collider.gameObject.name == "Right_Butterfly")
                {
                    Debug.Log("Correct");
                    ErrorText.text = "";
                    SuccessSource.Play();

                    if (!CorrectCards.Contains("Butterfly"))
                    {
                        score++;
                        CorrectCards.Add("Butterfly");
                    }
                    Debug.Log(score);
                }
                else if (hit.collider.gameObject.name == "Wrong_Fish" || hit.collider.gameObject.name == "Wrong_Penguin")
                {
                    Debug.Log("Wrong");
                    ErrorText.text = "Try again.";
                    MusicSource.Play();
                }
                //Whale card
                if (hit.collider.gameObject.name == "Right_Whale")
                {
                    Debug.Log("Correct");
                    ErrorText.text = "";
                    SuccessSource.Play();

                    if (!CorrectCards.Contains("Whale"))
                    {
                        score++;
                        CorrectCards.Add("Whale");
                    }
                    Debug.Log(score);
                }
                else if (hit.collider.gameObject.name == "Wrong_Bear" || hit.collider.gameObject.name == "Wrong_Penguin")
                {
                    Debug.Log("Wrong");
                    ErrorText.text = "Try again.";
                    MusicSource.Play();
                }

                //Penguin card
                if (hit.collider.gameObject.name == "Right_Penguin")
                {
                    Debug.Log("Correct");
                    ErrorText.text = "";
                    SuccessSource.Play();

                    if (!CorrectCards.Contains("Penguin"))
                    {
                        score++;
                        CorrectCards.Add("Penguin");
                    }
                    Debug.Log(score);
                }
                else if (hit.collider.gameObject.name == "Wrong_Rabbit" || hit.collider.gameObject.name == "Wrong_Dolphin")
                {
                    Debug.Log("Wrong");
                    ErrorText.text = "Try again.";
                    MusicSource.Play();

                }


            }
            ScoreText.text = score.ToString();

            ErrorText.color = Color.red;



            if (score == 9)
            {
                ErrorText.color = Color.yellow;
                ErrorText.text = "Congrats! You got all of them right!";
                CongratsSource.Play();
                Debug.Log("Congrats! You got all of them right!");
            }
        }


    }
}
