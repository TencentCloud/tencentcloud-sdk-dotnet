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

    public class Address : AbstractModel
    {
        
        /// <summary>
        /// <p><code>EIP</code>的<code>ID</code>，是<code>EIP</code>的唯一标识。</p>
        /// </summary>
        [JsonProperty("AddressId")]
        public string AddressId{ get; set; }

        /// <summary>
        /// <p><code>EIP</code>名称。</p>
        /// </summary>
        [JsonProperty("AddressName")]
        public string AddressName{ get; set; }

        /// <summary>
        /// <p><code>EIP</code>状态，包含&#39;CREATING&#39;(创建中),&#39;BINDING&#39;(绑定中),&#39;BIND&#39;(已绑定),&#39;UNBINDING&#39;(解绑中),&#39;UNBIND&#39;(已解绑),&#39;OFFLINING&#39;(释放中),&#39;BIND_ENI&#39;(绑定悬空弹性网卡)</p>
        /// </summary>
        [JsonProperty("AddressStatus")]
        public string AddressStatus{ get; set; }

        /// <summary>
        /// <p>外网IP地址</p>
        /// </summary>
        [JsonProperty("AddressIp")]
        public string AddressIp{ get; set; }

        /// <summary>
        /// <p>绑定的资源实例<code>ID</code>。可能是一个<code>CVM</code>，<code>NAT</code>。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>创建时间。按照<code>ISO8601</code>标准表示，并且使用<code>UTC</code>时间。格式为：<code>YYYY-MM-DDThh:mm:ssZ</code>。</p>
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// <p>绑定的弹性网卡ID，null表示没有绑定弹性网卡。</p>
        /// </summary>
        [JsonProperty("NetworkInterfaceId")]
        public string NetworkInterfaceId{ get; set; }

        /// <summary>
        /// <p>绑定的资源内网ip，null表示没有绑定资源内网ip。</p>
        /// </summary>
        [JsonProperty("PrivateAddressIp")]
        public string PrivateAddressIp{ get; set; }

        /// <summary>
        /// <p>资源隔离状态。true表示eip处于隔离状态，false表示资源处于未隔离状态</p>
        /// </summary>
        [JsonProperty("IsArrears")]
        public bool? IsArrears{ get; set; }

        /// <summary>
        /// <p>资源封堵状态。true表示eip处于封堵状态，false表示eip处于未封堵状态</p>
        /// </summary>
        [JsonProperty("IsBlocked")]
        public bool? IsBlocked{ get; set; }

        /// <summary>
        /// <p>eip是否支持直通模式。true表示eip支持直通模式，false表示资源不支持直通模式</p>
        /// </summary>
        [JsonProperty("IsEipDirectConnection")]
        public bool? IsEipDirectConnection{ get; set; }

        /// <summary>
        /// <p>EIP 资源类型，包括CalcIP、WanIP、EIP和AnycastEIP、高防EIP。其中：<code>CalcIP</code> 表示设备 IP，<code>WanIP</code> 表示普通公网 IP，<code>EIP</code> 表示弹性公网 IP，<code>AnycastEIP</code> 表示加速 EIP，<code>AntiDDoSEIP</code>表示高防EIP。</p>
        /// </summary>
        [JsonProperty("AddressType")]
        public string AddressType{ get; set; }

        /// <summary>
        /// <p>eip是否在解绑后自动释放。true表示eip将会在解绑后自动释放，false表示eip在解绑后不会自动释放</p>
        /// </summary>
        [JsonProperty("CascadeRelease")]
        public bool? CascadeRelease{ get; set; }

        /// <summary>
        /// <p>EIP ALG开启的协议类型。</p>
        /// </summary>
        [JsonProperty("EipAlgType")]
        public AlgType EipAlgType{ get; set; }

        /// <summary>
        /// <p>弹性公网IP的运营商信息，当前可能返回值包括&quot;CMCC&quot;(移动),&quot;CTCC&quot;(电信),&quot;CUCC&quot;(联通),&quot;BGP&quot;(常规BGP)。</p>
        /// </summary>
        [JsonProperty("InternetServiceProvider")]
        public string InternetServiceProvider{ get; set; }

        /// <summary>
        /// <p>是否本地带宽EIP，可选值：</p><li>true：本地带宽EIP</li><li>false：非本地带宽EIP</li>
        /// </summary>
        [JsonProperty("LocalBgp")]
        public bool? LocalBgp{ get; set; }

        /// <summary>
        /// <p>弹性公网IP的带宽值。注意，传统账户类型账户的弹性公网IP没有带宽属性，值为空。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Bandwidth")]
        public ulong? Bandwidth{ get; set; }

        /// <summary>
        /// <p>弹性公网IP的网络计费模式。注意，传统账户类型账户的弹性公网IP没有网络计费模式属性，值为空。<br>注意：此字段可能返回 null，表示取不到有效值。<br>包括：</p><li><strong>BANDWIDTH_PREPAID_BY_MONTH</strong></li><p style="padding-left: 30px;">表示包月带宽预付费。</p><li><strong>TRAFFIC_POSTPAID_BY_HOUR</strong></li><p style="padding-left: 30px;">表示按小时流量后付费。</p><li><strong>BANDWIDTH_POSTPAID_BY_HOUR</strong></li><p style="padding-left: 30px;">表示按小时带宽后付费。</p><li><strong>BANDWIDTH_PACKAGE</strong></li><p style="padding-left: 30px;">表示共享带宽包。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InternetChargeType")]
        public string InternetChargeType{ get; set; }

        /// <summary>
        /// <p>弹性公网IP关联的标签列表。</p>
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }

        /// <summary>
        /// <p>预付费包月带宽IP到期时间。<br>时间格式：YYYY-MM-DDThh:mm:ssZ</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeadlineDate")]
        public string DeadlineDate{ get; set; }

        /// <summary>
        /// <p>EIP绑定的实例类型。可选值：</p><li>CVM：云服务器</li><li>NAT：NAT 网关</li><li>HAVIP：高可用虚拟IP</li><li>ENI：弹性网卡</li><li>CLB：内网CLB</li><li>DHCPIP：弹性内网IP</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>静态单线IP网络出口</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Egress")]
        public string Egress{ get; set; }

        /// <summary>
        /// <p>高防包ID,当EIP类型为高防EIP时，返回EIP绑定的高防包ID.</p>
        /// </summary>
        [JsonProperty("AntiDDoSPackageId")]
        public string AntiDDoSPackageId{ get; set; }

        /// <summary>
        /// <p>当前EIP是否自动续费，只有按月带宽预付费的EIP才会显示该字段，具体值示例如下:</p><li>NOTIFY_AND_MANUAL_RENEW:正常续费</li><li>NOTIFY_AND_AUTO_RENEW:自动续费</li><li>DISABLE_NOTIFY_AND_MANUAL_RENEW:到期不续费 </li>
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// <p>当前公网IP所关联的带宽包ID，如果该公网IP未使用带宽包计费，则返回为空</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BandwidthPackageId")]
        public string BandwidthPackageId{ get; set; }

        /// <summary>
        /// <p>传统弹性公网IPv6所属vpc唯一ID</p>
        /// </summary>
        [JsonProperty("UnVpcId")]
        public string UnVpcId{ get; set; }

        /// <summary>
        /// <p>CDC唯一ID</p>
        /// </summary>
        [JsonProperty("DedicatedClusterId")]
        public string DedicatedClusterId{ get; set; }

        /// <summary>
        /// <p>eip是否在网卡上可见。true表示支持，false表示不支持</p>
        /// </summary>
        [JsonProperty("EipVisibleOnEni")]
        public bool? EipVisibleOnEni{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
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
            this.SetParamObj(map, prefix + "EipAlgType.", this.EipAlgType);
            this.SetParamSimple(map, prefix + "InternetServiceProvider", this.InternetServiceProvider);
            this.SetParamSimple(map, prefix + "LocalBgp", this.LocalBgp);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "InternetChargeType", this.InternetChargeType);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamSimple(map, prefix + "DeadlineDate", this.DeadlineDate);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "Egress", this.Egress);
            this.SetParamSimple(map, prefix + "AntiDDoSPackageId", this.AntiDDoSPackageId);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "BandwidthPackageId", this.BandwidthPackageId);
            this.SetParamSimple(map, prefix + "UnVpcId", this.UnVpcId);
            this.SetParamSimple(map, prefix + "DedicatedClusterId", this.DedicatedClusterId);
            this.SetParamSimple(map, prefix + "EipVisibleOnEni", this.EipVisibleOnEni);
        }
    }
}

