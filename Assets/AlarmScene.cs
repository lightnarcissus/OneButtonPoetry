using UnityEngine;
using System.Collections;
using UnityStandardAssets.ImageEffects;

public class AlarmScene : MonoBehaviour {

    public GameObject clock; //mainCam
    public GameObject bird; //quad
    public GameObject alarm;
    private float minBlur = 150f;
    private float currentBlur = 200f;
    private bool once = true;
    private float speed = 1f;
    private float reduceTimer = 0f;
    private bool allowChange = false;
    private float alarmVolume = 1.0f;
	// Use this for initialization
	void Start () {
      //  clock.GetComponent<DepthOfFieldScatter>().enabled = false;
        alarm.GetComponent<AudioSource>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {

        if(ButtonContext.buttonType==1 || ButtonContext.buttonType==2)
        {
            if(minBlur>3f)
                minBlur -= 0.5f;

            if (allowChange)
            {
                VerseTimer.change = true;
                allowChange = false;
            }

            speed = 1f;
            clock.GetComponent<AudioSource>().enabled = false;
			clock.GetComponent<DepthOfField>().enabled = true;
        }
        else
        {
            clock.GetComponent<AudioSource>().enabled = true;
           // clock.GetComponent<DepthOfFieldScatter>().enabled = false;
        }

        if (ButtonContext.buttonType == 3)
        {
            speed = clock.GetComponent<AudioSource>().pitch*2f;
            if(minBlur>3f)
            minBlur -= 0.5f*speed;
            clock.GetComponent<AudioSource>().pitch += 0.01f;
        }
        else
        {
            if (clock.GetComponent<AudioSource>().pitch > 1f)
            {
                clock.GetComponent<AudioSource>().pitch -= 0.01f;
            }
        }

        if (ButtonContext.buttonType == 2)
        {
            alarm.GetComponent<AudioSource>().enabled = true;
        }
        /*else
        {
            alarm.GetComponent<AudioSource>().enabled = false;
        }*/
        if(currentBlur>minBlur)
        {
            currentBlur -= 0.2f*speed;
            clock.GetComponent<DepthOfField>().maxBlurSize = currentBlur;
        }
        // Debug.Log(speed);
        if(reduceTimer<5f)
        {
            reduceTimer += Time.deltaTime; 
        }
        else
        {
            if(minBlur>32f)
            minBlur -= 30f;
            speed = 2f;
            reduceTimer = 0f;
        }

        if(currentBlur<5f)
        {
            allowChange = true;
        }

        if(alarm.GetComponent<AudioSource>().enabled)
        {
            alarm.GetComponent<AudioSource>().volume = alarmVolume;
            if (alarmVolume > 0.1f)
            {
                alarmVolume -= 0.01f;
            }
            else
            {
                alarmVolume = 1.0f;
                alarm.GetComponent<AudioSource>().enabled = false;
            }
           
            
        }
	
	}
}
