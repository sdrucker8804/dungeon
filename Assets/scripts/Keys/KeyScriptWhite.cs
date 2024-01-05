using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScriptWhite : MonoBehaviour
{
    movement movementScript;

    // Start is called before the first frame update
    void Start()
    {
        movementScript = FindObjectOfType<movement>();
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && movementScript.HasKey == 0)
        {
            gameObject.transform.position = new Vector3(-1000, -1000, 0);
            movementScript.HasKey = 1;
        }
    }

}