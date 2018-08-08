using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kitsuSpirits : MonoBehaviour {

    public int maxSpirit;
    public int currentSpirits;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void usedFire(int shot)
    {
        currentSpirits -= shot;
    }

    public void setMaxSpirits()
    {
        currentSpirits = maxSpirit;
    }
}
