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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HighPriorityRoute : AbstractModel
    {
        
        /// <summary>
        /// 高优路由表唯一 ID
        /// </summary>
        [JsonProperty("HighPriorityRouteTableId")]
        public string HighPriorityRouteTableId{ get; set; }

        /// <summary>
        /// 高优路由表条目唯一 ID
        /// </summary>
        [JsonProperty("HighPriorityRouteId")]
        public string HighPriorityRouteId{ get; set; }

        /// <summary>
        /// 目标网段
        /// </summary>
        [JsonProperty("DestinationCidrBlock")]
        public string DestinationCidrBlock{ get; set; }

        /// <summary>
        /// 网关类型
        /// </summary>
        [JsonProperty("GatewayType")]
        public string GatewayType{ get; set; }

        /// <summary>
        /// 网关唯一ID
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// 高优路由条目描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// ECMP算法，支持的算法有：ECMP_QUINTUPLE_HASH：五元组hash，ECMP_SOURCE_DESTINATION_IP_HASH：源和目的IP hash，ECMP_DESTINATION_IP_HASH：目的IP hash，ECMP_SOURCE_IP_HASH：源IP hash。
        /// </summary>
        [JsonProperty("SubnetRouteAlgorithm")]
        public string SubnetRouteAlgorithm{ get; set; }

        /// <summary>
        /// 出参展示，是否为CDC属性高优路由
        /// </summary>
        [JsonProperty("IsCdc")]
        public bool? IsCdc{ get; set; }

        /// <summary>
        /// 出参展示，CDC 唯一ID
        /// </summary>
        [JsonProperty("CdcId")]
        public string CdcId{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HighPriorityRouteTableId", this.HighPriorityRouteTableId);
            this.SetParamSimple(map, prefix + "HighPriorityRouteId", this.HighPriorityRouteId);
            this.SetParamSimple(map, prefix + "DestinationCidrBlock", this.DestinationCidrBlock);
            this.SetParamSimple(map, prefix + "GatewayType", this.GatewayType);
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "SubnetRouteAlgorithm", this.SubnetRouteAlgorithm);
            this.SetParamSimple(map, prefix + "IsCdc", this.IsCdc);
            this.SetParamSimple(map, prefix + "CdcId", this.CdcId);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
        }
    }
}

