using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TestFoodData : MonoBehaviour
{
    public int playerHP = 0;
    public GameObject[] heartUI = new GameObject[5];

    public FoodData[] foods = new FoodData[10];

    public Image foodImg;

    public Sprite[] foodListImg = new Sprite[10];

    public int[] foodTaste = new int[3];

    public float tasteSweet = 0;
    public float tasteSalt = 0;
    public float tasteFat = 0;

    public int tasteLimit = 2;
    public int selectLimit = 5;
    public int select = 0;

    public Slider barSweet;
    public Slider barSalt;
    public Slider barFat;

    public Button buttonPass;
    public Button buttonSelect;

    public TMP_Text textGameOver;

    [TextArea]
    public string[] textList = new string[9];

    public GameObject PanelUIGameOver;

    public int order = 0;

    // Start is called before the first frame update
    void Start()
    {
        OnRandomFoodData();
        OnLoadImage();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnRandomFoodData()
    {
        int rand = Random.Range(0, foods.Length);
        int[] slot = new int[9];

        foodListImg[0] = foods[rand].foodImg;
        foodTaste[0] = foods[rand].tasteID;
        slot[0] = rand;

        do
        {
            rand = Random.Range(0, foods.Length);
        }
        while (rand == slot[0]);

        foodListImg[1] = foods[rand].foodImg;
        foodTaste[1] = foods[rand].tasteID;
        slot[1] = rand;

        do
        {
            rand = Random.Range(0, foods.Length);
        }
        while (rand == slot[0] || rand == slot[1]);

        foodListImg[2] = foods[rand].foodImg;
        foodTaste[2] = foods[rand].tasteID;
        slot[2] = rand;

        do
        {
            rand = Random.Range(0, foods.Length);
        }
        while (rand == slot[0] || rand == slot[1] || rand == slot[2]);

        foodListImg[3] = foods[rand].foodImg;
        foodTaste[3] = foods[rand].tasteID;
        slot[3] = rand;

        do
        {
            rand = Random.Range(0, foods.Length);
        }
        while (rand == slot[0] || rand == slot[1] || rand == slot[2] || rand == slot[3]);

        foodListImg[4] = foods[rand].foodImg;
        foodTaste[4] = foods[rand].tasteID;
        slot[4] = rand;

        do
        {
            rand = Random.Range(0, foods.Length);
        }
        while (rand == slot[0] || rand == slot[1] || rand == slot[2] || rand == slot[3] || rand == slot[4]);

        foodListImg[5] = foods[rand].foodImg;
        foodTaste[5] = foods[rand].tasteID;
        slot[5] = rand;

        do
        {
            rand = Random.Range(0, foods.Length);
        }
        while (rand == slot[0] || rand == slot[1] || rand == slot[2] || rand == slot[3] || rand == slot[4] || rand == slot[5]);

        foodListImg[6] = foods[rand].foodImg;
        foodTaste[6] = foods[rand].tasteID;
        slot[6] = rand;

        do
        {
            rand = Random.Range(0, foods.Length);
        }
        while (rand == slot[0] || rand == slot[1] || rand == slot[2] || rand == slot[3] || rand == slot[4] || rand == slot[5] || rand == slot[6]);

        foodListImg[7] = foods[rand].foodImg;
        foodTaste[7] = foods[rand].tasteID;
        slot[7] = rand;

        do
        {
            rand = Random.Range(0, foods.Length);
        }
        while (rand == slot[0] || rand == slot[1] || rand == slot[2] || rand == slot[3] || rand == slot[4] || rand == slot[5] || rand == slot[6] || rand == slot[7]);

        foodListImg[8] = foods[rand].foodImg;
        foodTaste[8] = foods[rand].tasteID;
        slot[8] = rand;

        do
        {
            rand = Random.Range(0, foods.Length);
        }
        while (rand == slot[0] || rand == slot[1] || rand == slot[2] || rand == slot[3] || rand == slot[4] || rand == slot[5] || rand == slot[6] || rand == slot[7] || rand == slot[8]);

        foodListImg[9] = foods[rand].foodImg;
        foodTaste[9] = foods[rand].tasteID;
    }

    public void OnAddTaste()
    {
        if (foodTaste[order] == 0)
        {
            tasteSweet ++;
        }
        else if (foodTaste[order] == 1)
        {
            tasteSalt ++;
        }
        else if (foodTaste[order] == 2)
        {
            tasteFat ++;
        }

        OnBarTasteUpdate();
    }

    void OnBarTasteUpdate()
    {
        barSweet.value = tasteSweet;
        barSalt.value = tasteSalt;
        barFat.value = tasteFat;
    }

    public void OnHungry()
    {
        playerHP--;
        OnCheckHP();
    }

    public void OnCheckHP()
    {
        for (int i = 0; i < heartUI.Length; i++)
        {
            heartUI[i].SetActive(false);
        }

        if (playerHP >= 5)
        {
            for (int i = 0; i < heartUI.Length; i++)
            {
                heartUI[i].SetActive(true);
            }
        }

        else if (playerHP == 4)
        {
            for (int i = 0; i < heartUI.Length-1; i++)
            {
                heartUI[i].SetActive(true);
            }
        }

        else if (playerHP == 3)
        {
            for (int i = 0; i < heartUI.Length-2; i++)
            {
                heartUI[i].SetActive(true);
            }
        }

        else if (playerHP == 2)
        {
            for (int i = 0; i < heartUI.Length-3; i++)
            {
                heartUI[i].SetActive(true);
            }
        } 
        
        else if (playerHP == 1)
        {
                heartUI[0].SetActive(true);
        } 
        
        else
        {
            buttonPass.interactable = false;
        }
    }

    public void OnNextChoice(bool isPass)
    {
        if (order < foodListImg.Length - 1) { 
            order++;
        if (!isPass && select < selectLimit)
            {
                select++;
                if(select >= selectLimit) buttonSelect.interactable = false;
            }

            OnLoadImage();

        } 
        
        else
        {
            OnGameOver();
        }

    }

    public void OnLoadImage()
    {

        foodImg.sprite = foodListImg[order];
    }

    public void OnGameOver()
    {
        bool[] check = {false,false,false};

        if(tasteSweet > tasteLimit)
        {
            check[0] = true;
        }

        if (tasteFat > tasteLimit)
        {
            check[1] = true;
        }

        if (tasteSalt > tasteLimit)
        {
            check[2] = true;
        }

        if (check[0] && check[1] && check[2]) //sweet fat salt over
        {
            textGameOver.text = textList[0];
        }

        else if (check[0] && !check[1] && check[2]) //sweet salt over
        {
            textGameOver.text = textList[1];
        }

        else if (check[0] && check[1] && !check[2]) //sweet fat over
        {
            textGameOver.text = textList[2];
        }

        else if (!check[0] && check[1] && check[2]) // fat salt over
        {
            textGameOver.text = textList[3];
        }

        else if (!check[0] && !check[1] && check[2]) //salt over
        {
            textGameOver.text = textList[4];
        }

        else if (!check[0] && check[1] && !check[2]) //fat over
        {
            textGameOver.text = textList[5];
        }

        else if (!check[0] && !check[1] && !check[2]) //no over
        {
            textGameOver.text = textList[6];
        }
        else if (check[0] && !check[1] && !check[2]) //sweet over 
        {
            textGameOver.text = textList[7];
        }

        /*else
        {
            textGameOver.text = textList[7];
        }*/

        PanelUIGameOver.SetActive(true);
        barSweet.gameObject.SetActive(true);
        barFat.gameObject.SetActive(true);
        barSalt.gameObject.SetActive(true);
    }
}
