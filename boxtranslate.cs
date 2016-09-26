using UnityEngine;
using System.Collections;

public class boxtranslate : MonoBehaviour {
    public float speed=10f;
    public Transform camera;
	private float WDtime=0;
    // Use this for initializationc
    void Awake ()
    {
       gameObject.AddComponent<Rigidbody2D> ();
    }
	public void chage_tag()
	{
		GameObject.Find ("/Canvas/Button").SetActive (false);
		Time.timeScale = 1;
		this.transform.tag = "brid1";
		WDtime = Time.time;
		if(this.transform.position.y>4||this.transform.position.y<(-4f))
		{
			this.transform.position = new Vector3 (this.transform.position.x, 0f, 0f);
		}
	}
	// Update is called once per frame
	void Update () {
		if (Time.deltaTime != 0) {
			this.transform.Translate (0.1f, 0, 0);
		}
		//this.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0,8f));
        camera.position = new Vector3(transform.position.x,camera.transform.position.y,camera.transform.position.z); 
        if (Input.GetKey(KeyCode.C))
        {
            this.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, 20));
        }
		if((Time.time-WDtime)>3f)
		{
			this.transform.tag = "brid";
		}
    }
}
