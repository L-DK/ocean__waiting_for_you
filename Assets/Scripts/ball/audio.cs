using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{


    void Start()
    {
        if (ball_var.music_b1)
        {
            AudioSource bgm = this.GetComponent<AudioSource>();
            AudioClip clip = (AudioClip)Resources.Load("b1", typeof(AudioClip));//调用Resources方法加载AudioClip资源
            bgm.clip = clip;
            bgm.Play();
        }
        if (ball_var.music_b2)
        {
            AudioSource bgm = this.GetComponent<AudioSource>();
            AudioClip clip = (AudioClip)Resources.Load("b2", typeof(AudioClip));//调用Resources方法加载AudioClip资源
            bgm.clip = clip;
            bgm.Play();
        }
        if (ball_var.music_b3)
        {
            AudioSource bgm = this.GetComponent<AudioSource>();
            AudioClip clip = (AudioClip)Resources.Load("b3", typeof(AudioClip));//调用Resources方法加载AudioClip资源
            bgm.clip = clip;
            bgm.Play();
        }


    }



}
