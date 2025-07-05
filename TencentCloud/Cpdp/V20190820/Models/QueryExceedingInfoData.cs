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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryExceedingInfoData : AbstractModel
    {
        
        /// <summary>
        /// 代理商ID。
        /// </summary>
        [JsonProperty("AgentId")]
        public string AgentId{ get; set; }

        /// <summary>
        /// 代理商名称。
        /// </summary>
        [JsonProperty("AgentName")]
        public string AgentName{ get; set; }

        /// <summary>
        /// 主播ID。当入参Dimension为ANCHOR或ORDER时，该字段才会有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AnchorId")]
        public string AnchorId{ get; set; }

        /// <summary>
        /// 主播名称。当入参Dimension为ANCHOR或ORDER时，该字段才会有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AnchorName")]
        public string AnchorName{ get; set; }

        /// <summary>
        /// 订单号。当入参Dimension为ORDER时，该字段才会有值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 超额类型。目前支持 AGENT_EXCEED_100 和 ANCHOR_EXCEED_100_12 两种类型。
        /// </summary>
        [JsonProperty("ExceedingType")]
        public string ExceedingType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AgentId", this.AgentId);
            this.SetParamSimple(map, prefix + "AgentName", this.AgentName);
            this.SetParamSimple(map, prefix + "AnchorId", this.AnchorId);
            this.SetParamSimple(map, prefix + "AnchorName", this.AnchorName);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "ExceedingType", this.ExceedingType);
        }
    }
}

