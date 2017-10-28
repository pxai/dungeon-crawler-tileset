using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    private Transform player;

    void Start()
    {
        player = GameObject.Find("Hero").transform;
    }

    void Update()
    {
        Vector3 playerpos = player.position;
        playerpos.z = transform.position.z;
        transform.position = playerpos;
    }
}
