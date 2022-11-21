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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDeviceLocationSolveRequest : AbstractModel
    {
        
        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 定位解析类型，wifi或GNSSNavigation
        /// </summary>
        [JsonProperty("LocationType")]
        public string LocationType{ get; set; }

        /// <summary>
        /// LoRaEdge卫星导航电文
        /// </summary>
        [JsonProperty("GNSSNavigation")]
        public string GNSSNavigation{ get; set; }

        /// <summary>
        /// wifi信息
        /// </summary>
        [JsonProperty("WiFiInfo")]
        public WifiInfo[] WiFiInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "LocationType", this.LocationType);
            this.SetParamSimple(map, prefix + "GNSSNavigation", this.GNSSNavigation);
            this.SetParamArrayObj(map, prefix + "WiFiInfo.", this.WiFiInfo);
        }
    }
}

