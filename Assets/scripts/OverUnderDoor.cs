using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverUnderDoor : MonoBehaviour
{
    public bool Over;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (Over == true)
            {
                collision.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 6;
            }
            else
            {
                collision.gameObject.GetComponent<SpriteRenderer>().sortingOrder = 4;
            }
        }
    }
}