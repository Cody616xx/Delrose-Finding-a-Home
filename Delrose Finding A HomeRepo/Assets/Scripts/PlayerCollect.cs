using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollect : MonoBehaviour
{

    public Invintory INVIN;
    public GameObject invintory;
    public CharacterSheet CS;
    private int woodchoppingskill;
    public GameObject player;

    // Start is called before the first frame update
    void Awake()
    { 
        player = GameObject.Find("Player");
        CS = player.GetComponent<CharacterSheet>();
        invintory = GameObject.Find("InvintoryCanvas");
        INVIN = invintory.GetComponent<Invintory>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Branch"))//Looks for an item with this tag
        {
            Debug.Log("CollectedWood");
            Destroy(other.gameObject);//We can determine what we destroy of what we collided with.
            INVIN.wood += CS.woodchoppingskill;
        }

        if (other.CompareTag("Stone"))
        {
            INVIN.stone += 1;
            Destroy(other);
        }

        if (other.CompareTag("Water"))//Looks for an item with this tag
        {
            INVIN.water += 1;
            Destroy(other);
        }
    }
}