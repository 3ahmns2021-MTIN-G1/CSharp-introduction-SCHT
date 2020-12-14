using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.Video;

public class Wiederholung : MonoBehaviour
{
    public bool loop;
    public Tilemap tm;
    public VideoPlayer vp;

    void Start()
    {
        tm.animationFrameRate = 5f;
        vp.isLooping = loop;
    }

 
    void Update()
    {
        
    }
}
