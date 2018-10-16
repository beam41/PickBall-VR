using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyit : MonoBehaviour {
    GameObject spawnObject;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        
        if (transform.position.y <= -5)
        {
            delleteIt();
            Spawner.ballCouter -= 1;
        }
	}
    void delleteIt()
    {
        Destroy(this.gameObject);
       
    }
}
