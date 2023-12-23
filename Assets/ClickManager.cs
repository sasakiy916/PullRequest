using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickManager : MonoBehaviour
{
    public Test player;
    public Test enemy;
    public void SetTarget(Test test)
    {
        this.player = test;
    }
    public void SetTarget()
    {
        Debug.Log(EventSystem.current.gameObject.name);
        this.player = EventSystem.current.currentSelectedGameObject.GetComponent<Test>();
    }
    public void SetEnemy(Test test)
    {
        this.enemy = test;
    }
    void Start()
    {

    }

    void Update()
    {

    }
}
