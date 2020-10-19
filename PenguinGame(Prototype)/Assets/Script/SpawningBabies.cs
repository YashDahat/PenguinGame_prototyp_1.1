using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UIElements;

public class SpawningBabies : MonoBehaviour
{
    GameObject babies;
    public List<GameObject> spawninig_pts = new List<GameObject>();
    int[] ran = new int[5];
    // Start is called before the first frame update
    void Start()
    {
        SpawnBabies();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SelectingRandomPts()
    {
        int temp = 0;
        for (int i = 0; i < 5; i++)
        { 
            temp = UnityEngine.Random.Range(0 + (i * (spawninig_pts.Count / 5)), 
                ((spawninig_pts.Count / 5) - 1) + (i * (spawninig_pts.Count / 5)));//(0,7),(8,15),(16,23),....(..,39)
            ran[i] = temp;
        }
    }
    void SpawnBabies()
    {
        SelectingRandomPts();
        int j= 0;
 
        for (int i=0;i<spawninig_pts.Count;i++)
        {
            if (j<5 && ran[j] ==i)
            {
                spawninig_pts[i].GetComponent<SpriteRenderer>().color = Color.blue;
                spawninig_pts[i].GetComponent<Babies>().InvokeTimer();
                j+=1;
            }
            else
            {
                spawninig_pts[i].GetComponent<SpriteRenderer>().color = Color.black;
            }
        }
    }

    bool Searchinarr(int[] arr, int srch)
    {
        bool state = false;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == srch)
            {
                state = true;
                break;
            }

        }
        return state;
    }
    
}
