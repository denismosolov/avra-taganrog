using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		var videoCont = GetComponent<VideoPlayer> ();
		videoCont.loopPointReached += VideoCont_loopPointReached;;

	}

	void VideoCont_loopPointReached (VideoPlayer source)
	{
		Debug.Log("video ended 1");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void EndReached(UnityEngine.Video.VideoPlayer vp)
	{
		//vp.playbackSpeed = vp.playbackSpeed / 10.0F;
		Debug.Log("video ended");
	}
}
