using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]

public class Unit : ScriptableObject
{
   public string unitName;
   public int unitLevel;
   public int dmgStat;
   public int maxHp;
   public int currentHp;
}
