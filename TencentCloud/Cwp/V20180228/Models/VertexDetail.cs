/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VertexDetail : AbstractModel
    {
        
        /// <summary>
        /// 该节点类型，进程:1；网络:2；文件:3；ssh:4
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 各节点类型用到的时间，2022-11-29 00:00:00 格式
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// 告警信息
        /// </summary>
        [JsonProperty("AlarmInfo")]
        public AlarmInfo[] AlarmInfo{ get; set; }

        /// <summary>
        /// 进程名，当该节点为进程时生效
        /// </summary>
        [JsonProperty("ProcName")]
        public string ProcName{ get; set; }

        /// <summary>
        /// 命令行，当该节点为进程时生效
        /// </summary>
        [JsonProperty("CmdLine")]
        public string CmdLine{ get; set; }

        /// <summary>
        /// 进程id，当该节点为进程时生效
        /// </summary>
        [JsonProperty("Pid")]
        public string Pid{ get; set; }

        /// <summary>
        /// 文件md5，当该节点为文件时生效
        /// </summary>
        [JsonProperty("FileMd5")]
        public string FileMd5{ get; set; }

        /// <summary>
        /// 文件写入内容，当该节点为文件时生效
        /// </summary>
        [JsonProperty("FileContent")]
        public string FileContent{ get; set; }

        /// <summary>
        /// 文件路径，当该节点为文件时生效
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }

        /// <summary>
        /// 文件创建时间，当该节点为文件时生效
        /// </summary>
        [JsonProperty("FileCreateTime")]
        public string FileCreateTime{ get; set; }

        /// <summary>
        /// 请求目的地址，当该节点为网络时生效
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 目标端口，当该节点为网络时生效
        /// </summary>
        [JsonProperty("DstPort")]
        public ulong? DstPort{ get; set; }

        /// <summary>
        /// 登录源ip，当该节点为ssh时生效
        /// </summary>
        [JsonProperty("SrcIP")]
        public string SrcIP{ get; set; }

        /// <summary>
        /// 登录用户名用户组，当该节点为ssh时生效
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// 漏洞名称，当该节点为漏洞时生效
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// 漏洞利用时间，当该节点为漏洞时生效
        /// </summary>
        [JsonProperty("VulTime")]
        public string VulTime{ get; set; }

        /// <summary>
        /// http请求内容，当该节点为漏洞时生效
        /// </summary>
        [JsonProperty("HttpContent")]
        public string HttpContent{ get; set; }

        /// <summary>
        /// 漏洞利用者来源ip，当该节点为漏洞时生效
        /// </summary>
        [JsonProperty("VulSrcIP")]
        public string VulSrcIP{ get; set; }

        /// <summary>
        /// 点id
        /// </summary>
        [JsonProperty("VertexId")]
        public string VertexId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamArrayObj(map, prefix + "AlarmInfo.", this.AlarmInfo);
            this.SetParamSimple(map, prefix + "ProcName", this.ProcName);
            this.SetParamSimple(map, prefix + "CmdLine", this.CmdLine);
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
            this.SetParamSimple(map, prefix + "FileMd5", this.FileMd5);
            this.SetParamSimple(map, prefix + "FileContent", this.FileContent);
            this.SetParamSimple(map, prefix + "FilePath", this.FilePath);
            this.SetParamSimple(map, prefix + "FileCreateTime", this.FileCreateTime);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "DstPort", this.DstPort);
            this.SetParamSimple(map, prefix + "SrcIP", this.SrcIP);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "VulTime", this.VulTime);
            this.SetParamSimple(map, prefix + "HttpContent", this.HttpContent);
            this.SetParamSimple(map, prefix + "VulSrcIP", this.VulSrcIP);
            this.SetParamSimple(map, prefix + "VertexId", this.VertexId);
        }
    }
}

