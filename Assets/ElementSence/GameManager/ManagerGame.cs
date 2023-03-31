using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ManagerGame : MonoBehaviour
{
    [SerializeField]
    private List<RuntimeAnimatorController> L_runtimeAnimatorControllers;
    private CinemachineVirtualCamera cinemachineVirtualCamera;
    private CinemachineComponentBase cinemachineComponentBase;
    //Để set camera cho một gameobject nào đó
    private void Setup_Camera(Transform transform){
        //Chuyễn camera following gameobject
        cinemachineVirtualCamera = GetComponent<CinemachineVirtualCamera>();
        cinemachineVirtualCamera.Follow = transform;
    }
    
    void Start(){
        GameObject player = new GameObject("Player");
        Player scriptsPlayer = player.AddComponent<Player>();
        //Thêm animationController vào Player
        scriptsPlayer.runtimeAnimatorController = L_runtimeAnimatorControllers[0];
        Setup_Camera(player.transform);
    }
}
