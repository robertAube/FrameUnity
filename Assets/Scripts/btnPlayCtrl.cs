using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class btnPlayCtrl : MonoBehaviour
{
    public Canvas canvasVideo;
    public Sprite imgPlay;
    public Sprite imgPause;
    [SerializeField]
    VideoPlayer vp;
    private bool play = false;
    private bool gone = true;
    int n = 0;


    void Start()
    {
        Pause();
    }
    void Update()
    {
        if (canvasVideo.enabled == false)
        {
            gone = true;
            Pause();
        }
        else
        {
            if (gone) 
                Jouer();
            gone = false;
        }
    }

    public void OnClic()
    {

        Debug.Log(++n + " - Click : " + play);
        if (play)
        {
            Pause();
        }
        else
        {
            Jouer();
        }
    }

    private void Pause()
    {
        if (vp.isPlaying)
        {
            Debug.Log("Pause : " + play);
            play = false;
            vp.Pause();
            gameObject.GetComponent<UnityEngine.UI.Image>().sprite = imgPlay;
        }
    }

    void Jouer()
    {
        if (!vp.isPlaying)
        {
            play = true;
            vp.Play();
            gameObject.GetComponent<UnityEngine.UI.Image>().sprite = imgPause;
        }
    }



}
