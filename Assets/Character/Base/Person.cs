using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    protected SpriteRenderer spriteRenderer;
    protected BoxCollider2D boxCollider2d;
    protected Rigidbody2D rigidbody2d;
    protected Animator animator;
    //Hàm ảo Start thực hiện đúng chức năng của Start của Behaviour 
    //Coi như nó là hàm xây dựng lun ^^
    protected virtual void Start(){
        //Những thuộc tính cần thiết của Person 
        //Transform (Vị trí)
        Transform transform = this.gameObject.AddComponent<Transform>(); 
        //Spirte Rendering
        spriteRenderer = this.gameObject.AddComponent<SpriteRenderer>();
        //Box Collider 2D(va chạm)
        boxCollider2d = this.gameObject.AddComponent<BoxCollider2D>();
        //Rigidbody2D (Vật lí)
        rigidbody2d = this.gameObject.AddComponent<Rigidbody2D>(); 
        //Animator (Hoạt ảnh)
        animator = this.gameObject.AddComponent<Animator>();
    }
    
    //Hàm tấn công chung chung
    protected virtual void Attack(){
    }
    //Di chuyễn qua phải
    protected virtual void Right(){

    }
    //Di chuyễn qua trái
    protected virtual void Left(){
        
    }
    //Hàm nhảy 
    protected virtual void Jump(){}
}
