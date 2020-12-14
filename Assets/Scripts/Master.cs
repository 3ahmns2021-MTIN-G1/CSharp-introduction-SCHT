using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class Master : MonoBehaviour
{
    public float x;
    public bool z;
    public int textSize;
    public Rigidbody rigid;
    public BoxCollider bc;
    public Text txt;
   
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.mass = x+20;
        rigid.isKinematic = z;
        rigid.angularDrag = x + 50f;
        rigid.drag = x - rigid.mass;
        bc.isTrigger = z;
        txt.text = "Wilfried Gruber";
        txt.fontSize = 4;
        txt.lineSpacing = 5;
    }
}
