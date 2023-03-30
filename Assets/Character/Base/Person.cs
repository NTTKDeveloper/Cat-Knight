using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    //Hàm ảo Start thực hiện đúng chức năng của Start của Behaviour 
    //Coi như nó là hàm xây dựng lun ^^
    protected virtual void Start(){
        //Box Collider 2D(va chạm)
        BoxCollider2D boxCollider2D = this.gameObject.AddComponent<BoxCollider2D>();
        //RectTransform (vị trí)
        RectTransform rectTransform = this.gameObject.AddComponent<RectTransform>();
        //Rigidbody2D (Vật lí)
        Rigidbody2D rigidbody2D = this.gameObject.AddComponent<Rigidbody2D>(); 
    }
}
