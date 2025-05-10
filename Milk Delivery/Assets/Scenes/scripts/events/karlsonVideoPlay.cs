using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class karlsonVideoPlay : MonoBehaviour
{
    [SerializeField] string video;
    // Start is called before the first frame update
    void Start()
    {
        Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Play()
    {
        VideoPlayer player = GetComponent<VideoPlayer>();

        if (player)
        {
            string videoPath = System.IO.Path.Combine(Application.streamingAssetsPath, video);
            Debug.Log("Video Playing");
            player.url = videoPath;
            player.Play();
        }
    }
}
