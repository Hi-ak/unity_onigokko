using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Player1 : MonoBehaviour
{
    private　GameObject player1;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        this.player1 = GameObject.Find("Player1");
        offset = transform.position - player1.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player1.transform.position + offset;
        transform.rotation = player1.transform.rotation;
    }
}
