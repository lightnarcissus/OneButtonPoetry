using UnityEngine;
using System.Collections;

public class DecolorScene : MonoBehaviour {

	public GameObject spriteHead;
	public GameObject mainCam;
	public GameObject quad;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(ButtonContext.buttonType==1){

			mainCam.GetComponent<PP_Desaturate>().desaturate-=0.2f;
		}

		else if(ButtonContext.buttonType==2)
		{
			if(mainCam.GetComponent<PP_SinCity>().enabled)
				mainCam.GetComponent<PP_SinCity>().enabled=false;
			else
				mainCam.GetComponent<PP_SinCity>().enabled=true;
		}

		else if(ButtonContext.buttonType==3)
		{
			quad.SetActive(true);
			quad.SendMessage("PlayVid");
		}
		else
		{
			mainCam.GetComponent<PP_Desaturate>().desaturate+=0.2f;
		}
	
	}
}
