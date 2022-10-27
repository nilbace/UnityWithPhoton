using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviourPunCallbacks
{
    public float moveSpeed = 2f;
    void Start()
    {
        
    }

    void Update()
    {
        float Haxis = Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed;
        float Vaxis = Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;
    }
}
