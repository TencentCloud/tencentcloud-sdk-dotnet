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

    public class CloudAttachInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>敏捷上云实例id</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>敏捷上云名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>合作伙伴的AppId</p>
        /// </summary>
        [JsonProperty("IapId")]
        public string IapId{ get; set; }

        /// <summary>
        /// <p>需要接入敏捷上云的IDC的地址</p>
        /// </summary>
        [JsonProperty("IdcAddress")]
        public string IdcAddress{ get; set; }

        /// <summary>
        /// <p>需要接入敏捷上云的IDC的互联网服务提供商类型</p>
        /// </summary>
        [JsonProperty("IdcType")]
        public string IdcType{ get; set; }

        /// <summary>
        /// <p>敏捷上云的带宽，单位为MB</p>
        /// </summary>
        [JsonProperty("Bandwidth")]
        public ulong? Bandwidth{ get; set; }

        /// <summary>
        /// <p>联系电话</p>
        /// </summary>
        [JsonProperty("Telephone")]
        public string Telephone{ get; set; }

        /// <summary>
        /// <p>敏捷上云的状态<br>available：就绪状态<br>applying：申请，待审核状态<br>pendingpay：代付款状态<br>building：建设中状态<br>confirming：待确认状态<br>isolate: 隔离状态<br>stoped：终止状态</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>敏捷上云申请的时间</p>
        /// </summary>
        [JsonProperty("ApplyTime")]
        public string ApplyTime{ get; set; }

        /// <summary>
        /// <p>敏捷上云建设完成的时间</p>
        /// </summary>
        [JsonProperty("ReadyTime")]
        public string ReadyTime{ get; set; }

        /// <summary>
        /// <p>敏捷上云过期时间</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// <p>备注信息</p>
        /// </summary>
        [JsonProperty("Remarks")]
        public string Remarks{ get; set; }

        /// <summary>
        /// <p>敏捷上云的地域状态。<br>same-region：同地域<br>cross-region：跨地域</p>
        /// </summary>
        [JsonProperty("RegionStatus")]
        public string RegionStatus{ get; set; }

        /// <summary>
        /// <p>用户的AppId</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>用户的Uin</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>用户注册名称</p>
        /// </summary>
        [JsonProperty("CustomerAuthName")]
        public string CustomerAuthName{ get; set; }

        /// <summary>
        /// <p>物理专线实例ID</p>
        /// </summary>
        [JsonProperty("DirectConnectId")]
        public string DirectConnectId{ get; set; }

        /// <summary>
        /// <p>敏捷上云是否支持创建高速上云专线网关</p>
        /// </summary>
        [JsonProperty("CloudAttachServiceGatewaysSupport")]
        public bool? CloudAttachServiceGatewaysSupport{ get; set; }

        /// <summary>
        /// <p>敏捷上云服务是否处于升降配中</p>
        /// </summary>
        [JsonProperty("BUpdateBandwidth")]
        public bool? BUpdateBandwidth{ get; set; }

        /// <summary>
        /// <p>接入地域</p>
        /// </summary>
        [JsonProperty("ArRegion")]
        public string ArRegion{ get; set; }

        /// <summary>
        /// <p>运营商代码</p>
        /// </summary>
        [JsonProperty("IapCode")]
        public string IapCode{ get; set; }

        /// <summary>
        /// <p>IDC侧类型。枚举值：CLOUD-云，ISP-运营商，OTHER-第三方</p>
        /// </summary>
        [JsonProperty("IdcPointType")]
        public string IdcPointType{ get; set; }

        /// <summary>
        /// <p>运营商链路是否有保护</p>
        /// </summary>
        [JsonProperty("BIapLinkProtected")]
        public bool? BIapLinkProtected{ get; set; }

        /// <summary>
        /// <p>服务类型：SHARE-共享型，EXCLUSIVE-独占型</p>
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// <p>VLAN范围</p>
        /// </summary>
        [JsonProperty("VlanRange")]
        public string VlanRange{ get; set; }

        /// <summary>
        /// <p>裁撤状态</p><p>枚举值：</p><ul><li>APPLYING： 申请裁撤</li><li>EXECUTING： 裁撤执行中</li><li>FAILED： 裁撤失败</li></ul>
        /// </summary>
        [JsonProperty("RepealStatus")]
        public string RepealStatus{ get; set; }

        /// <summary>
        /// <p>计划裁撤时间</p>
        /// </summary>
        [JsonProperty("PlanRepealTime")]
        public string PlanRepealTime{ get; set; }

        /// <summary>
        /// <p>续费标记</p><p>枚举值：</p><ul><li>MANUAL_RENEW： 手动续费</li><li>AUTO_RENEW： 自动续费</li><li>NO_RENEW： 到期不续</li></ul>
        /// </summary>
        [JsonProperty("RenewFlag")]
        public string RenewFlag{ get; set; }

        /// <summary>
        /// <p>接入点ID</p>
        /// </summary>
        [JsonProperty("AccessPointId")]
        public string AccessPointId{ get; set; }

        /// <summary>
        /// <p>接入点名称</p>
        /// </summary>
        [JsonProperty("AccessPointName")]
        public string AccessPointName{ get; set; }

        /// <summary>
        /// <p>计费阶梯带宽(Mbps)</p>
        /// </summary>
        [JsonProperty("BillStairBandwidth")]
        public ulong? BillStairBandwidth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IapId", this.IapId);
            this.SetParamSimple(map, prefix + "IdcAddress", this.IdcAddress);
            this.SetParamSimple(map, prefix + "IdcType", this.IdcType);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "Telephone", this.Telephone);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ApplyTime", this.ApplyTime);
            this.SetParamSimple(map, prefix + "ReadyTime", this.ReadyTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "Remarks", this.Remarks);
            this.SetParamSimple(map, prefix + "RegionStatus", this.RegionStatus);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "CustomerAuthName", this.CustomerAuthName);
            this.SetParamSimple(map, prefix + "DirectConnectId", this.DirectConnectId);
            this.SetParamSimple(map, prefix + "CloudAttachServiceGatewaysSupport", this.CloudAttachServiceGatewaysSupport);
            this.SetParamSimple(map, prefix + "BUpdateBandwidth", this.BUpdateBandwidth);
            this.SetParamSimple(map, prefix + "ArRegion", this.ArRegion);
            this.SetParamSimple(map, prefix + "IapCode", this.IapCode);
            this.SetParamSimple(map, prefix + "IdcPointType", this.IdcPointType);
            this.SetParamSimple(map, prefix + "BIapLinkProtected", this.BIapLinkProtected);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "VlanRange", this.VlanRange);
            this.SetParamSimple(map, prefix + "RepealStatus", this.RepealStatus);
            this.SetParamSimple(map, prefix + "PlanRepealTime", this.PlanRepealTime);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "AccessPointId", this.AccessPointId);
            this.SetParamSimple(map, prefix + "AccessPointName", this.AccessPointName);
            this.SetParamSimple(map, prefix + "BillStairBandwidth", this.BillStairBandwidth);
        }
    }
}

