using UnityEngine;

public class Bumper : MonoBehaviour
{
    public Vector3 force;
    public float strength = 100;
    //public Animation animation;
    
    void OnCollisionEnter(Collision collision)
    {
        
        force = (collision.transform.position - transform.position).normalized*strength + GameManager.instance.addedForce * Vector3.up;
        collision.rigidbody.AddForce(force);
        
        GameManager.instance.AddedForce();

        //animation.Play();

        ScoreManager.instance.GainPoint(100);
    }
}
