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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExceptUserRuleScope : AbstractModel
    {
        
        /// <summary>
        /// 例外规则类型。其中complete模式代表全量数据进行例外，partial模式代表可选择指定模块指定字段进行例外，该字段取值有：
        /// <li>complete：完全跳过模式；</li>
        /// <li>partial：部分跳过模式。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 生效的模块，该字段取值有：
        /// <li>waf：托管规则；</li>
        /// <li>rate：速率限制；</li>
        /// <li>acl：自定义规则；</li>
        /// <li>cc：cc攻击防护；</li>
        /// <li>bot：Bot防护。</li>
        /// </summary>
        [JsonProperty("Modules")]
        public string[] Modules{ get; set; }

        /// <summary>
        /// 跳过部分规则ID的例外规则详情。如果为null，默认使用历史配置。
        /// </summary>
        [JsonProperty("PartialModules")]
        public PartialModule[] PartialModules{ get; set; }

        /// <summary>
        /// 跳过具体字段不去扫描的例外规则详情。如果为null，默认使用历史配置。
        /// </summary>
        [JsonProperty("SkipConditions")]
        public SkipCondition[] SkipConditions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "Modules.", this.Modules);
            this.SetParamArrayObj(map, prefix + "PartialModules.", this.PartialModules);
            this.SetParamArrayObj(map, prefix + "SkipConditions.", this.SkipConditions);
        }
    }
}

