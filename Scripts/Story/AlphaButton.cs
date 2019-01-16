using UnityEngine;
 using System.Collections;
 using UnityEngine.UI; // Required when Using UI elements.
 
 //In import settings for the sprite, the Read/Write Enable should be ticked, and the Mesh type should be full rect
 
 public class AlphaButton : MonoBehaviour
 {
     private float AlphaThreshold = 0.05f;
 
     void Start()
     {
         this.GetComponent<Image>().alphaHitTestMinimumThreshold = AlphaThreshold;
     }
 }