using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palyer : MonoBehaviour, IDataPersistence
{
    [SerializeField] float speed = 1f;

    public void LoadData(GameData data)
    {
        this.transform.position = data.playerPosition;
    }

    public void SaveData(GameData data)
    {
        data.playerPosition = this.transform.position;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(Time.deltaTime * speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-Time.deltaTime * speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += new Vector3(0,Time.deltaTime * 10, 0);
        }

    }
}
