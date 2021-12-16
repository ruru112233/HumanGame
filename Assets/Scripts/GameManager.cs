using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CheckPoint;

public class GameManager : MonoBehaviour
{
    public StockPanel stockPanel;
    public SpriteManager spriteManager;

    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // �t���O�̏�����
        FlagManager.OffFlagAll();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
