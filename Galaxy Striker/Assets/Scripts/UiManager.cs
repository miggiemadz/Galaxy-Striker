using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    private TextMeshProUGUI waveCounter;
    private TextMeshProUGUI pointsCounter;
    private TextMeshProUGUI healthCounter;
    private EarthBehavior earthScript;

    private int totalPoints;

    [SerializeField] private EnemySpawner spawnerScript;

    public int TotalPoints { get => totalPoints; set => totalPoints = value; }

    void Start()
    {
        waveCounter = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        pointsCounter = transform.GetChild(1).GetComponent<TextMeshProUGUI>();
        healthCounter = transform.GetChild(2).GetComponent<TextMeshProUGUI>();
        earthScript = GameObject.Find("Earth").GetComponent<EarthBehavior>();
    }

    void Update()
    {
        if (earthScript.Health == 0)
        {
            Time.timeScale = 0;
        }

        healthCounter.text = "Earth's Health: " + earthScript.Health.ToString();
        pointsCounter.text = "Points: " + TotalPoints.ToString();

        if (spawnerScript.SpawnIndex == 30 )
        {
            waveCounter.text = "Wave Difficulty: Easy";
        }

        if (spawnerScript.SpawnIndex == 20)
        {
            waveCounter.text = "Wave Difficulty: Medium";
        }

        if (spawnerScript.SpawnIndex == 10)
        {
            waveCounter.text = "Wave Difficulty: Hard";
        }
    }
}
