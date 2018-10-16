using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactBall : MonoBehaviour {
    // Use this for initialization
    GameObject player;
    Outline outliner;
    float distance_;
	void Start () {
        player = GameObject.Find("Player");
        outliner = gameObject.GetComponent<Outline>();
	}
	
	// Update is called once per frame
	void Update () {
        distance_ = Vector3.Distance(this.transform.position, player.transform.position);
	}

    public void GetIt(){
        if(distance_ <= 5)
        {
            Debug.Log(distance_);
            outliner.OutlineWidth = 10f;
        }
        
        
    }
    public void takeIt()
    {
        if(distance_ <= 5)
        {
            Destroy(this.gameObject);
            Debug.Log("you get this object");
        }
    
    }
    public void offIt()
    {   
   
        Debug.Log("off it");
        outliner.OutlineWidth = 0f;
    
    }
}
