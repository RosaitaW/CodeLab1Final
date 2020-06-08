 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BloodManager : MonoBehaviour
{
    public GameObject b01;
    public GameObject b02;
    public GameObject b03;
    public GameObject b04;
    public GameObject b05;
    public GameObject b06;
    public GameObject b07;
    public GameObject b08;
    public GameObject b09;
    public GameObject b10;
    float Injuries=0;
    public GameObject FE01;
    public GameObject FE02;
    public GameObject FE03;
    public GameObject FE04;
    public GameObject FE05;
    public GameObject FE06;
    public GameObject FE07;
    public GameObject FE08;
    public GameObject FE09;
    public GameObject FE10;
    bool f01=false;
    bool f02 = false;
    bool f03 = false;
    bool f04 = false;
    bool f05 = false;
    bool f06 = false;
    bool f07 = false;
    bool f08 = false;
    bool f09 = false;
    bool f10 = false;
    // Start is called before the first frame update
    void Start()
    {
        b01.SetActive(false);
        b02.SetActive(false);
        b03.SetActive(false);
        b04.SetActive(false);
        b05.SetActive(false);
        b06.SetActive(false);
        b07.SetActive(false);
        b08.SetActive(false);
        b09.SetActive(false);
        b10.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (FE01.GetComponent<FakeEyes>().IsBleed)
        {
            b01.SetActive(true);
            if (!f01)
            {
                f01 = true;
                Injuries++;
            }
        }
        if (FE02.GetComponent<FakeEyes>().IsBleed)
        {
            b02.SetActive(true);
            if (!f02)
            {
                f02 = true;
                Injuries++;
            }
        }
        if (FE03.GetComponent<FakeEyes>().IsBleed)
        {
            b03.SetActive(true);
            if (!f03)
            {
                f03 = true;
                Injuries++;
            }
        }
        if (FE04.GetComponent<FakeEyes>().IsBleed)
        {
            b04.SetActive(true);
            if (!f04)
            {
                f04 = true;
                Injuries++;
            }
        }
        if (FE05.GetComponent<FakeEyes>().IsBleed)
        {
            b05.SetActive(true);
            if (!f05)
            {
                f05 = true;
                Injuries++;
            }
        }
        if (FE06.GetComponent<FakeEyes>().IsBleed)
        {
            b06.SetActive(true);
            if (!f06)
            {
                f06 = true;
                Injuries++;
            }
        }
        if (FE07.GetComponent<FakeEyes>().IsBleed)
        {
            b07.SetActive(true);
            if (!f07)
            {
                f07 = true;
                Injuries++;
            }
        }
        if (FE08.GetComponent<FakeEyes>().IsBleed)
        {
            b08.SetActive(true);
            if (!f08)
            {
                f08 = true;
                Injuries++;
            }
        }
        if (FE09.GetComponent<FakeEyes>().IsBleed)
        {
            b09.SetActive(true);
            if (!f09)
            {
                f09 = true;
                Injuries++;
            }
        }
        if (FE10.GetComponent<FakeEyes>().IsBleed)
        {
            b10.SetActive(true);
            if (!f10)
            {
                f10 = true;
                Injuries++;
            }
        }
        if (Injuries >= 7f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        }
    }
}
