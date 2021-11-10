using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchValue : MonoBehaviour
{
    public int value;

    public CharacterSheet CS;
    private int woodchoppingskill;
    public GameObject player;

    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.Find("Player");
        CS = player.GetComponent<CharacterSheet>();
    }

    // Update is called once per frame
    void Update()
    {
        value = CS.woodchoppingskill;

    }
}
