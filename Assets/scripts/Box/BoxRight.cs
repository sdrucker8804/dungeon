using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxRight : MonoBehaviour
{
    BoxScript Box;
    public bool IsCollidingRight = false;
    public bool RightPlayerStop = false;
    // Start is called before the first frame update
    void Start()
    {
        Box = FindObjectOfType<BoxScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsCollidingRight == true && Input.GetKeyDown(KeyCode.LeftArrow) & Box.leftBox == true)
        {
            if (GameObject.FindGameObjectWithTag("Player").GetComponent<movement>().moving) return;
            Box.transform.Translate(-2f, 0, 0);
        }
        
        if (IsCollidingRight == true && Box.leftBox == false)
        {
            RightPlayerStop = true;
        }
        else
        {
            RightPlayerStop = false;
        }
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IsCollidingRight = true;
            
        }
        
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        IsCollidingRight = false;
    }


}