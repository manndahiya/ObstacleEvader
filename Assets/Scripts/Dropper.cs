using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 5f;
    MeshRenderer m_renderer;
    Rigidbody rb;
    

    // Start is called before the first frame update
    void Start()
    {
        m_renderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
        m_renderer.enabled = false;
        rb.useGravity = false;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait)
        {
            Debug.Log("5s done");
            m_renderer.enabled = true;
            rb.useGravity = true;
            
        }

        
    }
    void OnCollisionEnter(Collision collision)
    {
        // Check if the object has collided with a GameObject tagged as "Plane"
        if (collision.gameObject.CompareTag("Plane"))
        {
            // Set isKinematic to true when it touches the plane
            rb.isKinematic = true;
        }
    }


}
