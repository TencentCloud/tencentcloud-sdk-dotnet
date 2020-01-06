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

    public class NetworkInterface : AbstractModel
    {
        
        /// <summary>
        /// 弹性网卡实例ID，例如：eni-f1xjkw1b。
        /// </summary>
        [JsonProperty("NetworkInterfaceId")]
        public string NetworkInterfaceId{ get; set; }

        /// <summary>
        /// 弹性网卡名称。
        /// </summary>
        [JsonProperty("NetworkInterfaceName")]
        public string NetworkInterfaceName{ get; set; }

        /// <summary>
        /// 弹性网卡描述。
        /// </summary>
        [JsonProperty("NetworkInterfaceDescription")]
        public string NetworkInterfaceDescription{ get; set; }

        /// <summary>
        /// 子网实例ID。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// VPC实例ID。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 绑定的安全组。
        /// </summary>
        [JsonProperty("GroupSet")]
        public string[] GroupSet{ get; set; }

        /// <summary>
        /// 是否是主网卡。
        /// </summary>
        [JsonProperty("Primary")]
        public bool? Primary{ get; set; }

        /// <summary>
        /// MAC地址。
        /// </summary>
        [JsonProperty("MacAddress")]
        public string MacAddress{ get; set; }

        /// <summary>
        /// 弹性网卡状态：
        /// <li>`PENDING`：创建中</li>
        /// <li>`AVAILABLE`：可用的</li>
        /// <li>`ATTACHING`：绑定中</li>
        /// <li>`DETACHING`：解绑中</li>
        /// <li>`DELETING`：删除中</li>
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 内网IP信息。
        /// </summary>
        [JsonProperty("PrivateIpAddressSet")]
        public PrivateIpAddressSpecification[] PrivateIpAddressSet{ get; set; }

        /// <summary>
        /// 绑定的云服务器对象。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Attachment")]
        public NetworkInterfaceAttachment Attachment{ get; set; }

        /// <summary>
        /// 可用区。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// `IPv6`地址列表。
        /// </summary>
        [JsonProperty("Ipv6AddressSet")]
        public Ipv6Address[] Ipv6AddressSet{ get; set; }

        /// <summary>
        /// 标签键值对。
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }

        /// <summary>
        /// 网卡类型。0 - 弹性网卡；1 - evm弹性网卡。
        /// </summary>
        [JsonProperty("EniType")]
        public ulong? EniType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NetworkInterfaceId", this.NetworkInterfaceId);
            this.SetParamSimple(map, prefix + "NetworkInterfaceName", this.NetworkInterfaceName);
            this.SetParamSimple(map, prefix + "NetworkInterfaceDescription", this.NetworkInterfaceDescription);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamArraySimple(map, prefix + "GroupSet.", this.GroupSet);
            this.SetParamSimple(map, prefix + "Primary", this.Primary);
            this.SetParamSimple(map, prefix + "MacAddress", this.MacAddress);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamArrayObj(map, prefix + "PrivateIpAddressSet.", this.PrivateIpAddressSet);
            this.SetParamObj(map, prefix + "Attachment.", this.Attachment);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamArrayObj(map, prefix + "Ipv6AddressSet.", this.Ipv6AddressSet);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamSimple(map, prefix + "EniType", this.EniType);
        }
    }
}

