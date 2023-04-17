using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectBox : MonoBehaviour
{

    public GameObject Charge;
    private Charge detect;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void Awake()
    {
       detect = Charge.GetComponent<Charge>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
       

    }
}
