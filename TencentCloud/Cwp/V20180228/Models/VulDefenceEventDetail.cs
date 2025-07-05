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

    public class VulDefenceEventDetail : AbstractModel
    {
        
        /// <summary>
        /// 漏洞名称
        /// </summary>
        [JsonProperty("VulName")]
        public string VulName{ get; set; }

        /// <summary>
        /// cve编号
        /// </summary>
        [JsonProperty("CveId")]
        public string CveId{ get; set; }

        /// <summary>
        /// 漏洞事件id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 主机quuid
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// 主机名
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// 内网ip
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// 公网ip
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// 0: 尝试攻击(WeDetect) 1:尝试攻击成功(WeDetect) 2:rasp防御事件
        /// </summary>
        [JsonProperty("EventType")]
        public ulong? EventType{ get; set; }

        /// <summary>
        /// 攻击源ip
        /// </summary>
        [JsonProperty("SourceIp")]
        public string SourceIp{ get; set; }

        /// <summary>
        /// 攻击源ip地址所在城市
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// 攻击源端口
        /// </summary>
        [JsonProperty("SourcePort")]
        public ulong?[] SourcePort{ get; set; }

        /// <summary>
        /// 创建事件时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新事件时间
        /// </summary>
        [JsonProperty("MergeTime")]
        public string MergeTime{ get; set; }

        /// <summary>
        /// 事件发生次数
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// 状态 0: 待处理 1:已防御 2:已处理 3: 已忽略 4: 已删除
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// ONLINE OFFLINE
        /// </summary>
        [JsonProperty("MachineStatus")]
        public string MachineStatus{ get; set; }

        /// <summary>
        /// 漏洞描述信息
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 修复建议
        /// </summary>
        [JsonProperty("Fix")]
        public string Fix{ get; set; }

        /// <summary>
        /// 攻击payload
        /// </summary>
        [JsonProperty("NetworkPayload")]
        public string NetworkPayload{ get; set; }

        /// <summary>
        /// 关联进程pid
        /// </summary>
        [JsonProperty("Pid")]
        public long? Pid{ get; set; }

        /// <summary>
        /// 关联进程主类名
        /// </summary>
        [JsonProperty("MainClass")]
        public string MainClass{ get; set; }

        /// <summary>
        /// 堆栈信息(rasp特有)
        /// </summary>
        [JsonProperty("StackTrace")]
        public string StackTrace{ get; set; }

        /// <summary>
        /// 漏洞ID相关的事件详情(json array格式 rasp特有)
        /// </summary>
        [JsonProperty("EventDetail")]
        public string EventDetail{ get; set; }

        /// <summary>
        /// 主机失陷事件进程树(json格式 WeDetect特有)
        /// </summary>
        [JsonProperty("ExceptionPstree")]
        public string ExceptionPstree{ get; set; }

        /// <summary>
        /// 主机额外信息
        /// </summary>
        [JsonProperty("MachineExtraInfo")]
        public MachineExtraInfo MachineExtraInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VulName", this.VulName);
            this.SetParamSimple(map, prefix + "CveId", this.CveId);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "SourceIp", this.SourceIp);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamArraySimple(map, prefix + "SourcePort.", this.SourcePort);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "MergeTime", this.MergeTime);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "MachineStatus", this.MachineStatus);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Fix", this.Fix);
            this.SetParamSimple(map, prefix + "NetworkPayload", this.NetworkPayload);
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
            this.SetParamSimple(map, prefix + "MainClass", this.MainClass);
            this.SetParamSimple(map, prefix + "StackTrace", this.StackTrace);
            this.SetParamSimple(map, prefix + "EventDetail", this.EventDetail);
            this.SetParamSimple(map, prefix + "ExceptionPstree", this.ExceptionPstree);
            this.SetParamObj(map, prefix + "MachineExtraInfo.", this.MachineExtraInfo);
        }
    }
}

