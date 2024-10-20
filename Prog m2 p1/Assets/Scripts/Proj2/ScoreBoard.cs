using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreBoard : MonoBehaviour
{
    private TMP_Text ScoreNumber;
    private int ScoreNumberIndex;
    void Start()
    {
        ScoreNumber = GetComponent<TMP_Text>();
        PickUp.OnPickUp += addScore;
    }

    private void addScore()
    {
        ScoreNumberIndex += 50;
        ScoreNumber.text = "Score:" + ScoreNumberIndex;
    }
}
