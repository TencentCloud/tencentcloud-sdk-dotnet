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

    public class BashEvent : AbstractModel
    {
        
        /// <summary>
        /// 数据ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 主机安全ID
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// 主机ID
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// 主机内网IP
        /// </summary>
        [JsonProperty("Hostip")]
        public string Hostip{ get; set; }

        /// <summary>
        /// 执行用户名
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// 平台类型
        /// </summary>
        [JsonProperty("Platform")]
        public ulong? Platform{ get; set; }

        /// <summary>
        /// 执行命令
        /// </summary>
        [JsonProperty("BashCmd")]
        public string BashCmd{ get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("RuleId")]
        public ulong? RuleId{ get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 规则等级：1-高 2-中 3-低
        /// </summary>
        [JsonProperty("RuleLevel")]
        public ulong? RuleLevel{ get; set; }

        /// <summary>
        /// 处理状态： 0 = 待处理 1= 已处理, 2 = 已加白， 3 = 已忽略
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 发生时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 主机名
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// 0: bash日志 1: 实时监控(雷霆版)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DetectBy")]
        public ulong? DetectBy{ get; set; }

        /// <summary>
        /// 进程id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Pid")]
        public string Pid{ get; set; }

        /// <summary>
        /// 进程名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Exe")]
        public string Exe{ get; set; }

        /// <summary>
        /// 处理时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 规则类别  0=系统规则，1=用户规则
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleCategory")]
        public ulong? RuleCategory{ get; set; }

        /// <summary>
        /// 自动生成的正则表达式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RegexBashCmd")]
        public string RegexBashCmd{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamSimple(map, prefix + "Hostip", this.Hostip);
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
        }
    }
}

