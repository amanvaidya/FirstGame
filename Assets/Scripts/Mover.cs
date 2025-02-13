using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal");
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical");

        transform.Translate(xValue,yValue,zValue);
    }
}
