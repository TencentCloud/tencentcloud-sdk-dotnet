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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BotManagedRule : AbstractModel
    {
        
        /// <summary>
        /// 触发规则后的处置方式，取值有：
        /// <li>drop：拦截；</li>
        /// <li>trans：放行；</li>
        /// <li>alg：Javascript挑战；</li>
        /// <li>monitor：观察。</li>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 本规则的ID。仅出参使用。
        /// </summary>
        [JsonProperty("RuleID")]
        public long? RuleID{ get; set; }

        /// <summary>
        /// 放行的规则ID。默认所有规则不配置放行。
        /// </summary>
        [JsonProperty("TransManagedIds")]
        public long?[] TransManagedIds{ get; set; }

        /// <summary>
        /// JS挑战的规则ID。默认所有规则不配置JS挑战。
        /// </summary>
        [JsonProperty("AlgManagedIds")]
        public long?[] AlgManagedIds{ get; set; }

        /// <summary>
        /// 数字验证码的规则ID。默认所有规则不配置数字验证码。
        /// </summary>
        [JsonProperty("CapManagedIds")]
        public long?[] CapManagedIds{ get; set; }

        /// <summary>
        /// 观察的规则ID。默认所有规则不配置观察。
        /// </summary>
        [JsonProperty("MonManagedIds")]
        public long?[] MonManagedIds{ get; set; }

        /// <summary>
        /// 拦截的规则ID。默认所有规则不配置拦截。
        /// </summary>
        [JsonProperty("DropManagedIds")]
        public long?[] DropManagedIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "RuleID", this.RuleID);
            this.SetParamArraySimple(map, prefix + "TransManagedIds.", this.TransManagedIds);
            this.SetParamArraySimple(map, prefix + "AlgManagedIds.", this.AlgManagedIds);
            this.SetParamArraySimple(map, prefix + "CapManagedIds.", this.CapManagedIds);
            this.SetParamArraySimple(map, prefix + "MonManagedIds.", this.MonManagedIds);
            this.SetParamArraySimple(map, prefix + "DropManagedIds.", this.DropManagedIds);
        }
    }
}

