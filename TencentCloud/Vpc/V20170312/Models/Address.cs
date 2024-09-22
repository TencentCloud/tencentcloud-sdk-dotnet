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
        /// EIP 资源类型，包括CalcIP、WanIP、EIP和AnycastEIP、高防EIP。其中：`CalcIP` 表示设备 IP，`WanIP` 表示普通公网 IP，`EIP` 表示弹性公网 IP，`AnycastEIP` 表示加速 EIP，`AntiDDoSEIP`表示高防EIP。
        /// </summary>
        [JsonProperty("AddressType")]
        public string AddressType{ get; set; }

        /// <summary>
        /// eip是否在解绑后自动释放。true表示eip将会在解绑后自动释放，false表示eip在解绑后不会自动释放
        /// </summary>
        [JsonProperty("CascadeRelease")]
        public bool? CascadeRelease{ get; set; }

        /// <summary>
        /// EIP ALG开启的协议类型。
        /// </summary>
        [JsonProperty("EipAlgType")]
        public AlgType EipAlgType{ get; set; }

        /// <summary>
        /// 弹性公网IP的运营商信息，当前可能返回值包括"CMCC","CTCC","CUCC","BGP"
        /// </summary>
        [JsonProperty("InternetServiceProvider")]
        public string InternetServiceProvider{ get; set; }

        /// <summary>
        /// 是否本地带宽EIP
        /// </summary>
        [JsonProperty("LocalBgp")]
        public bool? LocalBgp{ get; set; }

        /// <summary>
        /// 弹性公网IP的带宽值。注意，传统账户类型账户的弹性公网IP没有带宽属性，值为空。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Bandwidth")]
        public ulong? Bandwidth{ get; set; }

        /// <summary>
        /// 弹性公网IP的网络计费模式。注意，传统账户类型账户的弹性公网IP没有网络计费模式属性，值为空。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// 包括：
        /// <li><strong>BANDWIDTH_PREPAID_BY_MONTH</strong></li>
        /// <p style="padding-left: 30px;">表示包月带宽预付费。</p>
        /// <li><strong>TRAFFIC_POSTPAID_BY_HOUR</strong></li>
        /// <p style="padding-left: 30px;">表示按小时流量后付费。</p>
        /// <li><strong>BANDWIDTH_POSTPAID_BY_HOUR</strong></li>
        /// <p style="padding-left: 30px;">表示按小时带宽后付费。</p>
        /// <li><strong>BANDWIDTH_PACKAGE</strong></li>
        /// <p style="padding-left: 30px;">表示共享带宽包。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InternetChargeType")]
        public string InternetChargeType{ get; set; }

        /// <summary>
        /// 弹性公网IP关联的标签列表。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }

        /// <summary>
        /// 到期时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeadlineDate")]
        public string DeadlineDate{ get; set; }

        /// <summary>
        /// EIP绑定的实例类型。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 静态单线IP网络出口
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Egress")]
        public string Egress{ get; set; }

        /// <summary>
        /// 高防包ID,当EIP类型为高防EIP时，返回EIP绑定的高防包ID.
        /// </summary>
        [JsonProperty("AntiDDoSPackageId")]
        public string AntiDDoSPackageId{ get; set; }

        /// <summary>
        /// 当前EIP是否自动续费，只有按月带宽预付费的EIP才会显示该字段，具体值示例如下:
        /// <li>NOTIFY_AND_MANUAL_RENEW:正常续费</li><li>NOTIFY_AND_AUTO_RENEW:自动续费</li><li>DISABLE_NOTIFY_AND_MANUAL_RENEW:到期不续费 </li>
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// 当前公网IP所关联的带宽包ID，如果该公网IP未使用带宽包计费，则返回为空
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BandwidthPackageId")]
        public string BandwidthPackageId{ get; set; }

        /// <summary>
        /// 传统弹性公网IPv6所属vpc唯一ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnVpcId")]
        public string UnVpcId{ get; set; }


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
        }
    }
}

