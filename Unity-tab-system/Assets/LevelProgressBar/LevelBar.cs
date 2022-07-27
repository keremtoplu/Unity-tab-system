using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelBar : MonoBehaviour
{
    [SerializeField]
    private Transform player;

    [SerializeField]
    private Transform endLine;

    [SerializeField]

    private Slider slider;

    private float maxDistance;

    private void Start()
    {
        maxDistance = getDistance();

    }

    private void Update()
    {
        if (player.position.y <= maxDistance && player.position.y <= endLine.position.y)
        {
            float distance = 1 - (getDistance() / maxDistance);
            SetProgress(distance);
        }
    }

    private void SetProgress(float p)
    {
        slider.value = p;
    }



    private float getDistance()
    {
        return Vector2.Distance(player.position, endLine.position);
    }
}
