﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class LoginPanelManager : MonoBehaviour
    {

        Text eventCodeText, userNameText;
        UIManager manager;
        // Use this for initialization
        void Start()
        {
            eventCodeText = GetComponentsInChildren<Text>()[1];
            userNameText = GetComponentsInChildren<Text>()[3];
            manager = GetComponentInParent<UIManager>();
            GetComponentInChildren<Button>().onClick.AddListener(() => { this.Submit(); });
        }

        // Update is called once per frame
        void Update()
        {

        }

        void Submit()
        {
            manager.sEventCode = eventCodeText.text;
            manager.sUserName = userNameText.text;
            Debug.Log("Submitted thing" + manager.sEventCode);
            StartCoroutine(manager.ChangePanel("mainPanel"));
            //StartCoroutine(manager.DownloadEvent());
        }
    }
}