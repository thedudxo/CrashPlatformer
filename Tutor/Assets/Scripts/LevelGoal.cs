using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGoal : MonoBehaviour
{
    [SerializeField] GameObject winScreen;

    private void OnTriggerEnter(Collider other)
    {
        winScreen.SetActive(true);
    }
}
