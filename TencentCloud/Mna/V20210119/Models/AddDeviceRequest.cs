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

    public class AddDeviceRequest : AbstractModel
    {
        
        /// <summary>
        /// 新建设备的名称
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 新建设备的备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 新建设备的base64密钥字符串，非必选，如果不填写则由系统自动生成
        /// </summary>
        [JsonProperty("DataKey")]
        public string DataKey{ get; set; }

        /// <summary>
        /// 是否设置预置密钥
        /// </summary>
        [JsonProperty("Encrypted")]
        public bool? Encrypted{ get; set; }

        /// <summary>
        /// 接入环境。0：公有云网关；1：自有网关；2：公有云网关和自有网关。不填默认公有云网关。
        /// 具体含义：
        /// 公有云网关：即该设备只能接入公有云网关（就近接入）
        /// 自有网关：即该设备只能接入已经注册上线的自有网关（就近接入或固定ip接入）
        /// 公有云网关和自有网关：即该设备同时可以接入公有云网关和已经注册上线的自有网关（就近接入或固定ip接入）
        /// </summary>
        [JsonProperty("AccessScope")]
        public long? AccessScope{ get; set; }

        /// <summary>
        /// license付费方式： 
        /// 0，月度授权 
        /// 1，永久授权 
        /// 若不传则默认为月度授权，永久授权设备需要调用OrderPerLicense接口支付授权费，否则设备无法使用
        /// </summary>
        [JsonProperty("LicensePayMode")]
        public long? LicensePayMode{ get; set; }

        /// <summary>
        /// 设备分组名称，非必选，预留参数，需要分组时传入GroupId
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 设备分组ID，非必选，如果不填写则默认设备无分组
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 设备无流量包处理方式，0: 按量付费，1: 截断加速
        /// </summary>
        [JsonProperty("FlowTrunc")]
        public long? FlowTrunc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "DataKey", this.DataKey);
            this.SetParamSimple(map, prefix + "Encrypted", this.Encrypted);
            this.SetParamSimple(map, prefix + "AccessScope", this.AccessScope);
            this.SetParamSimple(map, prefix + "LicensePayMode", this.LicensePayMode);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "FlowTrunc", this.FlowTrunc);
        }
    }
}

