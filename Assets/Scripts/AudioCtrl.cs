using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioCtrl : MonoBehaviour
{

    Slider s;
    GameObject aui;
    AudioSource a;
    void Start()
    {
        aui = GameObject.FindGameObjectWithTag("sound");
        s = GetComponent<Slider>();
        a = aui.GetComponent<AudioSource>();

    }

    void Update()
    {
        a.volume = s.value;
    }
}
