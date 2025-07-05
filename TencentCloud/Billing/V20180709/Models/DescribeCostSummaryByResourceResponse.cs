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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCostSummaryByResourceResponse : AbstractModel
    {
        
        /// <summary>
        /// 数据是否准备好，0未准备好，1准备好
        /// </summary>
        [JsonProperty("Ready")]
        public ulong? Ready{ get; set; }

        /// <summary>
        /// 消耗详情
        /// </summary>
        [JsonProperty("Total")]
        public ConsumptionSummaryTotal Total{ get; set; }

        /// <summary>
        /// 过滤条件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConditionValue")]
        public ConsumptionResourceSummaryConditionValue ConditionValue{ get; set; }

        /// <summary>
        /// 记录数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RecordNum")]
        public ulong? RecordNum{ get; set; }

        /// <summary>
        /// 资源消耗详情
        /// </summary>
        [JsonProperty("Data")]
        public ConsumptionResourceSummaryDataItem[] Data{ get; set; }

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
            this.SetParamSimple(map, prefix + "Ready", this.Ready);
            this.SetParamObj(map, prefix + "Total.", this.Total);
            this.SetParamObj(map, prefix + "ConditionValue.", this.ConditionValue);
            this.SetParamSimple(map, prefix + "RecordNum", this.RecordNum);
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

