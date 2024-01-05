 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottonScript : MonoBehaviour
{
    Door doorScript;
    Botton Botton;
    public bool IsPressed = false;
    
    // Start is called before the first frame update
    void Start()
    {
        Botton= FindObjectOfType<Botton>();
        doorScript = FindObjectOfType<Door>();
    }

    // Update is called once per frame
    void Update()
    {
       doorScript.BottonIsPressed = IsPressed;
      
    }
    void OnTriggerEnter2D(Collider2D collision)
       
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Box"))
        {

            IsPressed = true;
            Botton.gameObject.transform.position = new Vector3(1000, 1000, 0);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Box"))
        {
            IsPressed = false;
            Botton.gameObject.transform.position = new Vector3(13.9503f, 14.1532f, 0);
        }
    }
}
