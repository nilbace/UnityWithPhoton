using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviourPunCallbacks
{
    public float moveSpeed = 2f;
    
    public PhotonView PV;

    void Update()
    {
        if(PV.IsMine)
        {
            float Haxis = Input.GetAxis("Horizontal")*Time.deltaTime*moveSpeed;
            float Vaxis = Input.GetAxis("Vertical")*Time.deltaTime*moveSpeed;
            transform.Translate(new Vector3(Haxis, Vaxis, 0));

            if(Input.GetKeyDown(KeyCode.B))
            PV.RPC("Bigger", RpcTarget.AllBuffered);
        }

        [PunRPC] 
        void Bigger()
        {
            transform.localScale = new Vector3(2,2,2);
        }
    }
}
