using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
   public void TestButtonClick() 
    { 
        Debug.Log("TestButtonClick"); 
    }
    public void TestImagePointerEnter() 
    { 
        Debug.Log("TestImagePointerEnter"); 
    } 
    public void TestImagePointerExit() 
    {
         Debug.Log("TestImagePointerExit"); 
    }
}
