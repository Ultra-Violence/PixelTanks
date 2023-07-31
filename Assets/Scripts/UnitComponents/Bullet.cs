using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed = 5;

    void FixedUpdate()
    {
        transform.Translate(Vector2.up * speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Cell"){
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        else if(other.gameObject.tag == "MetalCell"){
            Destroy(gameObject);
        }
        else if(other.gameObject.tag == "Enemy"){
            other.GetComponent<StatsUnit>().TakeDamage(1);
            Destroy(gameObject);
        }
    }

}
