using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour

{
    public int coins = 0; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            coins++;
            print("We have " + coins + "  coins");
            Destroy(gameObject);
        }
    }


}
