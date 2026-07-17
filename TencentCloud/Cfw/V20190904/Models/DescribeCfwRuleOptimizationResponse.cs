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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCfwRuleOptimizationResponse : AbstractModel
    {
        
        /// <summary>
        /// 查询结果。UTF-8 JSON object 字符串；调用方需解析 Response.Data。示例仅展示代表性字段；完整结果还包含 rule_type_name、rule_total、rule_active、rule_skipped_geo_or_cloud、dimension_skipped、thresholds 和 generated_at，finding 还包含 risk_level、affected_rule_uuids、affected_rule_seqs、recommendation_action、reason 和 evidence。结果过大时返回摘要，不返回 findings，并增加 truncated 和 truncated_reason。
        /// </summary>
        [JsonProperty("Data")]
        public string Data{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Data", this.Data);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

