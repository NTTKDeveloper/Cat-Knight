using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Person
{
    public RuntimeAnimatorController runtimeAnimatorController;
    //Khởi tạo các giá trị component cho Player
    protected override void Start(){
        base.Start();
        //Tắt hệ thống vật lí
        rigidbody2d.simulated = false;
        //-------------POSITTION----------------        
        //Lấy giá trị từ Class Data
        transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        //--------------------------------------
        //Add Animation Controller
        animator.runtimeAnimatorController = runtimeAnimatorController;
    }
}
