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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateAlertRuleStateRequest : AbstractModel
    {
        
        /// <summary>
        /// 规则 ID 列表
        /// </summary>
        [JsonProperty("RuleIds")]
        public string[] RuleIds{ get; set; }

        /// <summary>
        /// Prometheus 实例 ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 规则状态码，取值如下：
        /// <li>2=RuleEnabled</li>
        /// <li>3=RuleDisabled</li>
        /// 默认状态码为 2 启用。
        /// </summary>
        [JsonProperty("RuleState")]
        public long? RuleState{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "RuleIds.", this.RuleIds);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "RuleState", this.RuleState);
        }
    }
}

