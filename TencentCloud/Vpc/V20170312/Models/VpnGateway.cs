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

    public class VpnGateway : AbstractModel
    {
        
        /// <summary>
        /// <p>网关实例ID。</p>
        /// </summary>
        [JsonProperty("VpnGatewayId")]
        public string VpnGatewayId{ get; set; }

        /// <summary>
        /// <p>VPC实例ID。</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>网关实例名称。</p>
        /// </summary>
        [JsonProperty("VpnGatewayName")]
        public string VpnGatewayName{ get; set; }

        /// <summary>
        /// <p>网关实例类型</p><p>枚举值：</p><ul><li>IPSEC： IPSEC VPC类型VPN</li><li>SSL： SSL VPC类型VPN</li><li>CCN： IPSEC CCN类型VPN</li><li>SSL_CCN： SSL CCN类型VPN</li></ul><p>默认值：IPSEC</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>网关实例状态。</p><p>枚举值：</p><ul><li>PENDING： 生产中</li><li>PENDING_ERROR： 生产失败</li><li>DELETING： 删除中</li><li>DELETING_ERROR： 生产失败</li><li>AVAILABLE： 运行中</li></ul>
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// <p>网关公网IP。</p>
        /// </summary>
        [JsonProperty("PublicIpAddress")]
        public string PublicIpAddress{ get; set; }

        /// <summary>
        /// <p>网关续费类型：&#39;NOTIFY_AND_MANUAL_RENEW&#39;：手动续费，&#39;NOTIFY_AND_AUTO_RENEW&#39;：自动续费，&#39;NOT_NOTIFY_AND_NOT_RENEW&#39;：到期不续费。</p>
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// <p>网关付费类型：POSTPAID_BY_HOUR：按量计费，PREPAID：包年包月预付费。</p>
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// <p>网关出带宽</p><p>单位：Mbps</p>
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public ulong? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// <p>创建时间。</p>
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// <p>预付费网关过期时间。</p>
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }

        /// <summary>
        /// <p>公网IP是否被封堵。</p>
        /// </summary>
        [JsonProperty("IsAddressBlocked")]
        public bool? IsAddressBlocked{ get; set; }

        /// <summary>
        /// <p>计费模式变更，PREPAID_TO_POSTPAID：包年包月预付费到期转按小时后付费。</p>
        /// </summary>
        [JsonProperty("NewPurchasePlan")]
        public string NewPurchasePlan{ get; set; }

        /// <summary>
        /// <p>网关计费状态，PROTECTIVELY_ISOLATED：被安全隔离的实例，NORMAL：正常。</p>
        /// </summary>
        [JsonProperty("RestrictState")]
        public string RestrictState{ get; set; }

        /// <summary>
        /// <p>可用区，如：ap-guangzhou-2。</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>网关带宽配额信息。</p>
        /// </summary>
        [JsonProperty("VpnGatewayQuotaSet")]
        public VpnGatewayQuota[] VpnGatewayQuotaSet{ get; set; }

        /// <summary>
        /// <p>网关实例版本信息。</p>
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// <p>Type值为CCN/SSL_CCN时，该值表示云联网实例ID。</p>
        /// </summary>
        [JsonProperty("NetworkInstanceId")]
        public string NetworkInstanceId{ get; set; }

        /// <summary>
        /// <p>CDC 实例ID。</p>
        /// </summary>
        [JsonProperty("CdcId")]
        public string CdcId{ get; set; }

        /// <summary>
        /// <p>SSL-VPN 客户端连接数。</p>
        /// </summary>
        [JsonProperty("MaxConnection")]
        public ulong? MaxConnection{ get; set; }

        /// <summary>
        /// <p>Bgp ASN</p>
        /// </summary>
        [JsonProperty("BgpAsn")]
        public ulong? BgpAsn{ get; set; }

        /// <summary>
        /// <p>标签列表</p>
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpnGatewayId", this.VpnGatewayId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpnGatewayName", this.VpnGatewayName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "PublicIpAddress", this.PublicIpAddress);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamSimple(map, prefix + "IsAddressBlocked", this.IsAddressBlocked);
            this.SetParamSimple(map, prefix + "NewPurchasePlan", this.NewPurchasePlan);
            this.SetParamSimple(map, prefix + "RestrictState", this.RestrictState);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamArrayObj(map, prefix + "VpnGatewayQuotaSet.", this.VpnGatewayQuotaSet);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "NetworkInstanceId", this.NetworkInstanceId);
            this.SetParamSimple(map, prefix + "CdcId", this.CdcId);
            this.SetParamSimple(map, prefix + "MaxConnection", this.MaxConnection);
            this.SetParamSimple(map, prefix + "BgpAsn", this.BgpAsn);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
        }
    }
}

