using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    private ScoringSystem scoring;
    public GameObject Score;
    [SerializeField] public int pointValue;


    private void Awake()
    {
        scoring = Score.GetComponent<ScoringSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Football"))
        {
            scoring.score += pointValue;
            Destroy (gameObject);
        }
    }
}
