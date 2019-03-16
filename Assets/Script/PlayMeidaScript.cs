using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayMeidaScript : MonoBehaviour
{
    public GameObject oPlayer;
    VideoPlayer player;
    // Start is called before the first frame update
    void Start()
    {
        player = oPlayer.GetComponent(typeof(VideoPlayer)) as VideoPlayer;
        if (player==null)
        {
            Debug.ClearDeveloperConsole();
            Debug.Log("Player is null");
        }
        else
        {
            Debug.ClearDeveloperConsole();
            Debug.Log("Player is not null");
        }
        player.Play();
        player.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        player.Play();
    }
    public void Pause()
    {
        player.Pause();
    }

}
