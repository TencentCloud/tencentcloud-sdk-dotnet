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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EmrListInstance : AbstractModel
    {
        
        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 常见状态描述：集群生产中,集群运行中,集群创建中,集群已关闭,集群已删除
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// 集群名字
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 集群地域
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// 用户APPID
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// 运行时间
        /// </summary>
        [JsonProperty("RunTime")]
        public string RunTime{ get; set; }

        /// <summary>
        /// 集群IP
        /// </summary>
        [JsonProperty("MasterIp")]
        public string MasterIp{ get; set; }

        /// <summary>
        /// 集群版本
        /// </summary>
        [JsonProperty("EmrVersion")]
        public string EmrVersion{ get; set; }

        /// <summary>
        /// 集群计费类型
        /// </summary>
        [JsonProperty("ChargeType")]
        public ulong? ChargeType{ get; set; }

        /// <summary>
        /// emr ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonProperty("ProductId")]
        public ulong? ProductId{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        [JsonProperty("RegionId")]
        public ulong? RegionId{ get; set; }

        /// <summary>
        /// 子网ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public ulong? SubnetId{ get; set; }

        /// <summary>
        /// 网络ID
        /// </summary>
        [JsonProperty("VpcId")]
        public ulong? VpcId{ get; set; }

        /// <summary>
        /// 地区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 状态码, 取值为-2(集群已删除), -1(集群已关闭), 0(集群生产中), 2(集群运行中), 3(集群创建中)
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 实例标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 告警信息
        /// </summary>
        [JsonProperty("AlarmInfo")]
        public string AlarmInfo{ get; set; }

        /// <summary>
        /// 是否是woodpecker集群
        /// </summary>
        [JsonProperty("IsWoodpeckerCluster")]
        public ulong? IsWoodpeckerCluster{ get; set; }

        /// <summary>
        /// Vpc中文
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// 子网中文
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }

        /// <summary>
        /// 字符串VpcId
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// 字符串子网
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// 集群类型
        /// </summary>
        [JsonProperty("ClusterClass")]
        public string ClusterClass{ get; set; }

        /// <summary>
        /// 是否为跨AZ集群
        /// </summary>
        [JsonProperty("IsMultiZoneCluster")]
        public bool? IsMultiZoneCluster{ get; set; }

        /// <summary>
        /// 是否手戳集群
        /// </summary>
        [JsonProperty("IsHandsCluster")]
        public bool? IsHandsCluster{ get; set; }

        /// <summary>
        /// 体外客户端组件信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutSideSoftInfo")]
        public SoftDependInfo[] OutSideSoftInfo{ get; set; }

        /// <summary>
        /// 当前集群的应用场景是否支持体外客户端
        /// </summary>
        [JsonProperty("IsSupportOutsideCluster")]
        public bool? IsSupportOutsideCluster{ get; set; }

        /// <summary>
        /// 是否专有集群场景集群
        /// </summary>
        [JsonProperty("IsDedicatedCluster")]
        public bool? IsDedicatedCluster{ get; set; }

        /// <summary>
        /// 集群支持克隆
        /// </summary>
        [JsonProperty("IsSupportClone")]
        public bool? IsSupportClone{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamSimple(map, prefix + "RunTime", this.RunTime);
            this.SetParamSimple(map, prefix + "MasterIp", this.MasterIp);
            this.SetParamSimple(map, prefix + "EmrVersion", this.EmrVersion);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "AlarmInfo", this.AlarmInfo);
            this.SetParamSimple(map, prefix + "IsWoodpeckerCluster", this.IsWoodpeckerCluster);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "SubnetName", this.SubnetName);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamSimple(map, prefix + "ClusterClass", this.ClusterClass);
            this.SetParamSimple(map, prefix + "IsMultiZoneCluster", this.IsMultiZoneCluster);
            this.SetParamSimple(map, prefix + "IsHandsCluster", this.IsHandsCluster);
            this.SetParamArrayObj(map, prefix + "OutSideSoftInfo.", this.OutSideSoftInfo);
            this.SetParamSimple(map, prefix + "IsSupportOutsideCluster", this.IsSupportOutsideCluster);
            this.SetParamSimple(map, prefix + "IsDedicatedCluster", this.IsDedicatedCluster);
            this.SetParamSimple(map, prefix + "IsSupportClone", this.IsSupportClone);
        }
    }
}

