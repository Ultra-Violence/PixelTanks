using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] private GameObject bulletPref;

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(bulletPref, transform.position, transform.rotation);
            GetComponent<AudioSource>().Play();
        }
    }
}
