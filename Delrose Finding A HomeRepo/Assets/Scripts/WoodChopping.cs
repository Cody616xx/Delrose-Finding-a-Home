using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodChopping : MonoBehaviour
{
    public bool chopAble;
    public bool chopped;
    public float chopProgress = 5;

    public CharacterSheet CS;
    private int woodchoppingskill;
    public GameObject player;
    public GameObject branch;
    

    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.Find("Player");
        CS = player.GetComponent<CharacterSheet>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        chop();
        
    }

    private void OnTriggerStay(Collider other)
    {
        chopAble = true;
    }

    private void OnTriggerExit(Collider other)
    {
        chopAble = false;
    }

    void chop()
    {
        if (chopAble == true && chopped == false)
        {
            if (Input.GetKey(KeyCode.E))
            {
                chopProgress -= Time.deltaTime;
                chopProgress = Mathf.Round(chopProgress * 100000.0f) * 0.00001f; //Math for tree cutting.

                if (chopProgress == 0)
                {
                    //for (int i = 0; i < CS.woodchoppingskill; i++)
                    //{
                        //StartCoroutine(SpawnBranch());
                        //("SpawnBranch2", 5f);
                        Instantiate(branch, transform.position, Quaternion.identity);
                        
                    //}

                    chopped = true;
                    Destroy(gameObject);
                    CS.woodchoppingskill += 1; //Updating the woodchopping skill in the character sheet script every time we chop a tree.
                }

            }
        }
    }
    
    /*
    IEnumerator SpawnBranch()
    {
        Debug.Log("Executing..");
        yield return new WaitForSeconds(5f);
        Debug.Log("Spawning..");
        Instantiate(branch, transform.position, Quaternion.identity);
        Debug.Log("Spawning2..");
    }

    void SpawnBranch2()
    {
        Debug.Log("Spawning..");
        Instantiate(branch, transform.position, Quaternion.identity);
        Debug.Log("Spawning2..");
    }
    */
    
}
