using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    Vector3 playerPosition;
    [SerializeField] float speed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Awake() {
        gameObject.SetActive(false);
    }
    void Start()
    {
        playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Projectile activated inside Update()");
        MoveToPlayer();
        DestroyWhenReached();
    }

    void MoveToPlayer(){
        //playerPosition = player.transform.position;//this is useful if we want to follow the player
        Debug.Log("Projectile set to active inside MoveToPlayer()");
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed);
    }
    void DestroyWhenReached(){
        if(transform.position == playerPosition){
            Destroy(gameObject);
        }
    }
}
