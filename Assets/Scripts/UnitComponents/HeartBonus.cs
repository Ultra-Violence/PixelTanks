using UnityEngine;

public class Heart : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player"){
            other.GetComponent<StatsUnit>().GetHealth(1);
            Destroy(gameObject);
        }
    }
}
