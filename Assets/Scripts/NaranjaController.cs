using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaranjaController : MonoBehaviour
{
   private void OnTriggerEnter2D(Collider2D collider)
   {
       ScoreManager.scoreManager.RaiseScore(1);

       Destroy(transform.parent.gameObject);
   }
}
