using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SgInstantiate : MonoBehaviour {
    public GameObject parfab;
    public List<string> obj_bottom;
    private SpriteRenderer render;
    private Transform tran;
    private Vector2 v2 = Vector2.zero;
    private static int count = 0;
	public GameObject obj;
	// Use this for initialization
	void Awake () {
        obj_bottom = new List<string>();
        tran = GameObject.Find("/backgaund").GetComponent<Transform>();
        v2 = new Vector2 (tran.localScale.x, tran.localScale.y);
        render = GameObject.Find("/backgaund").GetComponent<SpriteRenderer>();
        v2 = new Vector2 ((-v2.x*render.sprite.texture.width)/200, (-v2.y*render.sprite.texture.height)/200);
        Debug.Log(v2);
    }
    public void Gd_destroy(int length,int count)
    {
        for (int i = 0; i < length; i+=2)
        {
            Destroy(GameObject.Find(obj_bottom[i]));
            Destroy(GameObject.Find(obj_bottom[i+1]));
            if (count < 20)
            {
                show_GD();
            }
        }
    }
    public void show_GD()
    {
        float scaletop;
        float scalebuttom = Random.Range(1,5);
        v2.x = v2.x + (scalebuttom+1) * 2f;
        Debug.Log(scalebuttom);
        if (scalebuttom <= 4)
        {
            scaletop = Random.Range(1,5-scalebuttom);
            Inst(scaletop,1);

        }
        Inst(scalebuttom,2);
    }
    public void Inst(float scalebuttom,int a)
    {
        GameObject o = GameObject.Instantiate<GameObject>(this.parfab);
        count++;
        o.transform.position = new Vector3(v2.x, v2.y + scalebuttom * 1.2f, 0);
        o.transform.name = string.Format("GD_{0}",count);
        Debug.Log(o.transform.FindChild("SG_STi"));
        o.transform.FindChild("SG_STi").localScale = new Vector3(1f, scalebuttom, 1f);
        if (a == 1)
        {
            o.transform.localRotation = Quaternion.Euler(180f, 0f, 0f);
            o.transform.position = new Vector3(v2.x, v2.y + (8.5f-scalebuttom) * 1.2f, 0);
        }
     obj_bottom.Add(o.transform.name);
        
    }
	// Update is called once per frame
	void Update () {
        if (v2.x < 14)
            show_GD();
	}
}
