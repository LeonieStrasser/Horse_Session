using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Setting : ScriptableObject
{
    //Konsequenz aus der letzten handlung
    public bool valueImpact;
    public int trustImpact;

    
    public string mainText;

    public string buttonText1;
    public Setting nextSetting1a;       // Setting A
    public int maxTrust1a;              // Skillckeck-Bedingung für Setting A
    public int maxDistanceRespect1a;
    public Setting nextSetting1b;       // Setting B
    public int maxTrust1b;              // Skillckeck-Bedingung für Setting B
    public int maxDistanceRespect1b;
    public Setting nextSetting1c;       // unused ---- Setting C

    public string buttonText2;
    public Setting nextSetting2a;
    public int maxTrust2a;
    public int maxDistanceRespect2a;
    public Setting nextSetting2b;
    public int maxTrust2b;
    public int maxDistanceRespect2b;
    public Setting nextSetting2c; // unused

    public string buttonText3;
    public Setting nextSetting3a;
    public int maxTrust3a;
    public int maxDistanceRespect3a;
    public Setting nextSetting3b;
    public int maxTrust3b;
    public int maxDistanceRespect3b;
    public Setting nextSetting3c; // unused








}
