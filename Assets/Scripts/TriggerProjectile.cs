using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject[] projectiles;

    private void OnTriggerEnter(Collider other) {
        Debug.Log("Tag"+ other.gameObject.tag);
        if(other.gameObject.tag == "Player")
        {   
            Debug.Log("Projectiles"+ projectiles.Length);
            foreach (GameObject projectile in projectiles)
            {
                Debug.Log("Projectile activated"+ projectile);
                projectile.SetActive(true);
                Debug.Log("Projectile set to active");
            }
            Debug.Log("TriggerProjectile destroyed");
            Destroy(gameObject);
        }
    }
}