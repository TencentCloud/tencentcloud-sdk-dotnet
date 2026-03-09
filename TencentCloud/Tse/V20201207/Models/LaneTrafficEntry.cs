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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LaneTrafficEntry : AbstractModel
    {
        
        /// <summary>
        ///    // type == "polarismesh.cn/gateway/tse-gateway, 则 selector 为 TSEGatewaySelector
        ///    // type == "polarismesh.cn/gateway/spring-cloud-gateway", 则 selector 为 ServiceGatewaySelector
        ///    // type == "polarismesh.cn/service, 则 selector 为 ServiceSelector
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EntryType")]
        public string EntryType{ get; set; }

        /// <summary>
        /// TSE云原生网关选择器
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TSEGatewaySelector")]
        public TSEGatewaySelector TSEGatewaySelector{ get; set; }

        /// <summary>
        /// 微服务网关选择器
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceGatewaySelector")]
        public ServiceGatewaySelector ServiceGatewaySelector{ get; set; }

        /// <summary>
        /// 普通微服务选择器
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceSelector")]
        public ServiceSelector ServiceSelector{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EntryType", this.EntryType);
            this.SetParamObj(map, prefix + "TSEGatewaySelector.", this.TSEGatewaySelector);
            this.SetParamObj(map, prefix + "ServiceGatewaySelector.", this.ServiceGatewaySelector);
            this.SetParamObj(map, prefix + "ServiceSelector.", this.ServiceSelector);
        }
    }
}

