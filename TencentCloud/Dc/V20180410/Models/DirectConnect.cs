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

namespace TencentCloud.Dc.V20180410.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DirectConnect : AbstractModel
    {
        
        /// <summary>
        /// 物理专线ID。
        /// </summary>
        [JsonProperty("DirectConnectId")]
        public string DirectConnectId{ get; set; }

        /// <summary>
        /// 物理专线的名称。
        /// </summary>
        [JsonProperty("DirectConnectName")]
        public string DirectConnectName{ get; set; }

        /// <summary>
        /// 物理专线的接入点ID。
        /// </summary>
        [JsonProperty("AccessPointId")]
        public string AccessPointId{ get; set; }

        /// <summary>
        /// 物理专线的状态。
        /// 申请中：PENDING 
        /// 申请驳回：REJECTED   
        /// 待付款：TOPAY 
        /// 已付款：PAID 
        /// 建设中：ALLOCATED   
        /// 已开通：AVAILABLE  
        /// 删除中 ：DELETING
        /// 已删除：DELETED 。
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 物理专线创建时间。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 物理专线的开通时间。
        /// </summary>
        [JsonProperty("EnabledTime")]
        public string EnabledTime{ get; set; }

        /// <summary>
        /// 提供接入物理专线的运营商。ChinaTelecom：中国电信， ChinaMobile：中国移动，ChinaUnicom：中国联通， In-houseWiring：楼内线，ChinaOther：中国其他， InternationalOperator：境外其他。
        /// </summary>
        [JsonProperty("LineOperator")]
        public string LineOperator{ get; set; }

        /// <summary>
        /// 本地数据中心的地理位置。
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// 物理专线接入接口带宽，单位为Mbps。
        /// </summary>
        [JsonProperty("Bandwidth")]
        public long? Bandwidth{ get; set; }

        /// <summary>
        /// 用户侧物理专线接入端口类型,取值：100Base-T：百兆电口,1000Base-T（默认值）：千兆电口,1000Base-LX：千兆单模光口（10千米）,10GBase-T：万兆电口10GBase-LR：万兆单模光口（10千米），默认值，千兆单模光口（10千米）
        /// </summary>
        [JsonProperty("PortType")]
        public string PortType{ get; set; }

        /// <summary>
        /// 运营商或者服务商为物理专线提供的电路编码。
        /// </summary>
        [JsonProperty("CircuitCode")]
        public string CircuitCode{ get; set; }

        /// <summary>
        /// 冗余物理专线的ID。
        /// </summary>
        [JsonProperty("RedundantDirectConnectId")]
        public string RedundantDirectConnectId{ get; set; }

        /// <summary>
        /// 物理专线调试VLAN。默认开启VLAN，自动分配VLAN。
        /// </summary>
        [JsonProperty("Vlan")]
        public long? Vlan{ get; set; }

        /// <summary>
        /// 物理专线调试腾讯侧互联IP。
        /// </summary>
        [JsonProperty("TencentAddress")]
        public string TencentAddress{ get; set; }

        /// <summary>
        /// 物理专线调试用户侧互联IP。
        /// </summary>
        [JsonProperty("CustomerAddress")]
        public string CustomerAddress{ get; set; }

        /// <summary>
        /// 物理专线申请者姓名。默认从账户体系获取。
        /// </summary>
        [JsonProperty("CustomerName")]
        public string CustomerName{ get; set; }

        /// <summary>
        /// 物理专线申请者联系邮箱。默认从账户体系获取。
        /// </summary>
        [JsonProperty("CustomerContactMail")]
        public string CustomerContactMail{ get; set; }

        /// <summary>
        /// 物理专线申请者联系号码。默认从账户体系获取。
        /// </summary>
        [JsonProperty("CustomerContactNumber")]
        public string CustomerContactNumber{ get; set; }

        /// <summary>
        /// 物理专线的过期时间。
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public string ExpiredTime{ get; set; }

        /// <summary>
        /// 物理专线计费类型。 NON_RECURRING_CHARGE：一次性接入费用；PREPAID_BY_YEAR：按年预付费。
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// 报障联系人。
        /// </summary>
        [JsonProperty("FaultReportContactPerson")]
        public string FaultReportContactPerson{ get; set; }

        /// <summary>
        /// 报障联系电话。
        /// </summary>
        [JsonProperty("FaultReportContactNumber")]
        public string FaultReportContactNumber{ get; set; }

        /// <summary>
        /// 报障联系邮箱。
        /// </summary>
        [JsonProperty("FaultReportContactEmail")]
        public string FaultReportContactEmail{ get; set; }

        /// <summary>
        /// 标签键值对
        /// </summary>
        [JsonProperty("TagSet")]
        public Tag[] TagSet{ get; set; }

        /// <summary>
        /// 物理专线的接入点类型。
        /// </summary>
        [JsonProperty("AccessPointType")]
        public string AccessPointType{ get; set; }

        /// <summary>
        /// IDC所在城市
        /// </summary>
        [JsonProperty("IdcCity")]
        public string IdcCity{ get; set; }

        /// <summary>
        /// 计费状态
        /// </summary>
        [JsonProperty("ChargeState")]
        public string ChargeState{ get; set; }

        /// <summary>
        /// 物理专线开通时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 物理专线是否已签署用户协议
        /// </summary>
        [JsonProperty("SignLaw")]
        public bool? SignLaw{ get; set; }

        /// <summary>
        /// 物理专线是否为LocalZone
        /// </summary>
        [JsonProperty("LocalZone")]
        public bool? LocalZone{ get; set; }

        /// <summary>
        /// 该物理专线下vlan 0的专用通道数量
        /// </summary>
        [JsonProperty("VlanZeroDirectConnectTunnelCount")]
        public ulong? VlanZeroDirectConnectTunnelCount{ get; set; }

        /// <summary>
        /// 该物理专线下非vlan 0的专用通道数量
        /// </summary>
        [JsonProperty("OtherVlanDirectConnectTunnelCount")]
        public ulong? OtherVlanDirectConnectTunnelCount{ get; set; }

        /// <summary>
        /// 物理专线最小带宽
        /// </summary>
        [JsonProperty("MinBandwidth")]
        public ulong? MinBandwidth{ get; set; }

        /// <summary>
        /// 建设模式
        /// </summary>
        [JsonProperty("Construct")]
        public ulong? Construct{ get; set; }

        /// <summary>
        /// 物理专线的接入点名称
        /// </summary>
        [JsonProperty("AccessPointName")]
        public string AccessPointName{ get; set; }

        /// <summary>
        /// 是否三层架构
        /// </summary>
        [JsonProperty("IsThreeArch")]
        public bool? IsThreeArch{ get; set; }

        /// <summary>
        /// 是否MACsec
        /// </summary>
        [JsonProperty("IsMacSec")]
        public bool? IsMacSec{ get; set; }

        /// <summary>
        /// 端口规格(Mbps)
        /// </summary>
        [JsonProperty("PortSpecification")]
        public ulong? PortSpecification{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DirectConnectId", this.DirectConnectId);
            this.SetParamSimple(map, prefix + "DirectConnectName", this.DirectConnectName);
            this.SetParamSimple(map, prefix + "AccessPointId", this.AccessPointId);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "EnabledTime", this.EnabledTime);
            this.SetParamSimple(map, prefix + "LineOperator", this.LineOperator);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "PortType", this.PortType);
            this.SetParamSimple(map, prefix + "CircuitCode", this.CircuitCode);
            this.SetParamSimple(map, prefix + "RedundantDirectConnectId", this.RedundantDirectConnectId);
            this.SetParamSimple(map, prefix + "Vlan", this.Vlan);
            this.SetParamSimple(map, prefix + "TencentAddress", this.TencentAddress);
            this.SetParamSimple(map, prefix + "CustomerAddress", this.CustomerAddress);
            this.SetParamSimple(map, prefix + "CustomerName", this.CustomerName);
            this.SetParamSimple(map, prefix + "CustomerContactMail", this.CustomerContactMail);
            this.SetParamSimple(map, prefix + "CustomerContactNumber", this.CustomerContactNumber);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "FaultReportContactPerson", this.FaultReportContactPerson);
            this.SetParamSimple(map, prefix + "FaultReportContactNumber", this.FaultReportContactNumber);
            this.SetParamSimple(map, prefix + "FaultReportContactEmail", this.FaultReportContactEmail);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamSimple(map, prefix + "AccessPointType", this.AccessPointType);
            this.SetParamSimple(map, prefix + "IdcCity", this.IdcCity);
            this.SetParamSimple(map, prefix + "ChargeState", this.ChargeState);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "SignLaw", this.SignLaw);
            this.SetParamSimple(map, prefix + "LocalZone", this.LocalZone);
            this.SetParamSimple(map, prefix + "VlanZeroDirectConnectTunnelCount", this.VlanZeroDirectConnectTunnelCount);
            this.SetParamSimple(map, prefix + "OtherVlanDirectConnectTunnelCount", this.OtherVlanDirectConnectTunnelCount);
            this.SetParamSimple(map, prefix + "MinBandwidth", this.MinBandwidth);
            this.SetParamSimple(map, prefix + "Construct", this.Construct);
            this.SetParamSimple(map, prefix + "AccessPointName", this.AccessPointName);
            this.SetParamSimple(map, prefix + "IsThreeArch", this.IsThreeArch);
            this.SetParamSimple(map, prefix + "IsMacSec", this.IsMacSec);
            this.SetParamSimple(map, prefix + "PortSpecification", this.PortSpecification);
        }
    }
}

