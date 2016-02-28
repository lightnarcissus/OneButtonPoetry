using UnityEngine;
using System.Collections;

public class VerseTimer : MonoBehaviour {

    private float verseTimer = 0f;
    public static int verseInt = 0;
    public GameObject crossFade;
    public GameObject blindScene;
    public GameObject alarmScene;
    public GameObject crowdScene;
	public GameObject decolorScene;
    public static bool change = false;
    public GameObject blindManager;
    public GameObject alarmManager;
    public GameObject crowdManager;
    public GameObject transitionListener;
    private float transitionTimer = 0f;
    private bool transitioning = false;
    private float waitTimer = 0f;
    private bool once = true;
    public AudioClip click;
	// Use this for initialization
	void Start () {

        crossFade = alarmManager;
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(verseInt);
        if(change)
        {

            if (once)
            {
                verseInt++;
               // crossFade.SendMessage("ChangeVerse");
                once = false;
            } 
            transitionListener.SetActive(true);
            if (verseInt == 1)
            {
				blindScene.SetActive (true);
               // blindManager.SetActive(true);
                transitioning = true;
                transitionListener.GetComponent<AudioSource>().PlayOneShot(click);
               // crossFade = blindManager;
                alarmScene.SetActive(false);
            }
            else if (verseInt == 2)
            {
                blindScene.SetActive(false);
				crowdScene.SetActive (true);
                //crowdManager.SetActive(true);
                //crossFade = crowdManager;
            }
            else if (verseInt == 3)
			{
				decolorScene.SetActive(true);
				crowdScene.SetActive(false);
			}
			else if(verseInt==4)
			{
			}

        /*    waitTimer = 0f;
            verseTimer = 0f;
            once = true;

         /*   if (waitTimer < 4f)
                waitTimer += Time.deltaTime;
            else
            {
                if (verseInt == 1)
                {
                    blindManager.SetActive(true);
                    crossFade = blindManager;
                    alarmScene.SetActive(false);
                }
                else if (verseInt == 2)
                {
                    blindScene.SetActive(false);
                    crowdManager.SetActive(true);
                    crossFade = crowdManager;
                }
                else if (verseInt == 3)
                    crossFade = crowdManager;
                waitTimer = 0f;
                verseTimer = 0f;
                once = true;
            }
*/
            change = false; 
        }

  /*      if(transitioning)
        {
            transitionTimer += Time.deltaTime;
            if(transitionTimer>2f)
            {
                transitionListener.SetActive(false);
                transitionTimer = 0f;
                transitioning = false;
            }
        }*/
	
	}
}
