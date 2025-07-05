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

namespace TencentCloud.Mna.V20210119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceBaseInfo : AbstractModel
    {
        
        /// <summary>
        /// 设备唯一ID
        /// </summary>
        [JsonProperty("DeviceId")]
        public string DeviceId{ get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 设备创建的时间，单位：ms
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 设备最后在线时间，单位：ms
        /// </summary>
        [JsonProperty("LastTime")]
        public string LastTime{ get; set; }

        /// <summary>
        /// 设备的备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 接入环境。0：公有云网关；1：自有网关；2：公有云网关和自有网关。默认公有云网关。 具体含义： 公有云网关：即该设备只能接入公有云网关（就近接入） 自有网关：即该设备只能接入已经注册上线的自有网关（就近接入或固定ip接入） 公有云网关和自有网关：即该设备同时可以接入公有云网关和已经注册上线的自有网关（就近接入或固定ip接入）
        /// </summary>
        [JsonProperty("AccessScope")]
        public long? AccessScope{ get; set; }

        /// <summary>
        /// license授权有效期 0：月度授权 1：永久授权
        /// </summary>
        [JsonProperty("LicensePayMode")]
        public long? LicensePayMode{ get; set; }

        /// <summary>
        /// 付费方 0：厂商付费 1：客户付费
        /// </summary>
        [JsonProperty("Payer")]
        public long? Payer{ get; set; }

        /// <summary>
        /// 设备分组ID
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 设备分组名称
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 设备无流量包处理方式，0: 按量付费，1: 截断加速
        /// </summary>
        [JsonProperty("FlowTrunc")]
        public long? FlowTrunc{ get; set; }

        /// <summary>
        /// 设备sn
        /// </summary>
        [JsonProperty("Sn")]
        public string Sn{ get; set; }

        /// <summary>
        /// 厂商
        /// </summary>
        [JsonProperty("Vendor")]
        public string Vendor{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceId", this.DeviceId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "LastTime", this.LastTime);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "AccessScope", this.AccessScope);
            this.SetParamSimple(map, prefix + "LicensePayMode", this.LicensePayMode);
            this.SetParamSimple(map, prefix + "Payer", this.Payer);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "FlowTrunc", this.FlowTrunc);
            this.SetParamSimple(map, prefix + "Sn", this.Sn);
            this.SetParamSimple(map, prefix + "Vendor", this.Vendor);
        }
    }
}

