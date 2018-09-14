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

    public class DeviceInfo : AbstractModel
    {
        
        /// <summary>
        /// 设备名
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 设备是否在线，0不在线，1在线
        /// </summary>
        [JsonProperty("Online")]
        public ulong? Online{ get; set; }

        /// <summary>
        /// 设备登陆时间
        /// </summary>
        [JsonProperty("LoginTime")]
        public ulong? LoginTime{ get; set; }

        /// <summary>
        /// 设备版本
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 设备证书，证书加密的设备返回
        /// </summary>
        [JsonProperty("DeviceCert")]
        public string DeviceCert{ get; set; }

        /// <summary>
        /// 设备密钥，密钥加密的设备返回
        /// </summary>
        [JsonProperty("DevicePsk")]
        public string DevicePsk{ get; set; }

        /// <summary>
        /// 设备属性
        /// </summary>
        [JsonProperty("Tags")]
        public DeviceTag[] Tags{ get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        [JsonProperty("DeviceType")]
        public ulong? DeviceType{ get; set; }

        /// <summary>
        /// IMEI
        /// </summary>
        [JsonProperty("Imei")]
        public string Imei{ get; set; }

        /// <summary>
        /// 运营商类型
        /// </summary>
        [JsonProperty("Isp")]
        public ulong? Isp{ get; set; }

        /// <summary>
        /// NB IOT运营商处的DeviceID
        /// </summary>
        [JsonProperty("NbiotDeviceID")]
        public string NbiotDeviceID{ get; set; }

        /// <summary>
        /// IP地址
        /// </summary>
        [JsonProperty("ConnIP")]
        public ulong? ConnIP{ get; set; }

        /// <summary>
        /// 设备最后更新时间
        /// </summary>
        [JsonProperty("LastUpdateTime")]
        public ulong? LastUpdateTime{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "Online", this.Online);
            this.SetParamSimple(map, prefix + "LoginTime", this.LoginTime);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "DeviceCert", this.DeviceCert);
            this.SetParamSimple(map, prefix + "DevicePsk", this.DevicePsk);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "Imei", this.Imei);
            this.SetParamSimple(map, prefix + "Isp", this.Isp);
            this.SetParamSimple(map, prefix + "NbiotDeviceID", this.NbiotDeviceID);
            this.SetParamSimple(map, prefix + "ConnIP", this.ConnIP);
            this.SetParamSimple(map, prefix + "LastUpdateTime", this.LastUpdateTime);
        }
    }
}

