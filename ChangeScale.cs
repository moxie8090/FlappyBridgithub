using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ChangeScale : MonoBehaviour {
    public SgInstantiate gos;
    public Vector3 camera;
    public float dis;
	// Use this for initialization
	void Start () {
        camera = transform.position;
        dis = Screen.width/80;
	}
    public void foreath(List<string> obj)
    {


        for (int i = obj.Count-1;i>=0; i--)
        {
            if (GameObject.Find(obj[i]).transform.position.x<transform.position.x - dis)
            {
                gos.Gd_destroy(i,obj.Count);
                obj.RemoveAt(i);
            }
        }
    }
	// Update is called once per frame
	void Update () {
        if(Vector3.Distance(transform.position,camera)>dis)
        {
        camera = transform.position;
        foreath(gos.obj_bottom);
        }
	}
}
