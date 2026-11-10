using UnityEngine;

public class WallBump : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Vector3 force;
    public float strength = 100;
    
    void OnCollisionEnter(Collision collision)
    {
        force = -collision.contacts[0].normal*strength + GameManager.instance.addedForce * Vector3.up;
        collision.rigidbody.AddForce(force);
        
        GameManager.instance.AddedForce();
    }
}
