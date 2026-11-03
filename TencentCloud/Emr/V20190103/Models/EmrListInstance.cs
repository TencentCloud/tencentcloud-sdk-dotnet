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
        /// <p>集群ID</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>常见状态描述：集群生产中,集群运行中,集群创建中,集群已关闭,集群已删除</p>
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// <p>集群名字</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>集群地域</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// <p>用户APPID</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// <p>运行时间</p>
        /// </summary>
        [JsonProperty("RunTime")]
        public string RunTime{ get; set; }

        /// <summary>
        /// <p>集群IP</p>
        /// </summary>
        [JsonProperty("MasterIp")]
        public string MasterIp{ get; set; }

        /// <summary>
        /// <p>集群版本</p>
        /// </summary>
        [JsonProperty("EmrVersion")]
        public string EmrVersion{ get; set; }

        /// <summary>
        /// <p>集群计费类型</p>
        /// </summary>
        [JsonProperty("ChargeType")]
        public ulong? ChargeType{ get; set; }

        /// <summary>
        /// <p>emr ID</p>
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// <p>产品ID</p>
        /// </summary>
        [JsonProperty("ProductId")]
        public ulong? ProductId{ get; set; }

        /// <summary>
        /// <p>项目ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// <p>区域</p>
        /// </summary>
        [JsonProperty("RegionId")]
        public ulong? RegionId{ get; set; }

        /// <summary>
        /// <p>子网ID</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public ulong? SubnetId{ get; set; }

        /// <summary>
        /// <p>网络ID</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public ulong? VpcId{ get; set; }

        /// <summary>
        /// <p>地区</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>状态码, 取值为-2(集群已删除), -1(集群已关闭), 0(集群生产中), 2(集群运行中), 3(集群创建中)</p>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>实例标签</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>告警信息</p>
        /// </summary>
        [JsonProperty("AlarmInfo")]
        public string AlarmInfo{ get; set; }

        /// <summary>
        /// <p>是否是woodpecker集群</p>
        /// </summary>
        [JsonProperty("IsWoodpeckerCluster")]
        public ulong? IsWoodpeckerCluster{ get; set; }

        /// <summary>
        /// <p>Vpc中文</p>
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// <p>子网中文</p>
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }

        /// <summary>
        /// <p>字符串VpcId</p>
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// <p>字符串子网</p>
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// <p>集群类型</p>
        /// </summary>
        [JsonProperty("ClusterClass")]
        public string ClusterClass{ get; set; }

        /// <summary>
        /// <p>是否为跨AZ集群</p>
        /// </summary>
        [JsonProperty("IsMultiZoneCluster")]
        public bool? IsMultiZoneCluster{ get; set; }

        /// <summary>
        /// <p>是否手戳集群</p>
        /// </summary>
        [JsonProperty("IsHandsCluster")]
        public bool? IsHandsCluster{ get; set; }

        /// <summary>
        /// <p>体外客户端组件信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutSideSoftInfo")]
        public SoftDependInfo[] OutSideSoftInfo{ get; set; }

        /// <summary>
        /// <p>当前集群的应用场景是否支持体外客户端</p>
        /// </summary>
        [JsonProperty("IsSupportOutsideCluster")]
        public bool? IsSupportOutsideCluster{ get; set; }

        /// <summary>
        /// <p>是否专有集群场景集群</p>
        /// </summary>
        [JsonProperty("IsDedicatedCluster")]
        public bool? IsDedicatedCluster{ get; set; }

        /// <summary>
        /// <p>集群支持克隆</p>
        /// </summary>
        [JsonProperty("IsSupportClone")]
        public bool? IsSupportClone{ get; set; }

        /// <summary>
        /// <p>集群包含的组件</p>
        /// </summary>
        [JsonProperty("Soft")]
        public string[] Soft{ get; set; }

        /// <summary>
        /// <p>是否开启了实例保护</p>
        /// </summary>
        [JsonProperty("IsTerminateProtection")]
        public bool? IsTerminateProtection{ get; set; }

        /// <summary>
        /// <p>mcp密码信息</p>
        /// </summary>
        [JsonProperty("McpPasswordInfo")]
        public McpPasswordInfo McpPasswordInfo{ get; set; }


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
            this.SetParamArraySimple(map, prefix + "Soft.", this.Soft);
            this.SetParamSimple(map, prefix + "IsTerminateProtection", this.IsTerminateProtection);
            this.SetParamObj(map, prefix + "McpPasswordInfo.", this.McpPasswordInfo);
        }
    }
}

