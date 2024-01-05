using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Teleporter teleLocation;
    public bool teleportOn = true;


    // Start is called before the first frame update
    void Start()
    {
        teleportOn = true;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
        { 
           teleportOn = true;
        }
    }       
    private void OnTriggerEnter2D(Collider2D collision)
    {
      
        if (teleportOn == true)
        {
            
            
            collision.gameObject.transform.position = teleLocation.transform.position;

            teleportOn = false;
            teleLocation.teleportOn = false;


        }
    }
}
