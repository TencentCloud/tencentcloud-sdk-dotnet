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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AllocationRuleExpression : AbstractModel
    {
        
        /// <summary>
        /// RuleKey：分账维度
        /// 枚举值：
        /// ownerUin - 使用者UIN,
        /// operateUin - 操作者UIN,
        /// businessCode - 产品一层编码,
        /// productCode - 产品二层编码,
        /// itemCode - 产品四层编码,
        /// projectId - 项目ID,
        /// regionId - 地域ID,
        /// resourceId - 资源ID,
        /// tag - 标签键值对,
        /// payMode - 计费模式,
        /// instanceType - 实例类型,
        /// actionType - 交易类型
        /// </summary>
        [JsonProperty("RuleKey")]
        public string RuleKey{ get; set; }

        /// <summary>
        /// 分账维度规则
        /// 枚举值：
        /// in - 是
        /// not in - 不是
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// 分账维度值，例如当RuleKey为businessCode时，["p_cbs","p_sqlserver"]表示产品一层是"p_cbs","p_sqlserver"的费用
        /// </summary>
        [JsonProperty("RuleValue")]
        public string[] RuleValue{ get; set; }

        /// <summary>
        /// 分账逻辑连接词，枚举值如下：
        /// and - 且
        /// or - 或
        /// </summary>
        [JsonProperty("Connectors")]
        public string Connectors{ get; set; }

        /// <summary>
        /// 嵌套规则
        /// </summary>
        [JsonProperty("Children")]
        public AllocationRuleExpression[] Children{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleKey", this.RuleKey);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamArraySimple(map, prefix + "RuleValue.", this.RuleValue);
            this.SetParamSimple(map, prefix + "Connectors", this.Connectors);
            this.SetParamArrayObj(map, prefix + "Children.", this.Children);
        }
    }
}

