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

    public class TrafficSandboxLLMAuditRuleInfo : AbstractModel
    {
        
        /// <summary>
        /// 规则 ID
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 规则级别
        /// 枚举值：
        /// INFO：提示
        /// LOW：低危
        /// MEDIUM：中危
        /// HIGH：高危
        /// CRITICAL：严重
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// 规则状态
        /// 枚举值：
        /// ON：启用
        /// OFF：禁用
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 归属资产类型
        /// 枚举值：
        /// HOST：主机
        /// CONTAINER：容器
        /// </summary>
        [JsonProperty("BelongAssetType")]
        public string BelongAssetType{ get; set; }

        /// <summary>
        /// 引用的系统规则列表（含系统规则名称）
        /// </summary>
        [JsonProperty("SystemRuleRefs")]
        public TrafficSandboxLLMAuditRuleRef[] SystemRuleRefs{ get; set; }

        /// <summary>
        /// 规则的生效范围
        /// </summary>
        [JsonProperty("EffectScope")]
        public TrafficSandboxEffectScope EffectScope{ get; set; }

        /// <summary>
        /// 未生效资产列表：策略目标生效资产中流量沙箱插件未已安装（TrafficPluginState.InstallStatus 不为 INSTALLED）的 AI Agent 资产，返回机器的 InstanceId / ContainerId 及 TrafficPluginState。无未生效资产时返回空数组
        /// </summary>
        [JsonProperty("InactiveAssets")]
        public TrafficSandboxInactiveAsset[] InactiveAssets{ get; set; }

        /// <summary>
        /// 创建时间
        /// 参数格式：YYYY-MM-DDTHH:mm:ssZ（ISO8601格式）
        /// </summary>
        [JsonProperty("InsertTime")]
        public string InsertTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// 参数格式：YYYY-MM-DDTHH:mm:ssZ（ISO8601格式）
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 规则动作
        /// 枚举值：
        /// PASS：加白
        /// BLOCK：拦截并告警
        /// MONITOR：告警
        /// </summary>
        [JsonProperty("RuleAction")]
        public string RuleAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "BelongAssetType", this.BelongAssetType);
            this.SetParamArrayObj(map, prefix + "SystemRuleRefs.", this.SystemRuleRefs);
            this.SetParamObj(map, prefix + "EffectScope.", this.EffectScope);
            this.SetParamArrayObj(map, prefix + "InactiveAssets.", this.InactiveAssets);
            this.SetParamSimple(map, prefix + "InsertTime", this.InsertTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "RuleAction", this.RuleAction);
        }
    }
}

