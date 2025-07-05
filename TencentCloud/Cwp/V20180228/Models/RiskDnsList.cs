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

    public class RiskDnsList : AbstractModel
    {
        
        /// <summary>
        /// 对外访问域名
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 访问次数
        /// </summary>
        [JsonProperty("AccessCount")]
        public ulong? AccessCount{ get; set; }

        /// <summary>
        /// 进程名
        /// </summary>
        [JsonProperty("ProcessName")]
        public string ProcessName{ get; set; }

        /// <summary>
        /// 进程MD5
        /// </summary>
        [JsonProperty("ProcessMd5")]
        public string ProcessMd5{ get; set; }

        /// <summary>
        /// 是否为全局规则，0否，1是
        /// </summary>
        [JsonProperty("GlobalRuleId")]
        public ulong? GlobalRuleId{ get; set; }

        /// <summary>
        /// 用户规则id
        /// </summary>
        [JsonProperty("UserRuleId")]
        public ulong? UserRuleId{ get; set; }

        /// <summary>
        /// 状态；0-待处理，2-已加白，3-非信任状态，4-已处理，5-已忽略
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 首次访问时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 最近访问时间
        /// </summary>
        [JsonProperty("MergeTime")]
        public string MergeTime{ get; set; }

        /// <summary>
        /// 唯一 Quuid
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// 主机ip
        /// </summary>
        [JsonProperty("HostIp")]
        public string HostIp{ get; set; }

        /// <summary>
        /// 别名
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 唯一ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 参考
        /// </summary>
        [JsonProperty("Reference")]
        public string Reference{ get; set; }

        /// <summary>
        /// 命令行
        /// </summary>
        [JsonProperty("CmdLine")]
        public string CmdLine{ get; set; }

        /// <summary>
        /// 进程号
        /// </summary>
        [JsonProperty("Pid")]
        public ulong? Pid{ get; set; }

        /// <summary>
        /// 唯一UUID
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// 建议方案
        /// </summary>
        [JsonProperty("SuggestScheme")]
        public string SuggestScheme{ get; set; }

        /// <summary>
        /// 标签特性
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// 外网ip
        /// </summary>
        [JsonProperty("MachineWanIp")]
        public string MachineWanIp{ get; set; }

        /// <summary>
        /// 主机在线状态[OFFLINE:离线|ONLINE:在线|UNKNOWN:未知]
        /// </summary>
        [JsonProperty("MachineStatus")]
        public string MachineStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "AccessCount", this.AccessCount);
            this.SetParamSimple(map, prefix + "ProcessName", this.ProcessName);
            this.SetParamSimple(map, prefix + "ProcessMd5", this.ProcessMd5);
            this.SetParamSimple(map, prefix + "GlobalRuleId", this.GlobalRuleId);
            this.SetParamSimple(map, prefix + "UserRuleId", this.UserRuleId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "MergeTime", this.MergeTime);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "HostIp", this.HostIp);
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Reference", this.Reference);
            this.SetParamSimple(map, prefix + "CmdLine", this.CmdLine);
            this.SetParamSimple(map, prefix + "Pid", this.Pid);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "SuggestScheme", this.SuggestScheme);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "MachineWanIp", this.MachineWanIp);
            this.SetParamSimple(map, prefix + "MachineStatus", this.MachineStatus);
        }
    }
}

