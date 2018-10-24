using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactBall : MonoBehaviour {
    // Use this for initialization
    GameObject player;
    public Renderer rend;

    float distance_;
	void Start () {
        player = GameObject.Find("Player");
        rend = GetComponent<Renderer>();
        rend.material.shader = Shader.Find("Custom/OutlineColor");
        rend.material.SetFloat("_Outline", 0f);
        
	}
	
	// Update is called once per frame
	void Update () {
        distance_ = Vector3.Distance(this.transform.position, player.transform.position);
	}

    public void GetIt(){
        if(distance_ <= 5)
        {
            //Debug.Log(distance_);
            //Debug.Log(rend.material.GetFloat("_Outline"));
            rend.material.SetFloat("_Outline", 0.05f);
        }


    }
    public void takeIt()
    {
        
        if(distance_ <= 5)
        {
            Destroy(this.gameObject);
            //Debug.Log("you get this object");
            
            
            
        }
    
    }
    public void offIt()
    {   
        
        //Debug.Log("off it");
        rend.material.SetFloat("_Outline", 0f);


    }
}
