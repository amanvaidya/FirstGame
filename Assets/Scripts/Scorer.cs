using UnityEngine;

public class Scro : MonoBehaviour
{
    int hits = 0;
   private void OnCollisionEnter(Collision other) {
     if(other.gameObject.tag != "Hit")
     {    
          Debug.Log("You've bumped into a thing this many times: " + hits++);
     }
   }
}
