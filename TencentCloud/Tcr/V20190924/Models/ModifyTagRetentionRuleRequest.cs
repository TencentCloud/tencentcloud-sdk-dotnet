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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyTagRetentionRuleRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>主实例iD</p>
        /// </summary>
        [JsonProperty("RegistryId")]
        public string RegistryId{ get; set; }

        /// <summary>
        /// <p>命名空间的Id，必须填写原有的命名空间id</p>
        /// </summary>
        [JsonProperty("NamespaceId")]
        public long? NamespaceId{ get; set; }

        /// <summary>
        /// <p>执行周期，必须填写为原来的设置</p>
        /// </summary>
        [JsonProperty("CronSetting")]
        public string CronSetting{ get; set; }

        /// <summary>
        /// <p>规则Id</p>
        /// </summary>
        [JsonProperty("RetentionId")]
        public long? RetentionId{ get; set; }

        /// <summary>
        /// <p>保留策略，当基本保留策略和高级保留策略同时配置时，优先使用高级保留策略</p>
        /// </summary>
        [JsonProperty("RetentionRule")]
        public RetentionRule RetentionRule{ get; set; }

        /// <summary>
        /// <p>高级保留策略，当基本保留策略和高级保留策略同时配置时，优先使用高级保留策略</p>
        /// </summary>
        [JsonProperty("AdvancedRuleItems")]
        public RetentionRuleItem[] AdvancedRuleItems{ get; set; }

        /// <summary>
        /// <p>是否禁用规则</p>
        /// </summary>
        [JsonProperty("Disabled")]
        public bool? Disabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegistryId", this.RegistryId);
            this.SetParamSimple(map, prefix + "NamespaceId", this.NamespaceId);
            this.SetParamSimple(map, prefix + "CronSetting", this.CronSetting);
            this.SetParamSimple(map, prefix + "RetentionId", this.RetentionId);
            this.SetParamObj(map, prefix + "RetentionRule.", this.RetentionRule);
            this.SetParamArrayObj(map, prefix + "AdvancedRuleItems.", this.AdvancedRuleItems);
            this.SetParamSimple(map, prefix + "Disabled", this.Disabled);
        }
    }
}

