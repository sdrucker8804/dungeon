using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCollider : MonoBehaviour
    
{
    public bool IsCollding;
    public bool DoorOpen;
    movement MovementScript;
    KeyOneFloor KeyHoleOne;
    KeyTwoFloor KeyHoleTwo;
    KeyThreeFloor KeyHoleThree;
    KeyFourFloor KeyHoleFour;
    KeyFiveFloor KeyHoleFive;
    KeySixFloor KeyHoleSix;
    public int HoleOne;
    public int HoleTwo;
    public int HoleThree;
    public int HoleFour;
    public int HoleFive;
    public int HoleSix;
    public bool Up;

    // Start is called before the first frame update
    void Start()
    {
        MovementScript = FindObjectOfType<movement>();
        KeyHoleOne = FindObjectOfType<KeyOneFloor>();
        KeyHoleTwo = FindObjectOfType<KeyTwoFloor>();
        KeyHoleThree = FindObjectOfType<KeyThreeFloor>();
        KeyHoleFour = FindObjectOfType<KeyFourFloor>();
        KeyHoleFive = FindObjectOfType<KeyFiveFloor>();
        KeyHoleSix = FindObjectOfType<KeySixFloor>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsCollding == true && DoorOpen == true)
        {
            if (Up == true)
            {
                MovementScript.up = true;
            }
            else
            {
                MovementScript.down = true;
            }
        }
        
        if (KeyHoleOne.KeyNum == HoleOne && KeyHoleTwo.KeyNum == HoleTwo && KeyHoleThree.KeyNum == HoleThree && KeyHoleFour.KeyNum == HoleFour && KeyHoleFive.KeyNum == HoleFive && KeyHoleSix.KeyNum == HoleSix)
        {
            DoorOpen = true;
        }
        else
        {
            DoorOpen = false;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)

    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IsCollding = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IsCollding = false;
        }
    }
}
