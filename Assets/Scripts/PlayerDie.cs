using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDie : MonoBehaviour, IDataPersistence
{
    public int deathCount = 0;

    float deathTime = 0f;

    void Update()
    {
        deathTime += Time.deltaTime;
        if(deathTime >= 3)
        {
            deathTime = 0;
            deathCount++;
        }
     
    }

    public void LoadData(GameData data)
    {
        this.deathCount = data.deathCount;
    }

    public void SaveData(GameData data)
    {
        data.deathCount = this.deathCount;
    }
}
