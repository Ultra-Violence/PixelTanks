using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;

    private Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {
        rb.velocity = Vector2.zero;
        if(Input.GetKey(KeyCode.W)){    
            transform.rotation = new Quaternion(0, 0, 0, 0);
            rb.velocity += Vector2.up * speed * Time.fixedDeltaTime;
        }
        else if(Input.GetKey(KeyCode.S)){  
            transform.rotation = new Quaternion(0, 0, 180, 0);  
            rb.velocity += Vector2.down * speed * Time.fixedDeltaTime;
        }
        else if(Input.GetKey(KeyCode.D)){   
            transform.rotation = new Quaternion(0, 0, -90, 90); 
            rb.velocity += Vector2.right * speed * Time.fixedDeltaTime;
        }
        else if(Input.GetKey(KeyCode.A)){ 
            transform.rotation = new Quaternion(0, 0, 90, 90);
            rb.velocity += Vector2.left * speed * Time.fixedDeltaTime;
        }
    }

    public void SetSpeed(){
        speed = speed*2;
        Invoke("OldSpeed", 10f);
    }

    public void OldSpeed(){
        speed = speed/2;;
    }
}
