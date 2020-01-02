using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionColorChange : MonoBehaviour 
{
    public Color redcolor;
    public Color blackcolor;
    
    void Start()
     
    {

    }
    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Player")){
            transform.GetComponent<Renderer>().material.color = redcolor;
        }
    }
    void OnTriggerExit(Collider other){
        if (other.gameObject.CompareTag("Player")){
            transform.GetComponent<Renderer>().material.color = blackcolor;
        }
    }
}
