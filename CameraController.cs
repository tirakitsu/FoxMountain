using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public MovePlayer movePlayer;
    public bool isFollowing;
    public float xOffset;
    public float yOffset;

	// Use this for initialization
	void Start () {
        movePlayer = FindObjectOfType<MovePlayer>();

        isFollowing = true;
	}
	
	// Update is called once per frame
	void Update () {
        if (isFollowing)
            transform.position = new Vector3(movePlayer.transform.position.x + xOffset , movePlayer.transform.position.y + yOffset + 2, transform.position.z);
	}
}
