using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class InitObstableMarker : MonoBehaviour
{
    private List<Object> textures = new List<Object>();
    private List<GameObject> obstables = new List<GameObject>();
    void Start()
    {
        textures.AddRange(Resources.LoadAll("Textures/Obstacle Vision Markers", typeof(Texture)));

        obstables.Add(GameObject.Find("B1"));
        obstables.Add(GameObject.Find("B2"));
        obstables.Add(GameObject.Find("B3"));
        obstables.Add(GameObject.Find("B4"));
        obstables.Add(GameObject.Find("B5"));
        obstables.Add(GameObject.Find("B6"));
        obstables.Add(GameObject.Find("B7"));
        obstables.Add(GameObject.Find("B8"));
        obstables.Add(GameObject.Find("B9"));

        // Init markers
        obstables.ForEach( obstable => {
            foreach (Transform marker in obstable.GetComponent<Transform>())
            {
                var index = Random.Range(0, textures.Count);
                marker.GetComponent<Renderer>().material.mainTexture = (Texture2D)(textures.ElementAt(index));
                textures.RemoveAt(index);
            }
        });
        Debug.Log("Assign markers Done");
    }
}
