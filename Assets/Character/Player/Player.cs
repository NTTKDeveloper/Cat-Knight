using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Person
{
    private float speed = 20f;
    public RuntimeAnimatorController runtimeAnimatorController;
    public VariableJoystick variableJoystick;
    //Khởi tạo các giá trị component cho Player
    protected override void Start(){
        base.Start();
        //Khởi tạo hệ thống vật lí
        InitSysPhysical(rigidbody2d, boxCollider2d, true, 
                        new Vector2(0, -1.28f), new Vector2(10, 11.23f));
        //-------------POSITTION----------------        
        //Lấy giá trị từ Class Data
        transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        //--------------------------------------
        //Add Animation Controller
        animator.runtimeAnimatorController = runtimeAnimatorController;
    }
    //Hàm khởi tạo hệ thống vật lí 
    protected void InitSysPhysical(Rigidbody2D rigidbody2d, 
                                    BoxCollider2D boxCollider2d, bool sWitch, 
                                    Vector2 offset, Vector2 size){
        //Tắt mở hệ thống vật lí
        rigidbody2d.simulated = sWitch;
        //Setup kích thước boxCollider
        boxCollider2d.offset = offset;
        boxCollider2d.size = size;
        
    }
    //Hàm xử lí vật lí
    protected void FixedUpdate()
    {
        Vector2 direction = Vector2.up * variableJoystick.Vertical + Vector2.right * variableJoystick.Horizontal;
        rigidbody2d.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode2D.Impulse);
    }
}
