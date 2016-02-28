using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;

public class BlindScene : MonoBehaviour {

    public GameObject blind1;
    public GameObject blind2;
    private bool separate = false;
    private float separateTimer = 0f;
    public GameObject mainCam;
	public GameObject ashtray;
	private float sceneTimer=0f;
	// Use this for initialization
	void Start () {
        blind1.GetComponent<Animator>().enabled = false;
        blind2.GetComponent<Animator>().enabled = false;
        mainCam.GetComponent<Animator>().enabled = true;
	
	}
	
	// Update is called once per frame
	void Update () {

		if(sceneTimer<44f)
		sceneTimer+=Time.deltaTime;
		else
		{
			VerseTimer.verseInt++;
			VerseTimer.change=true;
			this.enabled=false;
		}

        if (ButtonContext.buttonType == 1)
        {
			if(mainCam.transform.eulerAngles.x<341f || mainCam.transform.eulerAngles.x>355f)
			{
				ashtray.GetComponent<Animator>().enabled=true;
			}
			else
			{
				ashtray.GetComponent<Animator>().enabled=false;
			}
            if (separateTimer < 0.5f)
            {
                separateTimer += Time.deltaTime;
                blind1.GetComponent<Animator>().enabled = true;
                blind2.GetComponent<Animator>().enabled = true;
            }
            else
            {
                blind1.GetComponent<Animator>().enabled = false;
                blind2.GetComponent<Animator>().enabled = false;
            }
        }
        else
        {
            if (separateTimer >0.5 && separateTimer < 1f)
            {
                separateTimer += Time.deltaTime;
                blind1.GetComponent<Animator>().enabled = true;
                blind2.GetComponent<Animator>().enabled = true;
            }
            else
            {
                blind1.GetComponent<Animator>().enabled = false;
                blind2.GetComponent<Animator>().enabled = false;
                separateTimer = 0f;
            }
           
        }

        if(ButtonContext.buttonType==2)
        {
            mainCam.GetComponent<Animator>().enabled = false;
        }
        else
        {
            mainCam.GetComponent<Animator>().enabled = true;
        }

		if(ButtonContext.buttonType==3)
		{
			if(mainCam.GetComponent<SunShafts>().sunShaftBlurRadius<10f)
			mainCam.GetComponent<SunShafts>().sunShaftBlurRadius+=0.1f;
		}
		else
		{
			if(mainCam.GetComponent<SunShafts>().sunShaftBlurRadius>1f)
				mainCam.GetComponent<SunShafts>().sunShaftBlurRadius-=0.1f;
		}

	
	}
}
