using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorScript : MonoBehaviour
{
    private GameObject detector;
    // Start is called before the first frame update
    void Start()
    {
        detector = GameObject.Find("Detector");
    }
    
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            detector.GetComponent<Renderer>().material.color = Color.red;
    }

}
