using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//   [RequireComponent(typeof(Rigidbody))]   �̰ž��� ��ũ��Ʈ�� �־ ������ٵ� ���� ���� ������ٵ� �����ϴ°͵� ���´�
public class bullet : MonoBehaviour
{
    private Rigidbody Rb;
    [SerializeField]
    private int bulletspeed;
    private void Awake()
    {
        Rb = GetComponent<Rigidbody>();
    }
    private void Start()
    {
        Rb.velocity = transform.forward*bulletspeed;
        Destroy(Rb, 5f);
    }
}
