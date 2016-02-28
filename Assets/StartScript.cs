using UnityEngine;
using System.Collections;

public class StartScript : MonoBehaviour {

	public static bool poetrySelection = false;
	public GameObject startUI;
	public GameObject poemUI;


	// Use this for initialization
	void Start () {

		poemUI.SetActive (false);
	
	}
	
	// Update is called once per frame
	void Update () {

		if (!poetrySelection) {
			FemaleMove.femMove=false;
						if (Input.GetKeyDown (KeyCode.Space)) {
								poetrySelection = true;
								poemUI.SetActive(true);
								startUI.SetActive(false);
						}
				} 
		else {
			if(gameObject.GetComponent<Camera>().fieldOfView<=120f)
			{
				gameObject.GetComponent<Camera>().fieldOfView+=0.5f;
				FemaleMove.femMove=true;
			}

				}
	
	}
}
