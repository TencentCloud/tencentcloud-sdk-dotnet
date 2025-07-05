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

namespace TencentCloud.Iotcloud.V20210408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeGatewayBindDevicesRequest : AbstractModel
    {
        
        /// <summary>
        /// 网关设备的产品ID
        /// </summary>
        [JsonProperty("GatewayProductId")]
        public string GatewayProductId{ get; set; }

        /// <summary>
        /// 网关设备的设备名
        /// </summary>
        [JsonProperty("GatewayDeviceName")]
        public string GatewayDeviceName{ get; set; }

        /// <summary>
        /// 偏移量，Offset从0开始
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 分页的页大小
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// LoRa产品的ID
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayProductId", this.GatewayProductId);
            this.SetParamSimple(map, prefix + "GatewayDeviceName", this.GatewayDeviceName);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
        }
    }
}

