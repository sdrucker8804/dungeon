using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenerScript : MonoBehaviour
{
    public bool IsCollding = false;
    BottonScript Botton;
    movement MovementScript;
    // Start is called before the first frame update
    void Start()
    {
        Botton = FindObjectOfType<BottonScript>();
        MovementScript = FindObjectOfType<movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Botton.IsPressed && IsCollding)
        {
           // print("Open");
            MovementScript.up = true; 
        }
    }
    void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IsCollding = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IsCollding = false;
        }
    }
}
