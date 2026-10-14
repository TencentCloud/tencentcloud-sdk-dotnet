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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBAuditLogsResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>满足条件的总条数。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// <p>过滤后记录数。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FilteredRecords")]
        public long? FilteredRecords{ get; set; }

        /// <summary>
        /// <p>Proxy 层审计日志列表。LogType=Proxy 或 All 时返回，字段结构参见 AuditProxyLogItem。</p>
        /// </summary>
        [JsonProperty("ProxyLogs")]
        public AuditProxyLogItem[] ProxyLogs{ get; set; }

        /// <summary>
        /// <p>DB 层审计日志列表。LogType=DB 或 All 时返回，字段结构参见 AuditDBLogItem。</p>
        /// </summary>
        [JsonProperty("DBLogs")]
        public AuditDBLogItem[] DBLogs{ get; set; }

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
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "FilteredRecords", this.FilteredRecords);
            this.SetParamArrayObj(map, prefix + "ProxyLogs.", this.ProxyLogs);
            this.SetParamArrayObj(map, prefix + "DBLogs.", this.DBLogs);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

