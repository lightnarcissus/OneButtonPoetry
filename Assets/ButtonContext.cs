using UnityEngine;
using System.Collections;

public class ButtonContext : MonoBehaviour {

	//private float holdTime=0f;
	//private float releaseTime=0f;
	private float buttonTimer=0f;
	private float maxLimit=10f;
    private float minLimit = 0.6f;
	public static bool briefly=false;
	private float resetBriefTimer = 0f;
    public static int buttonType = 0;
    private int pressCounter = 0;
    private bool up=true;
    private float upTimer = 0f;
    
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Space))
        {
            //press and hold

            buttonTimer += Time.deltaTime;
            up = false;
            upTimer = 0f;
            if (buttonTimer > minLimit)
            {              
                briefly = false;
                buttonType = 1; //long press
            }
        }
		if(Input.GetKeyDown (KeyCode.Space))
		{
			//press briefly
            upTimer = 0f;
            up = false;
            pressCounter++;
            buttonTimer = 0f;
            if(pressCounter>=3)
            {
                briefly = false;
                buttonType = 3; //tapping
            }
            else
			briefly=true;
		}

		if(Input.GetKeyUp (KeyCode.Space))
		{
            up = true;
            buttonTimer = 0f;
			//released
			if(buttonTimer>0f)
			buttonTimer-=Time.deltaTime;
			else 
				buttonTimer=0f;
		}

		if (briefly) {
			resetBriefTimer+=Time.deltaTime;
            buttonType = 2; // brief press
			if(resetBriefTimer>1f)
			{
                up = true;
				resetBriefTimer=0f;
                pressCounter = 0;
				briefly=false;
			}
				}
        else
        {
            resetBriefTimer = 0f;
            briefly = false;
        }

        if(up)
        {
            upTimer += Time.deltaTime;
        }
        if(upTimer>1f)
        {
            pressCounter = 0;
            buttonType = 0; //inactive
        }
       
       
	
	}
}
