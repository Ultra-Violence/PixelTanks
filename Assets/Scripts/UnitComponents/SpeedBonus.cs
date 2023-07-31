using UnityEngine;

public class SpeedBonus : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            other.GetComponent<PlayerController>().SetSpeed();
            Destroy(gameObject);
        }
    }
}
