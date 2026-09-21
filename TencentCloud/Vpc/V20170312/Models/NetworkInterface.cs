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

    public class NetworkInterface : AbstractModel
    {
        
        /// <summary>
        /// <p>弹性网卡实例ID，例如：eni-f1xjkw1b。</p>
        /// </summary>
        [JsonProperty("NetworkInterfaceId")]
        public string NetworkInterfaceId{ get; set; }

        /// <summary>
        /// <p>弹性网卡名称。</p>
        /// </summary>
        [JsonProperty("NetworkInterfaceName")]
        public string NetworkInterfaceName{ get; set; }

        /// <summary>
        /// <p>弹性网卡描述。</p>
        /// </summary>
        [JsonProperty("NetworkInterfaceDescription")]
        public string NetworkInterfaceDescription{ get; set; }

        /// <summary>
        /// <p>子网实例ID。</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>VPC实例ID。</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>绑定的安全组。</p>
        /// </summary>
        [JsonProperty("GroupSet")]
        public string[] GroupSet{ get; set; }

        /// <summary>
        /// <p>是否是主网卡。</p>
        /// </summary>
        [JsonProperty("Primary")]
        public bool? Primary{ get; set; }

        /// <summary>
        /// <p>MAC地址。</p>
        /// </summary>
        [JsonProperty("MacAddress")]
        public string MacAddress{ get; set; }

        /// <summary>
        /// <p>弹性网卡状态：</p><li><code>PENDING</code>：创建中</li><li><code>AVAILABLE</code>：可用的</li><li><code>ATTACHING</code>：绑定中</li><li><code>DETACHING</code>：解绑中</li><li><code>DELETING</code>：删除中</li>
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// <p>弹性网卡状态：</p><li><code>PENDING</code>：创建中</li><li><code>AVAILABLE</code>：可用的</li><li><code>ATTACHING</code>：绑定中</li><li><code>DETACHING</code>：解绑中</li><li><code>DELETING</code>：删除中</li><li><code>INUSE</code>：已绑定</li>
        /// </summary>
        [JsonProperty("NetworkInterfaceState")]
        public string NetworkInterfaceState{ get; set; }

        /// <summary>
        /// <p>内网IP信息。</p>
        /// </summary>
        [JsonProperty("PrivateIpAddressSet")]
        public PrivateIpAddressSpecification[] PrivateIpAddressSet{ get; set; }

        /// <summary>
        /// <p>绑定的云服务器对象。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Attachment")]
        public NetworkInterfaceAttachment Attachment{ get; set; }

        /// <summary>
        /// <p>可用区。</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>创建时间。格式：YYYY-MM-DD hh:mm:ss。示例值：2020-10-28 08:23:59</p>
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// <p><code>IPv6</code>地址列表。</p>
        /// </summary>
        [JsonProperty("Ipv6AddressSet")]
        public Ipv6Address[] Ipv6AddressSet{ get; set; }

        /// <summary>
        /// <p>标签键值对。</p>
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }

        /// <summary>
        /// <p>网卡类型。“0”-辅助网卡，“1”-主网卡，“2”：中继网卡</p>
        /// </summary>
        [JsonProperty("EniType")]
        public ulong? EniType{ get; set; }

        /// <summary>
        /// <p>网卡绑定的子机类型：cvm（普通CVM子机），eks（弹性容器服务Elastic Kubernetes Service）， hai（高性能应用服务Hyper Application Inventor）。</p>
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// <p>网卡所关联的CDC实例ID。</p>
        /// </summary>
        [JsonProperty("CdcId")]
        public string CdcId{ get; set; }

        /// <summary>
        /// <p>弹性网卡类型：0:标准型/1:扩展型。默认值为0。</p>
        /// </summary>
        [JsonProperty("AttachType")]
        public ulong? AttachType{ get; set; }

        /// <summary>
        /// <p>用于保留网卡主IP的资源ID用于保留网卡主IP的资源ID。用于删除网卡时作为入参数。</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>服务质量级别：<br>PT（云金）、AU（云银）、AG(云铜）、DEFAULT（默认）。</p><p>可选值：PT（云金）、AU（云银）、AG(云铜）、DEFAULT（默认）。</p>
        /// </summary>
        [JsonProperty("QosLevel")]
        public string QosLevel{ get; set; }

        /// <summary>
        /// <p>指定的<code>IPv6</code>地址列表，单次最多指定10个。与入参<code>Ipv6AddressCount</code>合并计算配额。</p>
        /// </summary>
        [JsonProperty("Ipv6Addresses")]
        public Ipv6Address[] Ipv6Addresses{ get; set; }

        /// <summary>
        /// <p>自动分配<code>IPv6</code>地址个数，内网IP地址个数总和不能超过配额数。与入参<code>Ipv6Addresses</code>合并计算配额。</p><p>取值范围：[1, 10]</p><p>单位：个</p>
        /// </summary>
        [JsonProperty("Ipv6AddressCount")]
        public ulong? Ipv6AddressCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
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
            this.SetParamSimple(map, prefix + "NetworkInterfaceState", this.NetworkInterfaceState);
            this.SetParamArrayObj(map, prefix + "PrivateIpAddressSet.", this.PrivateIpAddressSet);
            this.SetParamObj(map, prefix + "Attachment.", this.Attachment);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamArrayObj(map, prefix + "Ipv6AddressSet.", this.Ipv6AddressSet);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamSimple(map, prefix + "EniType", this.EniType);
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "CdcId", this.CdcId);
            this.SetParamSimple(map, prefix + "AttachType", this.AttachType);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "QosLevel", this.QosLevel);
            this.SetParamArrayObj(map, prefix + "Ipv6Addresses.", this.Ipv6Addresses);
            this.SetParamSimple(map, prefix + "Ipv6AddressCount", this.Ipv6AddressCount);
        }
    }
}

