using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InheritanceTest : MonoBehaviour
{
    void Start()
    {
        Cat nate = new()
        {
            name = "Nate",
            weight = 1.5f,
            year = 3
        };

        Dog jack = new()
        {
            name = "Jack",
            weight = 5,
            year = 2
        };

        // 자체 메서드
        nate.Stealth();
        jack.Hunt();

        // nate.GetSpeed(); : 불가, 자식 클래스가 접근할 수는 있지만 클래스가 아닌 인스턴스에는 열려있지 않음

        // Animal에서 생성한 메서드
        nate.Print();
        jack.Print();

        // List 생성
        List<Animal> animals = new()
        {
            nate,
            jack
        };

        // 순회하면서 공통된 메서드 호출
        foreach (Animal animal in animals)
        {
            animal.Print();
        }
    }
}
