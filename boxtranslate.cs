using UnityEngine;
using System.Collections;

public class boxtranslate : MonoBehaviour {
    public float speed=10f;
    public Transform camera;
    // Use this for initializationc
    void Awake ()
    {
       gameObject.AddComponent<Rigidbody2D> ();
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(0.1f,0,0);
        camera.position = new Vector3(transform.position.x,camera.transform.position.y,camera.transform.position.z); 
        if (Input.GetKey(KeyCode.C))
        {
            this.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, 20));
        }
    }
}
