using UnityEngine;
using System.Collections;

public class CrowdScene : MonoBehaviour {

	private float sceneTimer=0f;
	public GameObject mainCam;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Debug.Log(sceneTimer);
		if(sceneTimer<30f)
			sceneTimer+=Time.deltaTime;
		else
		{
			VerseTimer.verseInt++;
			VerseTimer.change=true;
			this.enabled=false;
		}

		if(ButtonContext.buttonType==1)
		{
			mainCam.GetComponent<PP_Charcoal>().enabled=false;
		}
		else
		{
			Time.timeScale=1f;
		}

		if(ButtonContext.buttonType==2)
		{
			mainCam.GetComponent<PP_Charcoal>().enabled=true;
		}
	
	}
}
