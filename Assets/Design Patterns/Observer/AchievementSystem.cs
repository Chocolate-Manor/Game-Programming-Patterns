using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is...the observer.
/// Observer is who holds the object need to be called.
/// If the subject is observed, observer is called. 
/// </summary>
public class AchievementSystem : MonoBehaviour
{
    private void Start()
    {
       PlayerPrefs.DeleteAll();

       PointOfInterest.OnPointOfInterestEntered += OnPointOfInterestEntered;
    }
    
    /// <summary>
    /// This method will be executed whenever the PointOfInterest event is triggered.
    /// Since it has been added to the event listener. 
    /// </summary>
    /// <param name="poi"></param>
    private void OnPointOfInterestEntered(PointOfInterest poi)
    {
        string achievementKey = "achievement-" + poi.name;

        if (PlayerPrefs.GetInt(achievementKey) == 1)
        {
            return;
        }
        else
        {
            PlayerPrefs.SetInt(achievementKey, 1);
            Debug.Log("Unlocked " + achievementKey);
        }
    }
}
