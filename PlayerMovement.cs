
using UnityEngine;

public class playermovement : MonoBehaviour {
    public  Rigidbody rb;
    public float forwardforce = 2000f;
    public float sidewayforce = 1000f;
    public float stop = 3000f;
    // Update is called once per frame
    void FixedUpdate () {
        rb.AddForce(0, 0, forwardforce* Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewayforce* Time.deltaTime, 0, 0);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewayforce*Time.deltaTime ,0, 0);
        }
        if(Input.GetKey("s"))
        {
            
           rb.AddForce(0, 0, -stop * Time.deltaTime);
        }
        if(rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().Endgame();
        }
    }
}
