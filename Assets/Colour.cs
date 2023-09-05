using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colour : MonoBehaviour
{
    Color32 colour;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().color = new Color(Random.Range(0f, 1f),
                                                         Random.Range(0f, 1f),
                                                         Random.Range(0f, 1f),
                                                         255);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
