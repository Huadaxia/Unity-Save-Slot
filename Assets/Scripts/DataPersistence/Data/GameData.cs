using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData 
{

    public long lastUpdated;
    public int deathCount;
    public Vector3 playerPosition;
    public SerializableDictionary<string, bool> coinsCollected;

    public GameData()
    {
        this.deathCount = 0;
        this.playerPosition = new Vector3(-9f, -2f, 0);
        coinsCollected = new SerializableDictionary<string, bool>();
    }

    public int GetPercentageComplete()
    {
        int totalCollected = 0;
        foreach(bool collected in coinsCollected.Values)
        {
            if(collected)
            {
                totalCollected++;
            }
        }

        int percentageCompleted = -1;
        if(coinsCollected.Count != 0)
        {
            percentageCompleted = (totalCollected * 100 / coinsCollected.Count);
        }
        return percentageCompleted;
    }
}
