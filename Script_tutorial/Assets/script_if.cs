using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_if : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 제어문 사용하기
        int herbNum = 1;
        if (herbNum == 1)
        {
            Debug.Log("체력을 50 회복");
        }

        int hp = 180;
            if (hp <= 50)
            {
                Debug.Log("도망!");
            }
            else if (hp >= 200)
            {
                Debug.Log("공격!");
            }
            else
            {
                Debug.Log("방어!");             
            }

        // 변수 범위
        int x = 1;
        if (x == 1)
        {
            int y = 2;
            Debug.Log(x);
            Debug.Log(y);
        }
        // Debug.Log(y); # y의 범위는 현재 중괄호 안이기 때문에 오류
    }

}
