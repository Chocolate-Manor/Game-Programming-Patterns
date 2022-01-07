using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is the subject. 
/// </summary>
public class PointOfInterest : MonoBehaviour
{ 
    //static so it can be accessed everywhere from the class.
    //this is a list of method that need to be executed when we trigger the event.
    //Only a single such list exists.
   public static event Action<PointOfInterest> OnPointOfInterestEntered;

   [SerializeField] private string name;

   /// <summary>
   /// We trigger the event. And every method associated with OnPointInterestEntered will be called. 
   /// </summary>
   /// <param name="col"></param>
   private void OnTriggerEnter2D(Collider2D col)
   {
       if (OnPointOfInterestEntered != null)
       {
           //need to pass in a PointOfInterest to call the event. Because it is defined as Action<PointOfInterest>
           OnPointOfInterestEntered(this);
           
           Debug.Log("You entered " + name);
       } 
   }
}
