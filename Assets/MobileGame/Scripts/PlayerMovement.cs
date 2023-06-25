using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forward = 10;
    public float side = 50;
    public float maxSide = 5;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, forward);

        if (Input.GetKey("d"))
            if (rb.velocity.x <= maxSide)
                rb.AddForce(side * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            else
                rb.velocity = new Vector3(maxSide, rb.velocity.y, forward);
        
        if(Input.GetKey("a"))
            if (rb.velocity.x >= -maxSide)
                rb.AddForce(-side * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            else
                rb.velocity = new Vector3(maxSide, rb.velocity.y, forward);

        if(rb.position.y < -1)
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
