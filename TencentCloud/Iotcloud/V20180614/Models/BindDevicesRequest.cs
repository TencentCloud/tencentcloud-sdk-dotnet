/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Iotcloud.V20180614.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BindDevicesRequest : AbstractModel
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
        /// 被绑定设备的产品ID
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 被绑定的多个设备名
        /// </summary>
        [JsonProperty("DeviceNames")]
        public string[] DeviceNames{ get; set; }

        /// <summary>
        /// 中兴CLAA设备的绑定需要skey，普通的设备不需要
        /// </summary>
        [JsonProperty("Skey")]
        public string Skey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayProductId", this.GatewayProductId);
            this.SetParamSimple(map, prefix + "GatewayDeviceName", this.GatewayDeviceName);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamArraySimple(map, prefix + "DeviceNames.", this.DeviceNames);
            this.SetParamSimple(map, prefix + "Skey", this.Skey);
        }
    }
}

