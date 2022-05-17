using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//You need to setup a caneva with a text component called "UIText" to make this script work

public class VRConsole : MonoBehaviour
{


    static public void Clear() //Clear the VR console
    {
        GameObject.Find("UIText").GetComponent<Text>().text = "";
    }

    static public void DebugLog(string txt) //Print a line in the VR Console
    {
        string text = GameObject.Find("UIText").GetComponent<Text>().text;
        if (text.Length > 750) 
        {
            
            text = text.Substring(0,text.IndexOf('\n')+1);
        }
        GameObject.Find("UIText").GetComponent<Text>().text = text + "\n" + txt;
        
    }
}
