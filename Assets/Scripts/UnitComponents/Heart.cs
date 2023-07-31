using UnityEngine;

public class HeartBonus : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            other.GetComponent<StatsUnit>().GetHealth(1);
            Destroy(gameObject);
        }
    }
}
