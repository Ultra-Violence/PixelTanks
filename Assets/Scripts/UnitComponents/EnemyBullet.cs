using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private GameObject _target;
    [SerializeField] private float speed = 2f;

    void Start()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag("Player");
        float newDis = Mathf.Infinity;
        foreach(GameObject target in targets){
            
            float targetDis = Vector2.Distance(transform.position, new Vector2(target.GetComponent<Transform>().position.x, target.GetComponent<Transform>().position.y));
                if (targetDis < newDis)
                {
                    _target = target;
                    newDis = targetDis;
                }     
        }
    }

    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), new Vector2(_target.GetComponent<Transform>().position.x, _target.GetComponent<Transform>().position.y), speed * Time.fixedDeltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Cell"){
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
        else if(other.gameObject.tag == "MetalCell"){
            Destroy(gameObject);
        }
        else if(other.gameObject.tag == "Player"){
            other.GetComponent<StatsUnit>().TakeDamage(1);
            Destroy(gameObject);
        }
    }

}
