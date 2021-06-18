using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_variable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 변수 선언하기
        // Hello, World를 Console 창에 출력한다.
        Debug.Log("Hello, World");

        int age;
        age = 30;
        Debug.Log(age);

        float height1 = 160.5f;;
        float height2;
        height2 = height1;
        Debug.Log(height2);

        string name;
        name = "Sera";
        Debug.Log(name);

        // 변수와 연산
        int answer;
        answer = 1 + 2;
        Debug.Log(answer);

        answer = 3 - 4;
        Debug.Log(answer);

        answer = 5 * 6;
        Debug.Log(answer);

        answer = 8 / 4;
        Debug.Log(answer);

        int n1 = 8;
        int n2 = 9;
        int answer1;
        answer1 = n1 + n2;
        Debug.Log(answer1);

        int answer2 = 10;
        answer2 += 5;
        Debug.Log(answer2);

        int answer3 = 10;
        answer3++;
        Debug.Log(answer3);

        string str1 = "happy ";
        string str2 = "birthday";
        string message;
        message = str1 + str2;
        Debug.Log(message);

        str1 += str2;
        Debug.Log(str1);

        string str = "happy ";
        int num = 123;
        string message1 = str + num;
        Debug.Log(message1);

    }

}

