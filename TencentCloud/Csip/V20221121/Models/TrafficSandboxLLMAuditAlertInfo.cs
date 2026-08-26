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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TrafficSandboxLLMAuditAlertInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>告警记录 ID</p>
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// <p>归属资产类型<br>枚举值：<br>HOST：主机<br>CONTAINER：容器</p>
        /// </summary>
        [JsonProperty("BelongAssetType")]
        public string BelongAssetType{ get; set; }

        /// <summary>
        /// <p>命中的用户规则 ID</p>
        /// </summary>
        [JsonProperty("RuleID")]
        public long? RuleID{ get; set; }

        /// <summary>
        /// <p>命中的用户规则名称</p>
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// <p>命中的 LLM 审计系统规则名称</p>
        /// </summary>
        [JsonProperty("SystemRuleName")]
        public string SystemRuleName{ get; set; }

        /// <summary>
        /// <p>实例 ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>实例名称</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>集群 ID</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>容器 ID</p>
        /// </summary>
        [JsonProperty("ContainerId")]
        public string ContainerId{ get; set; }

        /// <summary>
        /// <p>容器名称</p>
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// <p>命中风险描述</p>
        /// </summary>
        [JsonProperty("HitPayload")]
        public string HitPayload{ get; set; }

        /// <summary>
        /// <p>命中动作<br>枚举值：<br>PASS：加白<br>BLOCK：拦截并告警<br>MONITOR：告警</p>
        /// </summary>
        [JsonProperty("RuleAction")]
        public string RuleAction{ get; set; }

        /// <summary>
        /// <p>告警级别<br>枚举值：<br>INFO：提示<br>LOW：低危<br>MEDIUM：中危<br>HIGH：高危<br>CRITICAL：严重</p>
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// <p>处理状态<br>枚举值：<br>PENDING：未处理<br>HANDLED：已处理<br>IGNORE：已忽略<br>PASS：已加白<br>BLOCK：已拦截</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>首次告警时间</p>
        /// </summary>
        [JsonProperty("FirstAlertTime")]
        public string FirstAlertTime{ get; set; }

        /// <summary>
        /// <p>最后告警时间</p>
        /// </summary>
        [JsonProperty("LastAlertTime")]
        public string LastAlertTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "BelongAssetType", this.BelongAssetType);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "SystemRuleName", this.SystemRuleName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ContainerId", this.ContainerId);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "HitPayload", this.HitPayload);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "FirstAlertTime", this.FirstAlertTime);
            this.SetParamSimple(map, prefix + "LastAlertTime", this.LastAlertTime);
        }
    }
}

