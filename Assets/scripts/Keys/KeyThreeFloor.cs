using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyThreeFloor : MonoBehaviour
{
    movement movementScript;
    KeyScriptWhite WhiteKey;
    KeyGreenScript GreenKey;
    KeyRedScript RedKey;
    KeyYellowScript YellowKey;
    KeyBlueScript BlueKey;
    public GameObject KeyWhite;
    public GameObject KeyYellow;
    public GameObject KeyRed;
    public GameObject KeyBlue;
    public GameObject KeyGreen;
    public bool IsColliding = false;
    public int KeyNum = 0;
    // Start is called before the first frame update
    void Start()
    {
        movementScript = FindObjectOfType<movement>();
        WhiteKey = FindObjectOfType<KeyScriptWhite>();
        GreenKey = FindObjectOfType<KeyGreenScript>();
        RedKey = FindObjectOfType<KeyRedScript>();
        YellowKey = FindObjectOfType<KeyYellowScript>();
        BlueKey = FindObjectOfType<KeyBlueScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsColliding == true && Input.GetKeyDown(KeyCode.E))
        {

            if (KeyNum == 0)
            {
                if (movementScript.HasKey == 1)
                {
                    KeyNum = 1;
                    movementScript.HasKey = 0;
                    KeyWhite.transform.position = new Vector3(16, 89, 0);
                    //WhiteKey.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                }
                if (movementScript.HasKey == 2)
                {
                    KeyNum = 2;
                    movementScript.HasKey = 0;
                    KeyGreen.transform.position = new Vector3(16, 89, 0);
                    //GreenKey.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                }
                if (movementScript.HasKey == 3)
                {
                    KeyNum = 3;
                    movementScript.HasKey = 0;
                    KeyBlue.transform.position = new Vector3(16, 89, 0);
                   // BlueKey.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                }
                if (movementScript.HasKey == 4)
                {
                    KeyNum = 4;
                    movementScript.HasKey = 0;
                    KeyRed.transform.position = new Vector3(16, 89, 0);
                  //  RedKey.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                }
                if (movementScript.HasKey == 5)
                {
                    KeyNum = 5;
                    movementScript.HasKey = 0;
                    KeyYellow.transform.position = new Vector3(16, 89, 0);
                   // YellowKey.gameObject.GetComponent<SpriteRenderer>().enabled = false;
                }
            }
            else
            if (movementScript.HasKey == 0)
            {
                if (KeyNum == 1)
                {
                    KeyWhite.transform.position = new Vector3(-1000, -1000, 0);
                   // WhiteKey.gameObject.GetComponent<SpriteRenderer>().enabled = true;
                }
                if (KeyNum == 2)
                {
                    KeyGreen.transform.position = new Vector3(-1000, -1000, 0);
                   // GreenKey.gameObject.GetComponent<SpriteRenderer>().enabled = true;
                }
                if (KeyNum == 3)
                {
                    KeyBlue.transform.position = new Vector3(-1000, -1000, 0);
                   // BlueKey.gameObject.GetComponent<SpriteRenderer>().enabled = true;
                }
                if (KeyNum == 4)
                {
                    KeyRed.transform.position = new Vector3(-1000, -1000, 0);
                   // RedKey.gameObject.GetComponent<SpriteRenderer>().enabled = true;
                }
                if (KeyNum == 5)
                {
                    KeyYellow.transform.position = new Vector3(-1000, -1000, 0);
                   // YellowKey.gameObject.GetComponent<SpriteRenderer>().enabled = true;
                }
                movementScript.HasKey = KeyNum;
                KeyNum = 0;
            }
        }

    }
    void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IsColliding = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IsColliding = false;
        }
    }
}
