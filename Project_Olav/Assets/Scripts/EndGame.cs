using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    private ScoringSystem scoring;
    public GameObject Score;
    public GameObject MoreFishUI;

    private void Awake()
    {
        scoring = Score.GetComponent<ScoringSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {

        if(scoring.score < 20)
        {
            MoreFishUI.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
            Debug.Log("GameEnd");
        }
        //SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        //Debug.Log("GameEnd");
    }
}
