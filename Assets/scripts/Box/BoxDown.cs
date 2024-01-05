using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDown : MonoBehaviour
{
    BoxScript Box;
    public bool IsCollidingDown = false;
    public bool DownPlayerStop = false;
    // Start is called before the first frame update
    void Start()
    {
        Box = FindObjectOfType<BoxScript>();
    }
    //if (GameObject.FindGameObjectWithTag("Player").GetComponent<movement>().moving) return;
    // Update is called once per frame
    void Update()
    {
        if (IsCollidingDown == true && Input.GetKeyDown(KeyCode.UpArrow) && Box.upBox == true)
        {
            if (GameObject.FindGameObjectWithTag("Player").GetComponent<movement>().moving) return;
            Box.transform.Translate(0, 2f, 0);
        }
        if (IsCollidingDown == true && Box.upBox == false)
        {
            DownPlayerStop = true;
        }
        else
        {
            DownPlayerStop = false;
        }
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IsCollidingDown = true;

        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        IsCollidingDown = false;
    }

}