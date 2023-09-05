using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float rotateSpeed = -200f;
    float destroyDelay = 0.1f;
    Color defaultColor = new Color(1, 1, 1, 1);
    Color collectorColor;

    void Start()
    {
        collectorColor = GetComponent<SpriteRenderer>().color;
    }

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float rotation = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;

        transform.Translate(0, translation, 0);
        transform.Rotate(0, 0, rotation);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Colour")
        {
            Debug.Log("Colour");
            Destroy(other.gameObject, destroyDelay);

            Color otherColor = other.GetComponent<SpriteRenderer>().color;
            
            Debug.Log(collectorColor);
            collectorColor.r = (collectorColor.r + otherColor.r) / 2;
            collectorColor.g = (collectorColor.g + otherColor.g) / 2;
            collectorColor.b = (collectorColor.b + otherColor.b) / 2;
            Debug.Log(collectorColor);
        }
        else if(other.tag == "WaterContainer")
        {
            Debug.Log("WaterContainer");
            collectorColor = defaultColor;
        }

        GetComponent<SpriteRenderer>().color = collectorColor;
    }
}
