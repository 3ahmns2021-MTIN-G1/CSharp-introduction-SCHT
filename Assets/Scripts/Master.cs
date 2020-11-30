using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour
{
    public float x;
    public bool z;
    public Rigidbody rigid;
    public BoxCollider bc;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.mass = x+20;
        rigid.isKinematic = z;
        rigid.angularDrag = x + 50f;
        rigid.drag = x - rigid.mass;
        bc.isTrigger = z;
    }
}
