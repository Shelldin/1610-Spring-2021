﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHud : MonoBehaviour
{
   public Text nameText;
   public Text levelText;
   public Slider hpSlider;

   public void setHUD(Unit unit)
   {
      nameText.text = unit.unitName;
      levelText.text = "Lvl " + unit.unitLevel;
      hpSlider.maxValue = unit.maxHp;
      hpSlider.value = unit.currentHp;
   }

   public void SetHP(int hp)
   {
      hpSlider.value = hp;
   }
}
