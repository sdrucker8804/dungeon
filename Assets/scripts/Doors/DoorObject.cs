using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorObject : MonoBehaviour
{
    public Animator Animator;
    DoorCollider ColliderScript;
    public int DoorNum;
    // Start is called before the first frame update
    void Start()
    {
        //DoorTwo = FindObjectOfType<DoorTwoScript>();
        //ColliderScript = GetComponent("DoorCollider") as DoorCollider;
        ColliderScript = gameObject.GetComponentInChildren(typeof(DoorCollider)) as DoorCollider;
    }

    // Update is called once per frame
    void Update()
    {
        Animator.SetBool("DoorOpen", ColliderScript.DoorOpen);
        //(GetComponent("Animator") as Animator).SetBool("DoorOpen", ColliderScript.DoorOpen == true);
    }
}
