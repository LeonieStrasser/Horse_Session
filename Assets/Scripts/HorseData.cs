using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class HorseData : ScriptableObject
{
    public new string name;
    
    public int trust;
    public int distanceRespect;
    public int humanIsFood;
    public int curiosity;
    public int preasureAvoidness;
}
