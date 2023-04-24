using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyRhino : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Rhino"))
        {
            Destroy(other.gameObject);
        }
    }
}
