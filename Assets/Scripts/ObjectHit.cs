using UnityEngine;

public class ObjectHit : MonoBehaviour
{
   private void OnCollisionEnter(Collision other) {
         if(other.gameObject.tag == "Player")
         {
             Debug.Log("Player Hit");
             GetComponent<MeshRenderer>().material.color = Color.red;
             gameObject.tag = "Hit";
         }       
   }
}
