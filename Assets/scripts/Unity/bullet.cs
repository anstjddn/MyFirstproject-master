using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//   [RequireComponent(typeof(Rigidbody))]   이거쓰면 스크립트만 넣어도 리지드바디 같이 들어가고 리지드바디 삭제하는것도 막는다
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
