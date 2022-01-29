using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int coins = 0;
    public int lostObjects = 0;
    public int mission1 = 1;   //0 Not started | 1 started | 2 Completed
    public int mission2 = 0;
    public int mission3 = 0;
    public int mission4 = 0;
    bool startSideQuest = false;
    bool idle = false;
    public Text coinText;
    int test = 0;
    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
        if (mission1 == 2)
        {
            idle = true;
        }
        if (mission2 == 2)
        {
            idle = true;
        }
        if (mission3 == 2)
        {
            idle = true;
        }
        if (mission4 == 2)
        {
            idle = true;
        }
        if(startSideQuest)
        {

        }
        //coinText.text = "Coins:"+coins;
    }

}
