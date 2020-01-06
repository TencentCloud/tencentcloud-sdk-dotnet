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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Address : AbstractModel
    {
        
        /// <summary>
        /// `EIP`的`ID`，是`EIP`的唯一标识。
        /// </summary>
        [JsonProperty("AddressId")]
        public string AddressId{ get; set; }

        /// <summary>
        /// `EIP`名称。
        /// </summary>
        [JsonProperty("AddressName")]
        public string AddressName{ get; set; }

        /// <summary>
        /// `EIP`状态，包含'CREATING'(创建中),'BINDING'(绑定中),'BIND'(已绑定),'UNBINDING'(解绑中),'UNBIND'(已解绑),'OFFLINING'(释放中),'BIND_ENI'(绑定悬空弹性网卡)
        /// </summary>
        [JsonProperty("AddressStatus")]
        public string AddressStatus{ get; set; }

        /// <summary>
        /// 外网IP地址
        /// </summary>
        [JsonProperty("AddressIp")]
        public string AddressIp{ get; set; }

        /// <summary>
        /// 绑定的资源实例`ID`。可能是一个`CVM`，`NAT`。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 创建时间。按照`ISO8601`标准表示，并且使用`UTC`时间。格式为：`YYYY-MM-DDThh:mm:ssZ`。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 绑定的弹性网卡ID
        /// </summary>
        [JsonProperty("NetworkInterfaceId")]
        public string NetworkInterfaceId{ get; set; }

        /// <summary>
        /// 绑定的资源内网ip
        /// </summary>
        [JsonProperty("PrivateAddressIp")]
        public string PrivateAddressIp{ get; set; }

        /// <summary>
        /// 资源隔离状态。true表示eip处于隔离状态，false表示资源处于未隔离状态
        /// </summary>
        [JsonProperty("IsArrears")]
        public bool? IsArrears{ get; set; }

        /// <summary>
        /// 资源封堵状态。true表示eip处于封堵状态，false表示eip处于未封堵状态
        /// </summary>
        [JsonProperty("IsBlocked")]
        public bool? IsBlocked{ get; set; }

        /// <summary>
        /// eip是否支持直通模式。true表示eip支持直通模式，false表示资源不支持直通模式
        /// </summary>
        [JsonProperty("IsEipDirectConnection")]
        public bool? IsEipDirectConnection{ get; set; }

        /// <summary>
        /// eip资源类型，包括"CalcIP","WanIP","EIP","AnycastEIP"。其中"CalcIP"表示设备ip，“WanIP”表示普通公网ip，“EIP”表示弹性公网ip，“AnycastEip”表示加速EIP
        /// </summary>
        [JsonProperty("AddressType")]
        public string AddressType{ get; set; }

        /// <summary>
        /// eip是否在解绑后自动释放。true表示eip将会在解绑后自动释放，false表示eip在解绑后不会自动释放
        /// </summary>
        [JsonProperty("CascadeRelease")]
        public bool? CascadeRelease{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AddressId", this.AddressId);
            this.SetParamSimple(map, prefix + "AddressName", this.AddressName);
            this.SetParamSimple(map, prefix + "AddressStatus", this.AddressStatus);
            this.SetParamSimple(map, prefix + "AddressIp", this.AddressIp);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "NetworkInterfaceId", this.NetworkInterfaceId);
            this.SetParamSimple(map, prefix + "PrivateAddressIp", this.PrivateAddressIp);
            this.SetParamSimple(map, prefix + "IsArrears", this.IsArrears);
            this.SetParamSimple(map, prefix + "IsBlocked", this.IsBlocked);
            this.SetParamSimple(map, prefix + "IsEipDirectConnection", this.IsEipDirectConnection);
            this.SetParamSimple(map, prefix + "AddressType", this.AddressType);
            this.SetParamSimple(map, prefix + "CascadeRelease", this.CascadeRelease);
        }
    }
}

