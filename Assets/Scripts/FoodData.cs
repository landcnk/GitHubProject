using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "DataObjects/Foodlist", order = 1)]

public class FoodData : ScriptableObject
{
    // Start is called before the first frame update
    public Sprite foodImg;
    public int tasteID = 0; //sweet = 0, salt = 1, fat = 2
}
