using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cellwall : MonoBehaviour
{
    public bool upcell = true;
    public bool downcell = true;
    public bool rightcell = true;
    public bool leftcell = true;

    movement movementScript;
    BoxScript boxRestriction;
    //public Teleporter tp1;
    // public Teleporter tp2;
    // Start is called before the first frame update
    void Start()
    {
        movementScript = FindObjectOfType<movement>();
        boxRestriction = FindObjectOfType<BoxScript>();

        //tp1 = GameObject.Find("Teleporter1").GetComponent<Teleporter>();
        //tp2 = GameObject.Find("Teleporter2").GetComponent<Teleporter>();
    }

    // Update is called once per frame
    void Update()
    {


    }


    void OnTriggerEnter2D(Collider2D collision)
    { 

        if (collision.gameObject.CompareTag("Player"))
        {

           // print("Player");
            movementScript.up = true;
            movementScript.down = true;
            movementScript.right = true;
            movementScript.left = true;



            if (upcell == false)
            {
                movementScript.up = false;
            }

            if (downcell == false)
            {

                movementScript.down = false;
            }

            if (rightcell == false)
            {

                movementScript.right = false;
            }

            if (leftcell == false)
            {

                movementScript.left = false;
            }


        }


        if (collision.gameObject.CompareTag("Box"))
        {
            boxRestriction.upBox = true;
            boxRestriction.downBox = true;
            boxRestriction.rightBox = true;
            boxRestriction.leftBox = true;

            if (upcell == false)
            {
                boxRestriction.upBox = false;
            }

            if (downcell == false)
            {

                boxRestriction.downBox = false;
            }

            if (rightcell == false)
            {

                boxRestriction.rightBox = false;
            }

            if (leftcell == false)
            {

                boxRestriction.leftBox = false;
            }


        }
    }
}