using UnityEngine;
using System.Collections;

public class FemaleMove : MonoBehaviour {

	public static bool femMove=false;
	public static int spaceCount=0;
	public Transform disintegration;
	public Transform thorns;
	public Transform routine;
	public Transform requiem;
	public GameObject mainCam;
	private float thornTimer=0f;
	private float routineTimer=0f;
	private float disintegrationTimer=0f;
	private float requiemTimer=0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (femMove) {
						if (Input.GetKeyDown (KeyCode.Space)) {
								spaceCount++;
						}
			if (spaceCount == 1) { // thorns
				mainCam.GetComponent<PP_CrossHatch>().lineColor=Color.green;
				thornTimer+=Time.deltaTime;
				transform.position = Vector3.Lerp (transform.position, new Vector3 (0.2f, 1.97f, transform.position.z), Time.deltaTime);
			} else if (spaceCount == 2) { // disintegration
				mainCam.GetComponent<PP_CrossHatch>().lineColor=Color.yellow;
				disintegrationTimer+=Time.deltaTime;
				transform.position = Vector3.Lerp (transform.position, new Vector3 (-2.33f, 1.09f, transform.position.z), Time.deltaTime);
			} else if (spaceCount == 3) { // routine
				mainCam.GetComponent<PP_CrossHatch>().lineColor=Color.blue;
				routineTimer+=Time.deltaTime;
				transform.position = Vector3.Lerp (transform.position, new Vector3 (3.35f, 1.09f, transform.position.z), Time.deltaTime);
			} else if (spaceCount == 4) { // requiem
				mainCam.GetComponent<PP_CrossHatch>().lineColor=Color.gray;
				requiemTimer+=Time.deltaTime;
				transform.position = Vector3.Lerp (transform.position, new Vector3 (0.2f, -1.4f, transform.position.z), Time.deltaTime);
							
			} else if (spaceCount == 5) {
				spaceCount = 1;
			}
				}
	
	}
}
