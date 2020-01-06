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

    public class CreateDeviceRequest : AbstractModel
    {
        
        /// <summary>
        /// 产品 ID 。创建产品时腾讯云为用户分配全局唯一的 ID
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 设备名称。命名规则：[a-zA-Z0-9:_-]{1,48}。
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 设备属性
        /// </summary>
        [JsonProperty("Attribute")]
        public Attribute Attribute{ get; set; }

        /// <summary>
        /// 是否使用自定义PSK，默认不使用
        /// </summary>
        [JsonProperty("DefinedPsk")]
        public string DefinedPsk{ get; set; }

        /// <summary>
        /// 运营商类型，当产品是NB-IoT产品时，此字段必填。1表示中国电信，2表示中国移动，3表示中国联通
        /// </summary>
        [JsonProperty("Isp")]
        public ulong? Isp{ get; set; }

        /// <summary>
        /// IMEI，当产品是NB-IoT产品时，此字段必填
        /// </summary>
        [JsonProperty("Imei")]
        public string Imei{ get; set; }

        /// <summary>
        /// LoRa设备的DevEui，当创建LoRa时，此字段必填
        /// </summary>
        [JsonProperty("LoraDevEui")]
        public string LoraDevEui{ get; set; }

        /// <summary>
        /// LoRa设备的MoteType
        /// </summary>
        [JsonProperty("LoraMoteType")]
        public ulong? LoraMoteType{ get; set; }

        /// <summary>
        /// 创建LoRa设备需要skey
        /// </summary>
        [JsonProperty("Skey")]
        public string Skey{ get; set; }

        /// <summary>
        /// LoRa设备的AppKey
        /// </summary>
        [JsonProperty("LoraAppKey")]
        public string LoraAppKey{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamObj(map, prefix + "Attribute.", this.Attribute);
            this.SetParamSimple(map, prefix + "DefinedPsk", this.DefinedPsk);
            this.SetParamSimple(map, prefix + "Isp", this.Isp);
            this.SetParamSimple(map, prefix + "Imei", this.Imei);
            this.SetParamSimple(map, prefix + "LoraDevEui", this.LoraDevEui);
            this.SetParamSimple(map, prefix + "LoraMoteType", this.LoraMoteType);
            this.SetParamSimple(map, prefix + "Skey", this.Skey);
            this.SetParamSimple(map, prefix + "LoraAppKey", this.LoraAppKey);
        }
    }
}

