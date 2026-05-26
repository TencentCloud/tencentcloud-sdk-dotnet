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

    public class PrometheusAlertmanagerConfigInhibitRule : AbstractModel
    {
        
        /// <summary>
        /// Source 告警的标签匹配规则，比如 "a=b"、"a!=c" 等
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceMatchers")]
        public string[] SourceMatchers{ get; set; }

        /// <summary>
        /// Target 告警的标签匹配规则，比如 "a=b"、"a!=c" 等
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetMatchers")]
        public string[] TargetMatchers{ get; set; }

        /// <summary>
        /// Source 和 Target 告警都必须有的一组标签名，比如 alertname、cluster 等
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Equal")]
        public string[] Equal{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "SourceMatchers.", this.SourceMatchers);
            this.SetParamArraySimple(map, prefix + "TargetMatchers.", this.TargetMatchers);
            this.SetParamArraySimple(map, prefix + "Equal.", this.Equal);
        }
    }
}

