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

namespace TencentCloud.Mqtt.V20240516.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDeviceIdentityRequest : AbstractModel
    {
        
        /// <summary>
        /// 腾讯云MQTT实例ID，从 [DescribeInstanceList](https://cloud.tencent.com/document/api/1778/111029)接口或控制台获得。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 设备id
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// 1:ENABLED-可用（默认）
        /// 2:DISABLE-不可用
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 主要签名key，不传则由系统自动生成，需要base64编码。
        /// </summary>
        [JsonProperty("PrimaryKey")]
        public string PrimaryKey{ get; set; }

        /// <summary>
        /// 次要签名key，不传则由系统自动生成，需要base64编码。
        /// </summary>
        [JsonProperty("SecondaryKey")]
        public string SecondaryKey{ get; set; }

        /// <summary>
        /// 该设备id的传播属性设置
        /// </summary>
        [JsonProperty("PropagatingProperties")]
        public PropagatingProperty[] PropagatingProperties{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PrimaryKey", this.PrimaryKey);
            this.SetParamSimple(map, prefix + "SecondaryKey", this.SecondaryKey);
            this.SetParamArrayObj(map, prefix + "PropagatingProperties.", this.PropagatingProperties);
        }
    }
}

