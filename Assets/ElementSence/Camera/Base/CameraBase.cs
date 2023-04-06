using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


//Tự tạo một main Camera riêng cho mình ^^
public class CameraBase : MonoBehaviour
{
    //Tạo thuộc tính trong Camera
    protected CinemachineVirtualCamera[] L_cameras = new CinemachineVirtualCamera[3];
    // protected CinemachineVirtualCamera startCam;
    // protected CinemachineVirtualCamera curentCam;

    protected virtual void Start(){
        for(int i = 0; i < L_cameras.Length; i++){
            CinemachineVirtualCamera VCam =  Create_VCam("VCam" + i.ToString());
            L_cameras[i] = VCam;
        }
    }

    private CinemachineVirtualCamera Create_VCam(string nameCam){
        GameObject VcamName = new GameObject(nameCam);
        VcamName.transform.SetParent(this.transform, true);
        CinemachineVirtualCamera cinemachineVirtualCamera = 
                    VcamName.gameObject.AddComponent<CinemachineVirtualCamera>();
        return cinemachineVirtualCamera;
    }
}
