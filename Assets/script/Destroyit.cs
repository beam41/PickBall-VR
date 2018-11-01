using UnityEngine;

public class Destroyit : MonoBehaviour {

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
        Destroy(gameObject);
       
    }
}
