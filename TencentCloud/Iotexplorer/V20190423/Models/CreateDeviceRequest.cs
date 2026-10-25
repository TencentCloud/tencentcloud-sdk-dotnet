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

    public class CreateDeviceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>产品ID。</p>
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// <p>设备名称。命名规则：[a-zA-Z0-9:_-]{1,48}。</p>
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// <p>LoRaWAN 设备地址</p>
        /// </summary>
        [JsonProperty("DevAddr")]
        public string DevAddr{ get; set; }

        /// <summary>
        /// <p>LoRaWAN 应用密钥</p>
        /// </summary>
        [JsonProperty("AppKey")]
        public string AppKey{ get; set; }

        /// <summary>
        /// <p>LoRaWAN 设备唯一标识</p>
        /// </summary>
        [JsonProperty("DevEUI")]
        public string DevEUI{ get; set; }

        /// <summary>
        /// <p>LoRaWAN 应用会话密钥</p>
        /// </summary>
        [JsonProperty("AppSKey")]
        public string AppSKey{ get; set; }

        /// <summary>
        /// <p>LoRaWAN 网络会话密钥</p>
        /// </summary>
        [JsonProperty("NwkSKey")]
        public string NwkSKey{ get; set; }

        /// <summary>
        /// <p>手动指定设备的PSK密钥</p>
        /// </summary>
        [JsonProperty("DefinedPsk")]
        public string DefinedPsk{ get; set; }

        /// <summary>
        /// <p>设备证书。第三方CA证书认证的产品下必填；腾讯云CA证书产品传入会报错；非证书认证产品传入会被忽略</p>
        /// </summary>
        [JsonProperty("TlsCrt")]
        public string TlsCrt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "DevAddr", this.DevAddr);
            this.SetParamSimple(map, prefix + "AppKey", this.AppKey);
            this.SetParamSimple(map, prefix + "DevEUI", this.DevEUI);
            this.SetParamSimple(map, prefix + "AppSKey", this.AppSKey);
            this.SetParamSimple(map, prefix + "NwkSKey", this.NwkSKey);
            this.SetParamSimple(map, prefix + "DefinedPsk", this.DefinedPsk);
            this.SetParamSimple(map, prefix + "TlsCrt", this.TlsCrt);
        }
    }
}

