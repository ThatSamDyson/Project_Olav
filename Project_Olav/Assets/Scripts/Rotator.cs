using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation = Vector3.one;
    
    void Update()
    {
        
        transform.Rotate(_rotation);
    }
}

