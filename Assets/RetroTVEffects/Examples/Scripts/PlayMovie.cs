using UnityEngine;
using System.Collections;
using UnityEngine.Video;

public class PlayMovie : MonoBehaviour
{
#if !UNITY_WEBGL
	public VideoPlayer video;

    void Start()
    {
        video.Play();
    }
#endif
}