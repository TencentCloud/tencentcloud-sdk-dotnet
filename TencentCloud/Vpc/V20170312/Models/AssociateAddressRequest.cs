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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssociateAddressRequest : AbstractModel
    {
        
        /// <summary>
        /// 标识 EIP 的唯一 ID。可以使用[DescribeAddresses](https://cloud.tencent.com/document/product/215/16702)接口获取AddressId。EIP 唯一 ID 形如：`eip-11112222`。
        /// </summary>
        [JsonProperty("AddressId")]
        public string AddressId{ get; set; }

        /// <summary>
        /// 要绑定的实例 ID。实例 ID 形如：`ins-11112222`、`lb-11112222`。可通过登录[控制台](https://console.cloud.tencent.com/cvm)查询，也可通过 [DescribeInstances](https://cloud.tencent.com/document/api/213/15728) 接口返回值中的`InstanceId`获取。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 要绑定的弹性网卡 ID。 弹性网卡 ID 形如：`eni-11112222`。`NetworkInterfaceId` 与 `InstanceId` 不可同时指定。弹性网卡 ID 可通过登录[控制台](https://console.cloud.tencent.com/vpc/eni)查询，也可通过[DescribeNetworkInterfaces](https://cloud.tencent.com/document/api/215/15817)接口返回值中的`networkInterfaceId`获取。
        /// </summary>
        [JsonProperty("NetworkInterfaceId")]
        public string NetworkInterfaceId{ get; set; }

        /// <summary>
        /// 要绑定的内网 IP。如果指定了 `NetworkInterfaceId` 则也必须指定 `PrivateIpAddress` ，表示将 EIP 绑定到指定弹性网卡的指定内网 IP 上。同时要确保指定的 `PrivateIpAddress` 是指定的 `NetworkInterfaceId` 上的一个内网 IP。指定弹性网卡的内网 IP 可通过登录[控制台](https://console.cloud.tencent.com/vpc/eni)查询，也可通过[DescribeNetworkInterfaces](https://cloud.tencent.com/document/api/215/15817)接口返回值中的`privateIpAddress`获取。
        /// </summary>
        [JsonProperty("PrivateIpAddress")]
        public string PrivateIpAddress{ get; set; }

        /// <summary>
        /// 指定绑定时是否设置直通。弹性公网 IP 直通请参见 [EIP 直通](https://cloud.tencent.com/document/product/1199/41709)。取值：true、false，默认值为 false。当绑定 CVM 实例、EKS 弹性集群时，可设定此参数为 true。此参数目前处于内测中，如需使用，请提交 [工单申请](https://console.cloud.tencent.com/workorder/category?level1_id=6&level2_id=163&source=0&data_title=%E8%B4%9F%E8%BD%BD%E5%9D%87%E8%A1%A1%20CLB&level3_id=1071&queue=96&scene_code=34639&step=2)。
        /// </summary>
        [JsonProperty("EipDirectConnection")]
        public bool? EipDirectConnection{ get; set; }

        /// <summary>
        /// 要绑定的实例所在地域。默认无需填写，仅限GAAP特殊场景需指定实例所在地域。
        /// </summary>
        [JsonProperty("InstanceRegion")]
        public string InstanceRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AddressId", this.AddressId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "NetworkInterfaceId", this.NetworkInterfaceId);
            this.SetParamSimple(map, prefix + "PrivateIpAddress", this.PrivateIpAddress);
            this.SetParamSimple(map, prefix + "EipDirectConnection", this.EipDirectConnection);
            this.SetParamSimple(map, prefix + "InstanceRegion", this.InstanceRegion);
        }
    }
}

