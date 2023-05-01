using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeTexture : MonoBehaviour
{
    public AudioSource collectSound;
    [SerializeField]
    Color CanColour;

    Renderer renderer;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material.SetColor("_BaseColor", CanColour);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            collectSound.Play();
            other.gameObject.GetComponent<SetTexture>().ChangeColour(CanColour);
            Destroy(gameObject);

            Debug.Log(other.gameObject);
        }

       
    }
}
