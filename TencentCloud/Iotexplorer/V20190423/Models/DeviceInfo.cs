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

    public class DeviceInfo : AbstractModel
    {
        
        /// <summary>
        /// 设备名
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 0: 离线, 1: 在线, 2: 获取失败, 3 未激活
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 设备密钥，密钥加密的设备返回
        /// </summary>
        [JsonProperty("DevicePsk")]
        public string DevicePsk{ get; set; }

        /// <summary>
        /// 首次上线时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FirstOnlineTime")]
        public long? FirstOnlineTime{ get; set; }

        /// <summary>
        /// 最后一次上线时间
        /// </summary>
        [JsonProperty("LoginTime")]
        public long? LoginTime{ get; set; }

        /// <summary>
        /// 设备创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// 设备固件版本
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 设备证书
        /// </summary>
        [JsonProperty("DeviceCert")]
        public string DeviceCert{ get; set; }

        /// <summary>
        /// 日志级别
        /// </summary>
        [JsonProperty("LogLevel")]
        public long? LogLevel{ get; set; }

        /// <summary>
        /// LoRaWAN 设备地址
        /// </summary>
        [JsonProperty("DevAddr")]
        public string DevAddr{ get; set; }

        /// <summary>
        /// LoRaWAN 应用密钥
        /// </summary>
        [JsonProperty("AppKey")]
        public string AppKey{ get; set; }

        /// <summary>
        /// LoRaWAN 设备唯一标识
        /// </summary>
        [JsonProperty("DevEUI")]
        public string DevEUI{ get; set; }

        /// <summary>
        /// LoRaWAN 应用会话密钥
        /// </summary>
        [JsonProperty("AppSKey")]
        public string AppSKey{ get; set; }

        /// <summary>
        /// LoRaWAN 网络会话密钥
        /// </summary>
        [JsonProperty("NwkSKey")]
        public string NwkSKey{ get; set; }

        /// <summary>
        /// 创建人Id
        /// </summary>
        [JsonProperty("CreateUserId")]
        public long? CreateUserId{ get; set; }

        /// <summary>
        /// 创建人昵称
        /// </summary>
        [JsonProperty("CreatorNickName")]
        public string CreatorNickName{ get; set; }

        /// <summary>
        /// 启用/禁用状态
        /// </summary>
        [JsonProperty("EnableState")]
        public long? EnableState{ get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// 设备类型（设备、子设备、网关）
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// 是否是 lora 设备
        /// </summary>
        [JsonProperty("IsLora")]
        public bool? IsLora{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "DevicePsk", this.DevicePsk);
            this.SetParamSimple(map, prefix + "FirstOnlineTime", this.FirstOnlineTime);
            this.SetParamSimple(map, prefix + "LoginTime", this.LoginTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "DeviceCert", this.DeviceCert);
            this.SetParamSimple(map, prefix + "LogLevel", this.LogLevel);
            this.SetParamSimple(map, prefix + "DevAddr", this.DevAddr);
            this.SetParamSimple(map, prefix + "AppKey", this.AppKey);
            this.SetParamSimple(map, prefix + "DevEUI", this.DevEUI);
            this.SetParamSimple(map, prefix + "AppSKey", this.AppSKey);
            this.SetParamSimple(map, prefix + "NwkSKey", this.NwkSKey);
            this.SetParamSimple(map, prefix + "CreateUserId", this.CreateUserId);
            this.SetParamSimple(map, prefix + "CreatorNickName", this.CreatorNickName);
            this.SetParamSimple(map, prefix + "EnableState", this.EnableState);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "IsLora", this.IsLora);
        }
    }
}

