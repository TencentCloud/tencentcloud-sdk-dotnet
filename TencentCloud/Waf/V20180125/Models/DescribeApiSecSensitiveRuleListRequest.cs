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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeApiSecSensitiveRuleListRequest : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 是否查询api提取规则策略，true表示查询
        /// </summary>
        [JsonProperty("IsQueryApiExtractRule")]
        public bool? IsQueryApiExtractRule{ get; set; }

        /// <summary>
        /// 是否查询api鉴权规则
        /// </summary>
        [JsonProperty("IsQueryApiPrivilegeRule")]
        public bool? IsQueryApiPrivilegeRule{ get; set; }

        /// <summary>
        /// 是否查询api场景规则
        /// </summary>
        [JsonProperty("IsQueryApiSceneRule")]
        public bool? IsQueryApiSceneRule{ get; set; }

        /// <summary>
        /// 查询鉴权配置的时候，该rule只返回鉴权配置的规则
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 是否查询api自定义事件规则
        /// </summary>
        [JsonProperty("IsQueryApiCustomEventRule")]
        public bool? IsQueryApiCustomEventRule{ get; set; }

        /// <summary>
        /// 是否查询无效api排除策略
        /// </summary>
        [JsonProperty("IsQueryApiExcludeRule")]
        public bool? IsQueryApiExcludeRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "IsQueryApiExtractRule", this.IsQueryApiExtractRule);
            this.SetParamSimple(map, prefix + "IsQueryApiPrivilegeRule", this.IsQueryApiPrivilegeRule);
            this.SetParamSimple(map, prefix + "IsQueryApiSceneRule", this.IsQueryApiSceneRule);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "IsQueryApiCustomEventRule", this.IsQueryApiCustomEventRule);
            this.SetParamSimple(map, prefix + "IsQueryApiExcludeRule", this.IsQueryApiExcludeRule);
        }
    }
}

