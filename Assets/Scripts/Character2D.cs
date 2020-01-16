using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2D : MonoBehaviour
{
    [SerializeField]
    //si deseas que se vea
    float moveSpeed = 5f;
    //si no deseas que se vea
    //float moveSpeed {get; set;}
    
    void Update()
    {
        transform.Translate(Axis * 2f * Time.deltaTime);
    }

    Vector2 Axis
    {
        //metodo get (palabra reservada)
         get => new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
    public float MoveSpeed { get => moveSpeed; set => moveSpeed = value; }
}
