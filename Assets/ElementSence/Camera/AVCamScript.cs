using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AVCamScript : MonoBehaviour
{
    //Thuộc tính 
    public GameObject player;
    public float valueY;

    // private void Start(){
        
    //     this.transform.position = new Vector3(player.transform.position.x, 0, player.transform.position.z);
    // }
    //Xử lí các AVCam
    // Update is called once per frame
    private void Update(){
        this.transform.localScale = player.transform.localScale;
        this.transform.position = new Vector3(player.transform.position.x, valueY, 
                                                player.transform.position.z);
    }
}
