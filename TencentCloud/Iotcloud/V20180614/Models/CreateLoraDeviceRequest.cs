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

    public class CreateLoraDeviceRequest : AbstractModel
    {
        
        /// <summary>
        /// 产品 ID ，创建产品时腾讯云为用户分配全局唯一的 ID
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 设备类型 ，目前支持A、B、C三种
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// LoRa应用UUID
        /// </summary>
        [JsonProperty("AppEui")]
        public string AppEui{ get; set; }

        /// <summary>
        /// LoRa设备UUID
        /// </summary>
        [JsonProperty("DeviceEui")]
        public string DeviceEui{ get; set; }

        /// <summary>
        /// LoRa应用密钥
        /// </summary>
        [JsonProperty("AppKey")]
        public string AppKey{ get; set; }

        /// <summary>
        /// LoRa设备验证密钥
        /// </summary>
        [JsonProperty("AuthKey")]
        public string AuthKey{ get; set; }

        /// <summary>
        /// 设备备注
        /// </summary>
        [JsonProperty("Memo")]
        public string Memo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "AppEui", this.AppEui);
            this.SetParamSimple(map, prefix + "DeviceEui", this.DeviceEui);
            this.SetParamSimple(map, prefix + "AppKey", this.AppKey);
            this.SetParamSimple(map, prefix + "AuthKey", this.AuthKey);
            this.SetParamSimple(map, prefix + "Memo", this.Memo);
        }
    }
}

