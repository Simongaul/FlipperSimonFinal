using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float targetPosition = 75;
    public float originPosition;

    public HingeJoint hinge;
    
    public KeyCode pressKey = KeyCode.Space;

    JointSpring jointSpring;

    float perfectCollision;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        jointSpring = hinge.spring;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(pressKey))
        {
            jointSpring.targetPosition = targetPosition;

            /*perfectCollision = Time.unscaledTime;
            Debug.Log(perfectCollision);*/
        }
        else
        {
            jointSpring.targetPosition = originPosition;
        }

        hinge.spring = jointSpring;
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            /*if (Time.unscaledTime - perfectCollision < 1f)
            {
                ScoreManager.instance.GainPoint(500);
                collision.rigidbody.AddForce(Vector3.up * 1000);
                Debug.Log("Perfect Collision");
            }
            else
            {
                GameManager.instance.AddedForce();
            }*/
            
            GameManager.instance.AddedForce();
        }
    }

}
