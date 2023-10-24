using TMPro;
using UnityEngine;


// This script glue a bunch of different things together
public class CompletedScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public GameObject player;

    private int score;

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            score = (int)Time.time;

            scoreText.text = "SCORE: " + score;
        }
    }
}
