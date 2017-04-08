using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnitySpeechToText.Widgets;

public class VideoController : MonoBehaviour {

	public SpeechToTextComparisonWidget m_SpeechToTextComparisonWidget;

	// Use this for initialization
	void Start () {
		var videoCont = GetComponent<VideoPlayer> ();
		videoCont.loopPointReached += VideoCont_loopPointReached;;

	}

	void VideoCont_loopPointReached (VideoPlayer source)
	{
		Debug.Log("video ended 1");
		m_SpeechToTextComparisonWidget.OnRecordButtonClicked();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
