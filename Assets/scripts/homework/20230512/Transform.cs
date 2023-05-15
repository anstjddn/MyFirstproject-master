using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Transform : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 movedir;
    [SerializeField]
    private float MovePower;
    [SerializeField]
    private float RotatePower;

    [Header("shooter")]
    [SerializeField]
    private GameObject bulletprefabs;
    [SerializeField]
    private Transform bulletPoint;
    [SerializeField]
    private float repectTime;
     private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();
        Rotate();

    }
    private void Move()
    {
        transform.Translate(Vector3.forward*movedir.x*MovePower * Time.deltaTime);
    }

    private void Rotate()
    {
        transform.Rotate(Vector3.up, movedir.z * RotatePower * Time.deltaTime, Space.Self);

    }

    private void OnMove(InputValue value)
    {
        movedir.x = value.Get<Vector2>().y;
        movedir.z = value.Get<Vector2>().x;
    }
    private void OnFire(InputValue value)
    {
        Instantiate(bulletprefabs, bulletPoint.transform.position, bulletPoint.transform.rotation);     // 새로운 프리펩을 만들어 씬에 배치

    }

    private Coroutine bulletRoutine;

    IEnumerator BulletMakeRoutine()
    {
        while (true)
        {
            Instantiate(bulletprefabs, bulletPoint.transform.position, bulletPoint.transform.rotation);
            yield return new WaitForSeconds(repectTime);
        }
    }

    private void OnRepeatFire(InputValue value)
    {
        if (value.isPressed)
        {
            bulletRoutine = StartCoroutine(BulletMakeRoutine());
        }
        else StopCoroutine(bulletRoutine);
    }
}
