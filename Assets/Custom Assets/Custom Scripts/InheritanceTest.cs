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

        // ��ü �޼���
        nate.Stealth();
        jack.Hunt();

        // nate.GetSpeed(); : �Ұ�, �ڽ� Ŭ������ ������ ���� ������ Ŭ������ �ƴ� �ν��Ͻ����� �������� ����

        // Animal���� ������ �޼���
        nate.Print();
        jack.Print();

        // List ����
        List<Animal> animals = new()
        {
            nate,
            jack
        };

        // ��ȸ�ϸ鼭 ����� �޼��� ȣ��
        foreach (Animal animal in animals)
        {
            animal.Print();
        }
    }
}
