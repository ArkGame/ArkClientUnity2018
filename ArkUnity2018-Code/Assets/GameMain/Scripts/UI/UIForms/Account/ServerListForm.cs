﻿using System;
using System.Collections;
using System.Collections.Generic;
using AFMsg;
using UnityEngine;
using UnityEngine.UI;
using GameFramework;

namespace ARKGame
{
    //world server list
    public class ServerListForm : UGuiForm
    {
        [SerializeField]
        GameObject m_serverPrefab;

        [SerializeField]
        ScrollRect m_scrollRect;
        ProcedureLogin m_procedure;

#if UNITY_2017_3_OR_NEWER
        protected override void OnInit(object userData)
#else
        protected internal override void OnInit(object userData)
#endif
        {
            m_procedure = (ProcedureLogin)userData;

            var listInfo = ARKGameEntry.AFNet.m_worldServerList;
            m_scrollRect.content.DetachChildren();
            foreach (var v in listInfo)
            {
                var go = Instantiate(m_serverPrefab, m_scrollRect.content);
                var serverItem = go.GetComponent<ServerItem>();
                serverItem.Set(v);
                serverItem.OnSelect = ServerItem_OnSelect;
            }

            base.OnInit(userData);
        }

       

#if UNITY_2017_3_OR_NEWER
        protected override void OnClose(object userData)
#else
        protected internal override void OnClose(object userData)
#endif
        {
            base.OnClose(userData);
            m_procedure = null;
        }


        private void ServerItem_OnSelect(ServerInfo serverInfo)
        {
            Log.Info("ServerItem_OnSelect.serverInfo.name="+serverInfo.Name+",serverId="+serverInfo.ServerId);
            ARKGameEntry.AFNet.RequireConnectWorld(serverInfo.ServerId);
        }
    }
}