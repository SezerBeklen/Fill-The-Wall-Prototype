using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public bool isTrigger;
    public GameObject[] dragabbleObject;
    private static trigger _instance;
    public static trigger instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<trigger>();
                if (_instance == null)
                {
                    _instance = new GameObject("GameeManagerr").AddComponent<trigger>();
                }
            }
            return _instance;
        }
    }

    [HideInInspector] public trigger _trigger1;
    [HideInInspector] public trigger _trigger2;
    [HideInInspector] public trigger _trigger3;
    [HideInInspector] public trigger _trigger4;


    private void Awake()
    {
        if (_instance != null) Destroy(this);
        DontDestroyOnLoad(this);


    }



    private void Start()
    {
        _trigger1 =dragabbleObject[0].GetComponent<trigger>();
        _trigger2 = dragabbleObject[1].GetComponent<trigger>();
        _trigger3 = dragabbleObject[2].GetComponent<trigger>();
        _trigger4 = dragabbleObject[3].GetComponent<trigger>();
        isTrigger = false;
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "rack" && gameObject.tag== "photo1")
        {
            _trigger1.isTrigger = true;
            scoreControl.scoreinstance.score += 25f;
        }
        
        if(collision.gameObject.tag == "rackup" && gameObject.tag == "photo2")
        {
            _trigger2.isTrigger = true;
            scoreControl.scoreinstance.score += 25f;
        }
        
        if(collision.gameObject.tag == "rackleft" && gameObject.tag == "photo3")
        {
            _trigger3.isTrigger = true;
            scoreControl.scoreinstance.score += 25f;
        }
        
        if(collision.gameObject.tag == "rackmid" && gameObject.tag == "photo4")
        {
            _trigger4.isTrigger = true;
            scoreControl.scoreinstance.score += 25f;
        }
          
        
    }

    private void OnCollisionExit(Collision coll)
    {
        if (coll.gameObject.tag == "rack" && gameObject.tag == "photo1")
        {
            _trigger1.isTrigger = false;
            scoreControl.scoreinstance.score -= 25f;
        }

        if (coll.gameObject.tag == "rackup" && gameObject.tag == "photo2") 
        {
            _trigger2.isTrigger = false;
            scoreControl.scoreinstance.score -= 25f;
        }

        if (coll.gameObject.tag == "rackleft" && gameObject.tag == "photo3")
        {
            _trigger3.isTrigger = false;
            scoreControl.scoreinstance.score -= 25f;
        }
        
        if (coll.gameObject.tag == "rackmid" && gameObject.tag == "photo4")
        {
            _trigger4.isTrigger = false;
            scoreControl.scoreinstance.score -= 25f;
        }


    }
}
