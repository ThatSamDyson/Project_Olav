using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class s_CollectFish : MonoBehaviour
{
    public AudioSource collectSound;
    private ScoringSystem scoring;
    public GameObject Score;

    private void Awake()
    {
        scoring = Score.GetComponent<ScoringSystem>();
    }

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        scoring.score += 50;
        Destroy(gameObject);
    }
}
