using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Driver : MonoBehaviour
{
    [SerializeField] float currentSpeed=5f; //this value its actually override on inspector
    [SerializeField] float steerSpeed=200f; //this value its actually override on inspector

    [SerializeField] float boostSpeed=10f;
    [SerializeField] float regularSpeed=5f;

    [SerializeField] TMP_Text boostText;

    void Start() {
        boostText.gameObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D collision) {
        if (collision.CompareTag("Boost"))
        {
            currentSpeed=boostSpeed;
            boostText.gameObject.SetActive(true);
            Destroy(collision.gameObject); //destroy our boost tag object 
        }
    }

    //we now use collisions because our bumper things are colliders
    void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.CompareTag("WorldCollision")) //we use collider cause its a collision not trigger.
        {
            currentSpeed=regularSpeed;
            boostText.gameObject.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {

        //say how fast — they're the actual speed values.
        float move=0f;
        float steer =0f;

        if(Keyboard.current.wKey.isPressed)
        {
            move=1f;
            
        }
        else if(Keyboard.current.sKey.isPressed)
        {
            move=-1f;
    
        }
        if(Keyboard.current.aKey.isPressed)
        {
            steer=1f;
            
        }
        else if(Keyboard.current.dKey.isPressed)
        {
            steer=-1f;
            
        }
        //making the movement and rotation fixed per second. 

        float moveAmount= currentSpeed *move *Time.deltaTime;
        float steerAmount= steerSpeed *steer *Time.deltaTime;

        /*
        "Move at speed 0.05... but only in the direction the player is pressing" 0.05 * 1 = move forward at 0.05
        0.05 * -1 = move backward at 0.05
        0.05 * 0 = don't move at all
        */
        transform.Translate(0,moveAmount,0); //"Every frame, shift my position by this amount on X, Y, Z"
        transform.Rotate(0,0,steerAmount);
    
        
    }

    
}
