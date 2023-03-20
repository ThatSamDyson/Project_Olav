using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public int score;


    void Update()
    {
        scoreText.GetComponent<TMPro.TextMeshProUGUI>().text = "FISH: " + score;
        
    }
}
