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
        /// 设备登录时间
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
        /// LoRa设备的dev eui
        /// </summary>
        [JsonProperty("LoraDevEui")]
        public string LoraDevEui{ get; set; }

        /// <summary>
        /// LoRa设备的Mote type
        /// </summary>
        [JsonProperty("LoraMoteType")]
        public ulong? LoraMoteType{ get; set; }

        /// <summary>
        /// 首次上线时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FirstOnlineTime")]
        public ulong? FirstOnlineTime{ get; set; }

        /// <summary>
        /// 最近下线时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastOfflineTime")]
        public ulong? LastOfflineTime{ get; set; }

        /// <summary>
        /// 设备创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 设备日志级别
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogLevel")]
        public ulong? LogLevel{ get; set; }

        /// <summary>
        /// 设备证书获取状态, 1 已获取过设备密钥，0 未获取过设备密钥
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CertState")]
        public ulong? CertState{ get; set; }

        /// <summary>
        /// 设备可用状态，0禁用，1启用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableState")]
        public ulong? EnableState{ get; set; }

        /// <summary>
        /// 设备标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Labels")]
        public DeviceLabel[] Labels{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
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
            this.SetParamSimple(map, prefix + "LoraDevEui", this.LoraDevEui);
            this.SetParamSimple(map, prefix + "LoraMoteType", this.LoraMoteType);
            this.SetParamSimple(map, prefix + "FirstOnlineTime", this.FirstOnlineTime);
            this.SetParamSimple(map, prefix + "LastOfflineTime", this.LastOfflineTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "LogLevel", this.LogLevel);
            this.SetParamSimple(map, prefix + "CertState", this.CertState);
            this.SetParamSimple(map, prefix + "EnableState", this.EnableState);
            this.SetParamArrayObj(map, prefix + "Labels.", this.Labels);
        }
    }
}

