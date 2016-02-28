using UnityEngine;
using System.Collections;

public class CubeGenerate : MonoBehaviour {


	private float startTimer=0f;
	private bool allow=false;
	public static float genRate=0.3f;
	//private int randomInt=0;
	//public GameObject successObj;
	//public GameObject responsibilityObj;
	public GameObject mainCam;
	public GameObject cube;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		startTimer += Time.deltaTime;
		if (startTimer > 2f) 
		{
			allow=true;
			mainCam.GetComponent<PP_Noise>().noiseScale=genRate*2f;
				
		}
	if (allow) {
			if(Input.GetKey(KeyCode.Space))
			   {

				if(genRate<4f)
				{
					genRate+=0.01f;

				}
			}
			else
			{
				if(genRate>0.6f)
				{
					genRate-=0.01f;
				}
			}
			for(int i = 0; i < genRate; i++)
			{
			//	randomInt=Random.Range (1,3);
				/*if(randomInt==1)
				{
					Instantiate(successObj,Vector3.zero,Quaternion.identity);
				}
				else if(randomInt==2)
				{
					Instantiate(responsibilityObj,Vector3.zero,Quaternion.identity);
				}*/
				//	Instantiate(cube,Vector3.zero,Quaternion.identity);
			}
			mainCam.GetComponent<PP_Noise>().noiseScale=genRate*2f - 0.5f;
	}
}
}
