using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GD_trigger : MonoBehaviour {
	public GameObject obj1;
	// Use this for initialization
	void Awake()
	{
		//obj1 = GameObject.Find ("/SG_ Instantiate").GetComponent<SgInstantiate> ().obj;
	}
	void Start () {
		obj1 = GameObject.Find ("/SG_ Instantiate").GetComponent<SgInstantiate> ().obj;
	}
	public void OnTriggerStay2D(Collider2D dir)
	{
		if(dir.tag=="brid")
		{
			Time.timeScale = 0;
			obj1.SetActive (true);
			GameObject.Find ("/FlappyBrid").GetComponent<Rigidbody2D> ().isKinematic = false;
		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
