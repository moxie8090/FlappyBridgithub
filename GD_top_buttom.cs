using UnityEngine;
using System.Collections;

public class GD_top_buttom : MonoBehaviour {
	public GameObject obj1;
	// Use this for initialization
	void Start () {
		obj1 = GameObject.Find ("/SG_ Instantiate").GetComponent<SgInstantiate> ().obj;
	}
//	public void OnTriggerEnter2D(Collider2D dir)
//	{
//		if(dir.tag=="brid"||dir.tag=="brid1")
//		{
//			Time.timeScale = 0;
//			obj1.SetActive (true);
//			//GameObject.Find ("/FlappyBrid").GetComponent<Rigidbody2D> ().isKinematic = false;
//		}
//	}
	public void OnTriggerExit2D(Collider2D dir)
	{
		if(dir.tag=="brid"||dir.tag=="brid1")
		{
			Time.timeScale = 0;
			obj1.SetActive (true);
			//GameObject.Find ("/FlappyBrid").GetComponent<Rigidbody2D> ().isKinematic = false;
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
