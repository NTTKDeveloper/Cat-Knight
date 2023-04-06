using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ManagerGame : MonoBehaviour
{
    [SerializeField]
    private List<RuntimeAnimatorController> L_runtimeAnimatorControllers;
    public VariableJoystick variableJoystick;
    //Biến của những class-------------------------------------------------
    private Player scriptsPlayer;
    private CameraPlayer playerCam;
    //---------------------------------------------------------------------

    protected GameObject player;

    protected GameObject InitPlayer(string namePlayer){
        GameObject player = new GameObject(namePlayer);
        scriptsPlayer = player.AddComponent<Player>();
        //Thêm animationController vào Player
        scriptsPlayer.runtimeAnimatorController = L_runtimeAnimatorControllers[0];
        //Kết nối joystick vào player
        scriptsPlayer.variableJoystick = variableJoystick;
        return player;
    }

    //Khởi tạo CamManager
    private void InitCamManager(){
        //Add script vào camera
        GameObject camManager = new GameObject("CameraVManager");
        playerCam = camManager.AddComponent<CameraPlayer>();
        playerCam.player = this.player;
    }
    private void Start(){
        //Tạo Player
        player = InitPlayer("Player"); 
        //Tạo ManagerCam
        InitCamManager();       
    }
}
