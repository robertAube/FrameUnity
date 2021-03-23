using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class CTRLVideo : MonoBehaviour
{
    [SerializeField]
    Canvas canvasVideo;
    [SerializeField]
    VideoPlayer vp;

    GameObject btnPlayPause;

    private Sprite imgPlay;
    private Sprite imgPause;

    // Start is called before the first frame update
    void Start()
    {
        //btnPlayPause = GameObject.FindWithTag("btnPlayPause");
        //Debug.Log("btnPlayPause - " + btnPlayPause.name);


        //imgPause = Resources.Load<Sprite>("play");
        //Debug.Log("play - " + imgPause);

        //imgPlay = Resources.Load<Sprite>("player_pause (32)");
        //vp.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        //if (canvasVideo.enabled == false)
        //{
        //    vp.Stop();
        //}
        //else
        //{
        //    Jouer();
        //}
    }

    private void Pause()
    {
        if (vp.isPlaying)
        {
            vp.Pause();
            btnPlayPause.GetComponent<Image>().sprite = imgPlay;

        }
    }

    void Jouer()
    {
        if (!vp.isPlaying)
        {
            vp.Play();
            btnPlayPause.GetComponent<Image>().sprite = imgPause;

        }
    }

    void OnMouseDown()
    {
        Debug.Log("OnMouseDown() ");

    }
}
