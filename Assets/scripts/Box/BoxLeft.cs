using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxLeft : MonoBehaviour
{
    BoxScript Box;
    public bool IsCollidingLeft = false;
    public bool LeftPlayerStop = false;
    // Start is called before the first frame update
    void Start()
    {
        Box = FindObjectOfType<BoxScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsCollidingLeft == true && Input.GetKeyDown(KeyCode.RightArrow) & Box.rightBox == true)
        {
            if (GameObject.FindGameObjectWithTag("Player").GetComponent<movement>().moving) return;
            Box.transform.Translate(2f, 0, 0);
        }
       
        if (IsCollidingLeft == true && Box.rightBox == false)
        {
            LeftPlayerStop = true;
        }
        else
        {
            LeftPlayerStop = false;
        }
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IsCollidingLeft = true;

        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        IsCollidingLeft = false;
    }


}
