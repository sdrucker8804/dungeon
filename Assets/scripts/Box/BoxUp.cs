using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxUp : MonoBehaviour
{
    BoxScript Box;
    public bool IsCollidingUp = false;
    public bool UpPlayerStop = false;
    // Start is called before the first frame update
    void Start()
    {
        Box = FindObjectOfType<BoxScript>();
    }

    // Update is called once per frame
    void Update()
    {
         if(IsCollidingUp == true && Input.GetKeyDown(KeyCode.DownArrow) & Box.downBox == true)
        {
            if (GameObject.FindGameObjectWithTag("Player").GetComponent<movement>().moving) return;
            Box.transform.Translate(0, -2f, 0);
        }
        if (IsCollidingUp == true && Box.downBox == false)
        {
            UpPlayerStop = true; 
        }
        else
        {
            UpPlayerStop = false;
        }
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IsCollidingUp = true;

        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        IsCollidingUp = false;
    }

}