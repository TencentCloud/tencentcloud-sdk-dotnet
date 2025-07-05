/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

    public class RiskProcessEvent : AbstractModel
    {
        
        /// <summary>
        /// 事件ID
        /// </summary>
        [JsonProperty("EventId")]
        public long? EventId{ get; set; }

        /// <summary>
        /// 主机名称
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// 主机IP
        /// </summary>
        [JsonProperty("HostIp")]
        public string HostIp{ get; set; }

        /// <summary>
        /// 外网IP
        /// </summary>
        [JsonProperty("WanIp")]
        public string WanIp{ get; set; }

        /// <summary>
        /// 进程ID
        /// </summary>
        [JsonProperty("ProcessId")]
        public long? ProcessId{ get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }

        /// <summary>
        /// 执行命令
        /// </summary>
        [JsonProperty("CmdLine")]
        public string CmdLine{ get; set; }

        /// <summary>
        /// 进程启动时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 最近检测时间
        /// </summary>
        [JsonProperty("DetectTime")]
        public string DetectTime{ get; set; }

        /// <summary>
        /// 病毒名称
        /// </summary>
        [JsonProperty("VirusName")]
        public string VirusName{ get; set; }

        /// <summary>
        /// 木马检测平台 [1:云查杀引擎|2:TAV|3:binaryAi|4:异常行为|5:威胁情报]
        /// </summary>
        [JsonProperty("CheckPlatform")]
        public string[] CheckPlatform{ get; set; }

        /// <summary>
        /// 病毒标签
        /// </summary>
        [JsonProperty("VirusTags")]
        public string[] VirusTags{ get; set; }

        /// <summary>
        /// 威胁描述
        /// </summary>
        [JsonProperty("ThreatDesc")]
        public string ThreatDesc{ get; set; }

        /// <summary>
        /// 建议方案
        /// </summary>
        [JsonProperty("SuggestSolution")]
        public string SuggestSolution{ get; set; }

        /// <summary>
        /// 参考链接
        /// </summary>
        [JsonProperty("ReferenceLink")]
        public string ReferenceLink{ get; set; }

        /// <summary>
        /// 处理状态[0待处理;1已处理;2查杀中;3已查杀;4已退出;5忽略]
        /// </summary>
        [JsonProperty("HandleStatus")]
        public long? HandleStatus{ get; set; }

        /// <summary>
        /// 主机在线状态
        /// </summary>
        [JsonProperty("OnlineStatus")]
        public long? OnlineStatus{ get; set; }

        /// <summary>
        /// 附加信息
        /// </summary>
        [JsonProperty("MachineExtraInfo")]
        public MachineExtraInfo MachineExtraInfo{ get; set; }

        /// <summary>
        /// 主机uuid
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "HostIp", this.HostIp);
            this.SetParamSimple(map, prefix + "WanIp", this.WanIp);
            this.SetParamSimple(map, prefix + "ProcessId", this.ProcessId);
            this.SetParamSimple(map, prefix + "FilePath", this.FilePath);
            this.SetParamSimple(map, prefix + "CmdLine", this.CmdLine);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "DetectTime", this.DetectTime);
            this.SetParamSimple(map, prefix + "VirusName", this.VirusName);
            this.SetParamArraySimple(map, prefix + "CheckPlatform.", this.CheckPlatform);
            this.SetParamArraySimple(map, prefix + "VirusTags.", this.VirusTags);
            this.SetParamSimple(map, prefix + "ThreatDesc", this.ThreatDesc);
            this.SetParamSimple(map, prefix + "SuggestSolution", this.SuggestSolution);
            this.SetParamSimple(map, prefix + "ReferenceLink", this.ReferenceLink);
            this.SetParamSimple(map, prefix + "HandleStatus", this.HandleStatus);
            this.SetParamSimple(map, prefix + "OnlineStatus", this.OnlineStatus);
            this.SetParamObj(map, prefix + "MachineExtraInfo.", this.MachineExtraInfo);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
        }
    }
}

