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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ActivateDeviceInfo : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例类型
        /// </summary>
        [JsonProperty("InstanceType")]
        public long? InstanceType{ get; set; }

        /// <summary>
        /// 设备激活信息
        /// </summary>
        [JsonProperty("DeviceActivationDetails")]
        public DeviceActivationDetail DeviceActivationDetails{ get; set; }

        /// <summary>
        /// 已注册设备类型信息
        /// </summary>
        [JsonProperty("RegisteredDeviceType")]
        public RegisteredDeviceTypeInfo RegisteredDeviceType{ get; set; }

        /// <summary>
        /// 已注册设备通信类型信息
        /// </summary>
        [JsonProperty("RegisteredDeviceNetType")]
        public RegisteredDeviceNetTypeInfo RegisteredDeviceNetType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamObj(map, prefix + "DeviceActivationDetails.", this.DeviceActivationDetails);
            this.SetParamObj(map, prefix + "RegisteredDeviceType.", this.RegisteredDeviceType);
            this.SetParamObj(map, prefix + "RegisteredDeviceNetType.", this.RegisteredDeviceNetType);
        }
    }
}

