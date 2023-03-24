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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAclRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例id信息
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// Acl资源类型,目前只支持Topic,枚举值列表：Topic
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// 匹配类型，目前支持前缀匹配与预设策略，枚举值列表：PREFIXED/PRESET
        /// </summary>
        [JsonProperty("PatternType")]
        public string PatternType{ get; set; }

        /// <summary>
        /// 规则名称
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 设置的ACL规则列表
        /// </summary>
        [JsonProperty("RuleList")]
        public AclRuleInfo[] RuleList{ get; set; }

        /// <summary>
        /// 表示前缀匹配的前缀的值
        /// </summary>
        [JsonProperty("Pattern")]
        public string Pattern{ get; set; }

        /// <summary>
        /// 预设ACL规则是否应用到新增的topic中
        /// </summary>
        [JsonProperty("IsApplied")]
        public long? IsApplied{ get; set; }

        /// <summary>
        /// ACL规则的备注
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "PatternType", this.PatternType);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamArrayObj(map, prefix + "RuleList.", this.RuleList);
            this.SetParamSimple(map, prefix + "Pattern", this.Pattern);
            this.SetParamSimple(map, prefix + "IsApplied", this.IsApplied);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
        }
    }
}

