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

    public class BashEventNew : AbstractModel
    {
        
        /// <summary>
        /// <p>数据ID</p>
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// <p>主机安全ID</p>
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// <p>主机ID</p>
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// <p>主机内网IP</p>
        /// </summary>
        [JsonProperty("HostIp")]
        public string HostIp{ get; set; }

        /// <summary>
        /// <p>执行用户名</p>
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// <p>平台类型</p>
        /// </summary>
        [JsonProperty("Platform")]
        public ulong? Platform{ get; set; }

        /// <summary>
        /// <p>执行命令</p>
        /// </summary>
        [JsonProperty("BashCmd")]
        public string BashCmd{ get; set; }

        /// <summary>
        /// <p>规则ID</p>
        /// </summary>
        [JsonProperty("RuleId")]
        public ulong? RuleId{ get; set; }

        /// <summary>
        /// <p>规则名称</p>
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// <p>规则等级：1-高 2-中 3-低</p>
        /// </summary>
        [JsonProperty("RuleLevel")]
        public ulong? RuleLevel{ get; set; }

        /// <summary>
        /// <p>处理状态： 0 = 待处理 1= 已处理, 2 = 已加白， 3 = 已忽略</p>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>发生时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>主机名</p>
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// <p>0: bash日志 1: 实时监控(雷霆版)</p>
        /// </summary>
        [JsonProperty("DetectBy")]
        public ulong? DetectBy{ get; set; }

        /// <summary>
        /// <p>进程id</p>
        /// </summary>
        [JsonProperty("Pid")]
        public string Pid{ get; set; }

        /// <summary>
        /// <p>进程名称</p>
        /// </summary>
        [JsonProperty("Exe")]
        public string Exe{ get; set; }

        /// <summary>
        /// <p>处理时间</p>
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// <p>规则类别  0=系统规则，1=用户规则</p>
        /// </summary>
        [JsonProperty("RuleCategory")]
        public ulong? RuleCategory{ get; set; }

        /// <summary>
        /// <p>转义后的正则表达式</p>
        /// </summary>
        [JsonProperty("RegexBashCmd")]
        public string RegexBashCmd{ get; set; }

        /// <summary>
        /// <p>转义后的正则表达式</p>
        /// </summary>
        [JsonProperty("RegexExe")]
        public string RegexExe{ get; set; }

        /// <summary>
        /// <p>0:普通 1:专业版 2:旗舰版</p>
        /// </summary>
        [JsonProperty("MachineType")]
        public long? MachineType{ get; set; }

        /// <summary>
        /// <p>机器额外信息</p>
        /// </summary>
        [JsonProperty("MachineExtraInfo")]
        public MachineExtraInfo MachineExtraInfo{ get; set; }

        /// <summary>
        /// <p>告警次数：同一聚合维度当天的告警命中次数，老数据为空</p>
        /// </summary>
        [JsonProperty("EventCount")]
        public ulong? EventCount{ get; set; }

        /// <summary>
        /// <p>首次发现时间（格式 yyyy-MM-dd HH:mm:ss）</p>
        /// </summary>
        [JsonProperty("FirstDetectTime")]
        public string FirstDetectTime{ get; set; }

        /// <summary>
        /// <p>最近发现时间（格式 yyyy-MM-dd HH:mm:ss）</p>
        /// </summary>
        [JsonProperty("LatestDetectTime")]
        public string LatestDetectTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "HostIp", this.HostIp);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "BashCmd", this.BashCmd);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "RuleLevel", this.RuleLevel);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "DetectBy", this.DetectBy);
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
            this.SetParamSimple(map, prefix + "Exe", this.Exe);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "RuleCategory", this.RuleCategory);
            this.SetParamSimple(map, prefix + "RegexBashCmd", this.RegexBashCmd);
            this.SetParamSimple(map, prefix + "RegexExe", this.RegexExe);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamObj(map, prefix + "MachineExtraInfo.", this.MachineExtraInfo);
            this.SetParamSimple(map, prefix + "EventCount", this.EventCount);
            this.SetParamSimple(map, prefix + "FirstDetectTime", this.FirstDetectTime);
            this.SetParamSimple(map, prefix + "LatestDetectTime", this.LatestDetectTime);
        }
    }
}

