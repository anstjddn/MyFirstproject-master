using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityMessageEvent : MonoBehaviour
{
    /************************************************************************
      * 유니티메시지 이벤트함수
      * 
      * 유니티가 보내는 메시지에 반응하는 함수
      * 포함할 경우 유니티메시지에 반응하지만, 포함하지 않을 경우 무시함
      * 스크립트는 유니티 엔진이 보내는 메시지에 반응하여 자신의 행동을 정의
      ************************************************************************/
    //MonoBehaviour는 메세지 받는 기능있다.
    // 유니티 메세지 함수 정해져있다.ex) Update //유니티 메시지 함수는 파랑색
    // Debug.log 는 로그에서 표시하는 함수


    //대표적인 이벤트 함수  --- 기술면접에서 이거 물어봄 각각의 역할도 
    private void Awake() // 처음시작햇을때 느낌  // 밥먹을때 수저세팅하는거라고 생각해
    {
        // 스크립트가 씬에 포함되었을 때 1회 호출되는 함수
        // 스크립트가 비활성화 되어 있는 경우에도 호출됨

        // 역할 : 스크립트가 필요로 하는 초기화 작업 진행
        //		  (게임상황과 무관한 초기화 작업)
        // ex) 데이터 초기화, 컴포넌트 연결
        Debug.Log("Awake");
    }

    private void OnEnable()   // start보다 먼저 호출됨
    {
        // 스크립트가 활성화될 때마다 호출

        // 역할 : 스크립트가 활성화 되었을 때 작업 진행
        Debug.Log("OnEnable");
    }

    private void Start()        // 밥먹기시작
    {
        // 스크립트가 씬에 처음으로 Update하기 직전에 1회 호출됨
        // 스크립트가 비활성화된 경우 호출되지 않음

        // 역할 : 스크립트가 필요로 하는 초기화 작업 진행
        //		  (게임상황이 영향을 줄 수 있는 작업)
        // ex) 몬스터의 플레이어 타겟선정
        Debug.Log("Start");
    }

    private void Update()
    {
        // 게임의 프레임마다 호출

        // 역할 : 핵심 게임 로직 구현
        Debug.Log("Update");
    }

    private void LateUpdate()       //게임에서 판정관련에서 이게 관여 or 카메라 같은경우
                                     // 플레이어가 움직이고 카메라가 따라가는 느낌으로
    {
        // 씬의 모든 게임오브젝트의 Update가 진행된 후 호출

        // 역할 : 게임프레임의 진행 결과가 필요한 동작이 있는 기능 구현
        // ex) 플레이어의 위치가 결정된 후에 카메라의 위치 설정
        Debug.Log("LateUpdate");
    }

    private void FixedUpdate()          //무조건 정해진 시간마다 업데이트한다
                                        // 프레임 드랍했는데 멈췄다가 갑자기 멀리가면안되므로
                                        // 대신 물리적인 처리만 넣는다 ex)충돌
    {
        // 유니티의 물리설정 단위시간마다 호출 (기본 1초에 50번)
        // Update와 다르게 프레임당 연산과 단위시간이 일정
        // 단, 게임로직 등, 연산이 많은 작업을 FixedUpdate에 구현하지 않아야 함

        // 역할 : 성능과 프레임 드랍에 영향을 받지 않아야 하는 작업
        // ex) 물리적 처리
        Debug.Log("FixedUpdate");
    }

    private void OnDisable()      //게임종료될때 호출되고 끝난다. 컨포넌트 지워도 일단 호출되긴함
    {
        // 스크립트가 비활성화될 때마다 호출

        // 역할 : 스크립트가 비활성화 되었을 때 작업 진행
        Debug.Log("OnDisable");
    }

    private void OnDestroy()    //Ondisable과 다르게 진짜 삭제될때
    {
        // 스크립트가 삭제되었을 경우 호출

        // 역할 : 스크립트의 마무리 진행
        Debug.Log("OnDestory");
    }

}
