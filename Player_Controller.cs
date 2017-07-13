 using UnityEngine;

public class Player_Controller : MonoBehaviour {

    private Rigidbody rb;       ///Field for the component Rigid Body

    public float speed;
    public float flyingHeight;
    public float turningSpeed;
    public float turnCatchSpeed;
    

    private void Start()
    {
        rb = GetComponent<Rigidbody>();             ///Fetches the component from Unity as soon as the obj comes onto the frame
    }

    void FixedUpdate(){

        float moveHorizontal = Input.GetAxis("Horizontal");        
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 acceleration = new Vector3(0, 0, moveVertical);
        Vector3 rotate = new Vector3(0, moveHorizontal, 0);
        Vector3 rotateCatch = new Vector3(moveHorizontal, 0, 0);

        rb.AddRelativeForce(acceleration * speed, ForceMode.Acceleration);
        rb.AddForce(new Vector3(0, flyingHeight, 0));
        rb.AddRelativeForce(rotateCatch * turnCatchSpeed);

        transform.Rotate(rotate * Time.deltaTime * turningSpeed);


       }

}