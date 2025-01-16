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

namespace TencentCloud.Mna.V20210119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceDetails : AbstractModel
    {
        
        /// <summary>
        /// 设备基本信息
        /// </summary>
        [JsonProperty("DeviceBaseInfo")]
        public DeviceBaseInfo DeviceBaseInfo{ get; set; }

        /// <summary>
        /// 设备网络信息
        /// </summary>
        [JsonProperty("DeviceNetInfo")]
        public DeviceNetInfo[] DeviceNetInfo{ get; set; }

        /// <summary>
        /// 聚合服务器地址
        /// </summary>
        [JsonProperty("GatewaySite")]
        public string GatewaySite{ get; set; }

        /// <summary>
        /// 业务下行速率
        /// </summary>
        [JsonProperty("BusinessDownRate")]
        public float? BusinessDownRate{ get; set; }

        /// <summary>
        /// 业务上行速率
        /// </summary>
        [JsonProperty("BusinessUpRate")]
        public float? BusinessUpRate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "DeviceBaseInfo.", this.DeviceBaseInfo);
            this.SetParamArrayObj(map, prefix + "DeviceNetInfo.", this.DeviceNetInfo);
            this.SetParamSimple(map, prefix + "GatewaySite", this.GatewaySite);
            this.SetParamSimple(map, prefix + "BusinessDownRate", this.BusinessDownRate);
            this.SetParamSimple(map, prefix + "BusinessUpRate", this.BusinessUpRate);
        }
    }
}

