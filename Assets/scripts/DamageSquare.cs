using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSquare : MonoBehaviour
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            movementScript.health = movementScript.health - 20;
            print("Health reamaining = " + movementScript.health);

        }
}
}