using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoPlayerCTRL : MonoBehaviour
{
    public Canvas canvasVideo;
    public Button btnPlayPause;
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

    public void OnClick_playPause()
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
            btnPlayPause.GetComponent<Image>().sprite = imgPlay;
        }
    }

    void Jouer()
    {
        if (!vp.isPlaying)
        {
            play = true;
            vp.Play();
            btnPlayPause.GetComponent<Image>().sprite = imgPause;
        }
    }



}
