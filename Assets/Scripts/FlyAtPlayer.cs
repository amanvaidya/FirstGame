using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    Vector3 playerPosition;
    [SerializeField] float speed = 0.01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerPosition = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    void MoveToPlayer(){
        //playerPosition = player.transform.position;//this is useful if we want to follow the player
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * speed);
    }
    void DestroyWhenReached(){
        if(transform.position == playerPosition){
            Destroy(gameObject);
        }
    }
}
