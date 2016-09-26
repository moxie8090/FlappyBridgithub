using UnityEngine;
using System.Collections;

public class Triggerend2d : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
    public void OnTriggerExit2D(Collider2D dir)
    {
		if(dir.tag=="brid"||dir.tag=="brid1")
        {
            this.transform.position = transform.position + new Vector3(64f, transform.position.y, 0);
        }
    }
	// Update is called once per frame
	void Update () {
	
	}
}
