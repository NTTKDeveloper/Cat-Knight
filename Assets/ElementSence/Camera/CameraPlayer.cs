using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraPlayer : CameraBase
{
    public GameObject player;
    public Player scriptplayer;
    public AVCamScript aVCamScript;
    private GameObject[] L_Avcam = new GameObject[2];
    private CinemachineFramingTransposer cinemachineFramingTransposer1;
    
    protected override void Start()
    {
        base.Start();
        //Lấy Component Scripts của Player
        scriptplayer = player.GetComponent<Player>();
        for(int i = 0; i < L_Avcam.Length; i++){
            GameObject AvCam = Create_EGameObject("AVCam" + i.ToString());
            //Đưa script vào xử lí
            aVCamScript = AvCam.AddComponent<AVCamScript>();
            //Chuyền player
            aVCamScript.player = player;
            //Chuyền giá trị trục Y
            if(i == 0){
                aVCamScript.valueY = 4f;
            }else if(i == 1){
                aVCamScript.valueY = -4f;
            }
            InitextraCamera(L_cameras[i], AvCam);
        }
        InitMainCamera(cinemachineFramingTransposer1);
    }

    //Setup MainCamera
    private void InitMainCamera(CinemachineFramingTransposer cinemachineFramingTransposer){
        L_cameras[2].Follow = player.transform;
        L_cameras[2].Priority = 20;
        cinemachineFramingTransposer = L_cameras[2].AddCinemachineComponent<CinemachineFramingTransposer>();
    }

    //Setup ExtraCamera
    private void InitextraCamera(CinemachineVirtualCamera L_cameras, GameObject AvCam){
        L_cameras.Follow = AvCam.transform;
        L_cameras.Priority = 10;
        cinemachineFramingTransposer1 = L_cameras.AddCinemachineComponent<CinemachineFramingTransposer>();
    }

    //Tạo Empty GameObject 
    private GameObject Create_EGameObject(string name){
        GameObject AVCam = new GameObject(name);
        return AVCam;
    }

    //Hàm Update()
    private void Update(){
        Vector2 direction = Vector2.up * scriptplayer.variableJoystick.Vertical + Vector2.right * scriptplayer.variableJoystick.Horizontal;
        // Debug.Log(scriptplayer.variableJoystick.Vertical);
        if(scriptplayer.variableJoystick.Vertical >= 0.88f){
            L_cameras[0].Priority = 20;
            L_cameras[1].Priority = 10;
            L_cameras[2].Priority = 10;
        }else if(scriptplayer.variableJoystick.Vertical <= -0.88f){
            L_cameras[0].Priority = 10;
            L_cameras[1].Priority = 20;
            L_cameras[2].Priority = 10;
        }else{
            L_cameras[0].Priority = 10;
            L_cameras[1].Priority = 10;
            L_cameras[2].Priority = 20;
        }
    }

}
