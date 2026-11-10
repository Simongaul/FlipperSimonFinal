using UnityEngine;

public class BumperNormal : MonoBehaviour
{
    public Vector3 force;
    public float strength = 100;
    public Animation animation;
    
    void OnCollisionEnter(Collision collision)
    {
        force = -collision.contacts[0].normal*strength + GameManager.instance.addedForce * Vector3.up;
        collision.rigidbody.AddForce(force);
        
        GameManager.instance.AddedForce();

        //animation.Play();

        ScoreManager.instance.GainPoint(100);
    }
}

