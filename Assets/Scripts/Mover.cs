using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 10f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        float xMove = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float zMove = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(xMove, 0, zMove);
    }
}
