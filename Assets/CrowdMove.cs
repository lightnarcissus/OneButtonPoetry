using UnityEngine;
using System.Collections;

public class CrowdMove : MonoBehaviour {

	private float changeTimer=0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (changeTimer <0.2f) {
			changeTimer+=Time.deltaTime;	
		}
		if (changeTimer >= 0.15f) {
			transform.position=new Vector3(Random.Range (-2.7f,3.6f),0f,Random.Range (-9.1f,-1.1f));

				}
	}
}
