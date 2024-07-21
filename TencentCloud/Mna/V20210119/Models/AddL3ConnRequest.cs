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

    public class AddL3ConnRequest : AbstractModel
    {
        
        /// <summary>
        /// 设置互通网段CIDR1，支持： 10.0.0.0 - 10.255.255.255，172.16.0.0 - 172.31.255.255，192.168.0.0 - 192.168.255.255
        /// </summary>
        [JsonProperty("Cidr1")]
        public string Cidr1{ get; set; }

        /// <summary>
        /// 设置互通网段CIDR2，支持： 10.0.0.0 - 10.255.255.255，172.16.0.0 - 172.31.255.255，192.168.0.0 - 192.168.255.255
        /// </summary>
        [JsonProperty("Cidr2")]
        public string Cidr2{ get; set; }

        /// <summary>
        /// CIDR1对应的设备ID
        /// </summary>
        [JsonProperty("DeviceId1")]
        public string DeviceId1{ get; set; }

        /// <summary>
        /// CIDR2对应的设备ID
        /// </summary>
        [JsonProperty("DeviceId2")]
        public string DeviceId2{ get; set; }

        /// <summary>
        /// 规则描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Cidr1", this.Cidr1);
            this.SetParamSimple(map, prefix + "Cidr2", this.Cidr2);
            this.SetParamSimple(map, prefix + "DeviceId1", this.DeviceId1);
            this.SetParamSimple(map, prefix + "DeviceId2", this.DeviceId2);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

