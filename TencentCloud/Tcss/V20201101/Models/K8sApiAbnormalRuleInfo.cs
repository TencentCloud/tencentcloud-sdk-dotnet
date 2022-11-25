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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class K8sApiAbnormalRuleInfo : AbstractModel
    {
        
        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// 规则信息列表
        /// </summary>
        [JsonProperty("RuleInfoList")]
        public K8sApiAbnormalRuleScopeInfo[] RuleInfoList{ get; set; }

        /// <summary>
        /// 生效集群IDSet
        /// </summary>
        [JsonProperty("EffectClusterIDSet")]
        public string[] EffectClusterIDSet{ get; set; }

        /// <summary>
        /// 规则类型
        /// RT_SYSTEM 系统规则
        /// RT_USER 用户自定义
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// 是否所有集群生效
        /// </summary>
        [JsonProperty("EffectAllCluster")]
        public bool? EffectAllCluster{ get; set; }

        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("RuleID")]
        public string RuleID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "RuleInfoList.", this.RuleInfoList);
            this.SetParamArraySimple(map, prefix + "EffectClusterIDSet.", this.EffectClusterIDSet);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "EffectAllCluster", this.EffectAllCluster);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
        }
    }
}

