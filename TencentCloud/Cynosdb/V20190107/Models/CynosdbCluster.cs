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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CynosdbCluster : AbstractModel
    {
        
        /// <summary>
        /// <p>集群状态， 可选值如下:<br>creating: 创建中<br>running:运行中<br>isolating:隔离中<br>isolated:已隔离<br>activating:解隔离中<br>offlining:下线中<br>offlined:已下线<br>deleting:删除中<br>deleted:已删除</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>可用区</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>集群名称</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>地域</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>数据库版本</p>
        /// </summary>
        [JsonProperty("DbVersion")]
        public string DbVersion{ get; set; }

        /// <summary>
        /// <p>集群ID</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>实例数</p>
        /// </summary>
        [JsonProperty("InstanceNum")]
        public long? InstanceNum{ get; set; }

        /// <summary>
        /// <p>用户uin</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>引擎类型</p>
        /// </summary>
        [JsonProperty("DbType")]
        public string DbType{ get; set; }

        /// <summary>
        /// <p>用户appid</p>
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// <p>集群状态描述</p>
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// <p>集群创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>付费模式。0-按量计费，1-包年包月</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// <p>截止时间</p>
        /// </summary>
        [JsonProperty("PeriodEndTime")]
        public string PeriodEndTime{ get; set; }

        /// <summary>
        /// <p>集群读写vip</p>
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// <p>集群读写vport</p>
        /// </summary>
        [JsonProperty("Vport")]
        public long? Vport{ get; set; }

        /// <summary>
        /// <p>项目id</p>
        /// </summary>
        [JsonProperty("ProjectID")]
        public long? ProjectID{ get; set; }

        /// <summary>
        /// <p>私有网络ID</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>子网ID</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>cynos内核版本</p>
        /// </summary>
        [JsonProperty("CynosVersion")]
        public string CynosVersion{ get; set; }

        /// <summary>
        /// <p>cynos版本标签</p>
        /// </summary>
        [JsonProperty("CynosVersionTag")]
        public string CynosVersionTag{ get; set; }

        /// <summary>
        /// <p>存储容量</p>
        /// </summary>
        [JsonProperty("StorageLimit")]
        public long? StorageLimit{ get; set; }

        /// <summary>
        /// <p>续费标志</p>
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// <p>正在处理的任务</p>
        /// </summary>
        [JsonProperty("ProcessingTask")]
        public string ProcessingTask{ get; set; }

        /// <summary>
        /// <p>集群的任务数组</p>
        /// </summary>
        [JsonProperty("Tasks")]
        public ObjectTask[] Tasks{ get; set; }

        /// <summary>
        /// <p>集群绑定的tag数组</p>
        /// </summary>
        [JsonProperty("ResourceTags")]
        public Tag[] ResourceTags{ get; set; }

        /// <summary>
        /// <p>Db类型(NORMAL, SERVERLESS)</p>
        /// </summary>
        [JsonProperty("DbMode")]
        public string DbMode{ get; set; }

        /// <summary>
        /// <p>当Db类型为SERVERLESS时，serverless集群状态，可选值:<br>resume<br>pause</p>
        /// </summary>
        [JsonProperty("ServerlessStatus")]
        public string ServerlessStatus{ get; set; }

        /// <summary>
        /// <p>集群预付费存储值大小</p>
        /// </summary>
        [JsonProperty("Storage")]
        public long? Storage{ get; set; }

        /// <summary>
        /// <p>集群存储为预付费时的存储ID，用于预付费存储变配</p>
        /// </summary>
        [JsonProperty("StorageId")]
        public string StorageId{ get; set; }

        /// <summary>
        /// <p>集群存储付费模式。0-按量计费，1-包年包月</p>
        /// </summary>
        [JsonProperty("StoragePayMode")]
        public long? StoragePayMode{ get; set; }

        /// <summary>
        /// <p>集群计算规格对应的最小存储值</p>
        /// </summary>
        [JsonProperty("MinStorageSize")]
        public long? MinStorageSize{ get; set; }

        /// <summary>
        /// <p>集群计算规格对应的最大存储值</p>
        /// </summary>
        [JsonProperty("MaxStorageSize")]
        public long? MaxStorageSize{ get; set; }

        /// <summary>
        /// <p>集群网络信息</p>
        /// </summary>
        [JsonProperty("NetAddrs")]
        public NetAddr[] NetAddrs{ get; set; }

        /// <summary>
        /// <p>物理可用区</p>
        /// </summary>
        [JsonProperty("PhysicalZone")]
        public string PhysicalZone{ get; set; }

        /// <summary>
        /// <p>主可用区</p>
        /// </summary>
        [JsonProperty("MasterZone")]
        public string MasterZone{ get; set; }

        /// <summary>
        /// <p>是否有从可用区</p>
        /// </summary>
        [JsonProperty("HasSlaveZone")]
        public string HasSlaveZone{ get; set; }

        /// <summary>
        /// <p>从可用区</p>
        /// </summary>
        [JsonProperty("SlaveZones")]
        public string[] SlaveZones{ get; set; }

        /// <summary>
        /// <p>商业类型</p>
        /// </summary>
        [JsonProperty("BusinessType")]
        public string BusinessType{ get; set; }

        /// <summary>
        /// <p>是否冻结</p>
        /// </summary>
        [JsonProperty("IsFreeze")]
        public string IsFreeze{ get; set; }

        /// <summary>
        /// <p>订单来源</p>
        /// </summary>
        [JsonProperty("OrderSource")]
        public string OrderSource{ get; set; }

        /// <summary>
        /// <p>能力</p>
        /// </summary>
        [JsonProperty("Ability")]
        public Ability Ability{ get; set; }

        /// <summary>
        /// <p>实例绑定资源包信息（此处只返回存储资源包，即packageType=DISK）</p>
        /// </summary>
        [JsonProperty("ResourcePackages")]
        public ResourcePackage[] ResourcePackages{ get; set; }

        /// <summary>
        /// <p>全球数据库唯一标识</p>
        /// </summary>
        [JsonProperty("GdnId")]
        public string GdnId{ get; set; }

        /// <summary>
        /// <p>集群角色。主集群- primary，从集群 - standby，如果 GdnId为空，该字段无效。</p>
        /// </summary>
        [JsonProperty("GdnRole")]
        public string GdnRole{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "DbVersion", this.DbVersion);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "InstanceNum", this.InstanceNum);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "DbType", this.DbType);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "PeriodEndTime", this.PeriodEndTime);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "ProjectID", this.ProjectID);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "CynosVersion", this.CynosVersion);
            this.SetParamSimple(map, prefix + "CynosVersionTag", this.CynosVersionTag);
            this.SetParamSimple(map, prefix + "StorageLimit", this.StorageLimit);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "ProcessingTask", this.ProcessingTask);
            this.SetParamArrayObj(map, prefix + "Tasks.", this.Tasks);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "DbMode", this.DbMode);
            this.SetParamSimple(map, prefix + "ServerlessStatus", this.ServerlessStatus);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "StorageId", this.StorageId);
            this.SetParamSimple(map, prefix + "StoragePayMode", this.StoragePayMode);
            this.SetParamSimple(map, prefix + "MinStorageSize", this.MinStorageSize);
            this.SetParamSimple(map, prefix + "MaxStorageSize", this.MaxStorageSize);
            this.SetParamArrayObj(map, prefix + "NetAddrs.", this.NetAddrs);
            this.SetParamSimple(map, prefix + "PhysicalZone", this.PhysicalZone);
            this.SetParamSimple(map, prefix + "MasterZone", this.MasterZone);
            this.SetParamSimple(map, prefix + "HasSlaveZone", this.HasSlaveZone);
            this.SetParamArraySimple(map, prefix + "SlaveZones.", this.SlaveZones);
            this.SetParamSimple(map, prefix + "BusinessType", this.BusinessType);
            this.SetParamSimple(map, prefix + "IsFreeze", this.IsFreeze);
            this.SetParamSimple(map, prefix + "OrderSource", this.OrderSource);
            this.SetParamObj(map, prefix + "Ability.", this.Ability);
            this.SetParamArrayObj(map, prefix + "ResourcePackages.", this.ResourcePackages);
            this.SetParamSimple(map, prefix + "GdnId", this.GdnId);
            this.SetParamSimple(map, prefix + "GdnRole", this.GdnRole);
        }
    }
}

