using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEnter : MonoBehaviour
{
    public GameObject changeSceneToRestaurant;
    public GameObject changeSceneToGym;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.CompareTag("Restaurant"))
        {
            changeSceneToRestaurant.SetActive(true);
        }
        else
        {
            changeSceneToRestaurant.SetActive(false);
        }
        if (target.gameObject.CompareTag("Gym"))
        {
            changeSceneToGym.SetActive(true);
        }
        else
        {
            changeSceneToGym.SetActive(false);
        }
    }
}
