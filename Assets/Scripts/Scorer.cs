using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
   private void OnCollisionEnter(Collision other) {
    Debug.Log("other.gameObject.tag: " + other.gameObject.tag);
     if(other.gameObject.tag != "Hit")
     {    
          Debug.Log("You've bumped into a thing this many times: " + hits++);
     }
   }
}
