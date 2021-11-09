using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Invintory : MonoBehaviour
{
    public GameObject invinUi;

    public Text textw;
    public static bool status;
    public int wood = 0;
    public int stone = 0;
    public int water = 0;

    // Start is called before the first frame update
    void Awake()
    {
        invinUi = GameObject.Find("InvintoryCanvas/Panel");
        invinUi.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        textw.text = "Wood: " + wood.ToString();

        if (Input.GetKeyDown(KeyCode.I) && status == false)
        {
            invinUi.SetActive(true);
            Debug.Log("On");
            status = true;
        }

        if (Input.GetKeyDown(KeyCode.Escape) && status == true)
        {
            invinUi.SetActive(false);
            Debug.Log("Off");
            status = false;
        }
    }
}