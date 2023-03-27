using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeTexture : MonoBehaviour
{
    Color CanColour;

    void Start()
    {
        CanColour = Random.ColorHSV();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<SetTexture>().ChangeColour(CanColour);
            Destroy(gameObject);

            Debug.Log(other.gameObject);
        }

       
    }
}
