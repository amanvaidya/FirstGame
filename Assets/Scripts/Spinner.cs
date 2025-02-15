using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xRotate = 0;
    [SerializeField] float yRotate = 1;
    [SerializeField] float zRotate = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xRotate, yRotate, zRotate);
    }
}
