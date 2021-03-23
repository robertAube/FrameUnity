using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public Canvas canvasVideo;
    public Sprite sp1;
    public Sprite sp2;
    private Sprite imgPlay;
    private Sprite imgPause;
    private bool play;

    void Start()
    {
        play = true;
    }

    public void OnClicK()
    {
        setImage();
    }
    private void setImage()
    {



        if (play)
        {
            gameObject.GetComponent<UnityEngine.UI.Image>().sprite = imgPlay;

        }
        else
        {
            gameObject.GetComponent<UnityEngine.UI.Image>().sprite = imgPause;
        }
        play = !play;
    }
}
