using UnityEngine;
public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;
    MeshRenderer renderer;
    Rigidbody rigidBody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        renderer.enabled = false;
        rigidBody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timeToWait){
            renderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
