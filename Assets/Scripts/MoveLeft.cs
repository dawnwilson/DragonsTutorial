using System;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float Speed = 1;
    private Enemy enemy;

    private void Awake()
    {
        enemy = GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * Speed, Space.World);

        if (transform.position.x <= -12)
        {
            //could have written as: transform.position += Vector3.right * 24;
            transform.position += new Vector3(24, 0, 0);
            ShowRandomSprite();
            enemy?.Respawn();
        }
    }

    private void ShowRandomSprite()
    {

        int childCount = transform.childCount;
        int index = UnityEngine.Random.Range(0, childCount);

        // need to run a for loop so that all other children are deactivated with SetActive()
        for (int i = 0; i < childCount; i++)
        {
            Transform child = transform.GetChild(i);
            bool shouldShow = index == i;
            child.gameObject.SetActive(shouldShow);
            // or could have removed bool variable and just done: child.gameObject.SetActive(index == i);
        }
    }

    private void OnEnable()
    {
        ShowRandomSprite();
    }
}
