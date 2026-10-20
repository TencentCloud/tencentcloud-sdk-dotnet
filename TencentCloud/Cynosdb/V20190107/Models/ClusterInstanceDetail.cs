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

    public class ClusterInstanceDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>用户Uin</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>用户AppId</p>
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// <p>集群ID</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>集群名称</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>实例名称</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>引擎类型</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>实例状态</p><p>枚举值：</p><ul><li>creating： 创建中</li><li>running： 运行中</li><li>isolating： 隔离中</li><li>isolated： 已隔离</li><li>activating： 恢复中</li><li>offlining： 下线中</li><li>offlined： 已下线</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>实例状态</p>
        /// </summary>
        [JsonProperty("InstanceStatus")]
        [System.Obsolete]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// <p>实例状态中文描述</p>
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// <p>实例状态描述</p>
        /// </summary>
        [JsonProperty("InstanceStatusDesc")]
        [System.Obsolete]
        public string InstanceStatusDesc{ get; set; }

        /// <summary>
        /// <p>Cpu</p><p>单位：核</p>
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// <p>cpu核数</p>
        /// </summary>
        [JsonProperty("InstanceCpu")]
        [System.Obsolete]
        public long? InstanceCpu{ get; set; }

        /// <summary>
        /// <p>serverless实例cpu下限</p><p>单位：核</p>
        /// </summary>
        [JsonProperty("MinCpu")]
        public float? MinCpu{ get; set; }

        /// <summary>
        /// <p>serverless实例cpu上限</p><p>单位：核</p>
        /// </summary>
        [JsonProperty("MaxCpu")]
        public float? MaxCpu{ get; set; }

        /// <summary>
        /// <p>内存</p><p>单位：GB</p>
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// <p>内存</p>
        /// </summary>
        [JsonProperty("InstanceMemory")]
        [System.Obsolete]
        public long? InstanceMemory{ get; set; }

        /// <summary>
        /// <p>硬盘</p>
        /// </summary>
        [JsonProperty("InstanceStorage")]
        public long? InstanceStorage{ get; set; }

        /// <summary>
        /// <p>实例角色</p>
        /// </summary>
        [JsonProperty("InstanceRole")]
        public string InstanceRole{ get; set; }

        /// <summary>
        /// <p>执行开始时间(距离0点的秒数)</p>
        /// </summary>
        [JsonProperty("MaintainStartTime")]
        public long? MaintainStartTime{ get; set; }

        /// <summary>
        /// <p>持续的时间(单位：秒)</p>
        /// </summary>
        [JsonProperty("MaintainDuration")]
        public long? MaintainDuration{ get; set; }

        /// <summary>
        /// <p>可以执行的时间，枚举值：[&quot;Mon&quot;,&quot;Tue&quot;,&quot;Wed&quot;,&quot;Thu&quot;,&quot;Fri&quot;, &quot;Sat&quot;, &quot;Sun&quot;]</p>
        /// </summary>
        [JsonProperty("MaintainWeekDays")]
        public string[] MaintainWeekDays{ get; set; }

        /// <summary>
        /// <p>实例任务信息</p>
        /// </summary>
        [JsonProperty("InstanceTasks")]
        public ObjectTask[] InstanceTasks{ get; set; }

        /// <summary>
        /// <p>实例机器类型</p><p>枚举值：</p><ul><li>common： 通用型</li><li>exclusive： 独享型</li></ul>
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// <p>实例机器类型</p><ol><li>common，通用型。</li><li>exclusive，独享型。</li></ol>
        /// </summary>
        [JsonProperty("InstanceDeviceType")]
        [System.Obsolete]
        public string InstanceDeviceType{ get; set; }

        /// <summary>
        /// <p>实例存储类型<br>说明：仅当要查询的资源为 LibraDB 时，此参数才会返回值。</p>
        /// </summary>
        [JsonProperty("InstanceStorageType")]
        public string InstanceStorageType{ get; set; }

        /// <summary>
        /// <p>数据库类型</p>
        /// </summary>
        [JsonProperty("DbMode")]
        public string DbMode{ get; set; }

        /// <summary>
        /// <p>节点列表<br>说明：仅当要查询的资源为 LibraDB 时，此参数才会返回值。</p>
        /// </summary>
        [JsonProperty("NodeList")]
        public string[] NodeList{ get; set; }

        /// <summary>
        /// <p>serverless实例子状态</p>
        /// </summary>
        [JsonProperty("ServerlessStatus")]
        public string ServerlessStatus{ get; set; }

        /// <summary>
        /// <p>AI优化器状态</p>
        /// </summary>
        [JsonProperty("AIOptimizerStatus")]
        public AIOptimizerStatus AIOptimizerStatus{ get; set; }

        /// <summary>
        /// <p>项目ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// <p>地域</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>可用区</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>实例所在的物理可用区</p>
        /// </summary>
        [JsonProperty("PhysicalZone")]
        public string PhysicalZone{ get; set; }

        /// <summary>
        /// <p>数据库类型</p>
        /// </summary>
        [JsonProperty("DbType")]
        public string DbType{ get; set; }

        /// <summary>
        /// <p>数据库版本</p>
        /// </summary>
        [JsonProperty("DbVersion")]
        public string DbVersion{ get; set; }

        /// <summary>
        /// <p>存储量</p><p>单位：GB</p>
        /// </summary>
        [JsonProperty("Storage")]
        public long? Storage{ get; set; }

        /// <summary>
        /// <p>预付费存储Id</p>
        /// </summary>
        [JsonProperty("StorageId")]
        public string StorageId{ get; set; }

        /// <summary>
        /// <p>存储付费类型</p><p>枚举值：</p><ul><li>0： 后付费</li><li>1： 预付费</li></ul>
        /// </summary>
        [JsonProperty("StoragePayMode")]
        public long? StoragePayMode{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>隔离时间</p>
        /// </summary>
        [JsonProperty("IsolateTime")]
        public string IsolateTime{ get; set; }

        /// <summary>
        /// <p>实例销毁时间</p>
        /// </summary>
        [JsonProperty("DestroyTime")]
        public string DestroyTime{ get; set; }

        /// <summary>
        /// <p>销毁期限</p>
        /// </summary>
        [JsonProperty("DestroyDeadlineText")]
        public string DestroyDeadlineText{ get; set; }

        /// <summary>
        /// <p>实例过期时间</p>
        /// </summary>
        [JsonProperty("PeriodEndTime")]
        public string PeriodEndTime{ get; set; }

        /// <summary>
        /// <p>VPC网络ID</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>子网ID</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>实例内网IP</p>
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// <p>实例内网端口</p>
        /// </summary>
        [JsonProperty("Vport")]
        public long? Vport{ get; set; }

        /// <summary>
        /// <p>网络类型</p>
        /// </summary>
        [JsonProperty("NetType")]
        public long? NetType{ get; set; }

        /// <summary>
        /// <p>外网IP</p>
        /// </summary>
        [JsonProperty("WanIP")]
        public string WanIP{ get; set; }

        /// <summary>
        /// <p>外网端口</p>
        /// </summary>
        [JsonProperty("WanPort")]
        public long? WanPort{ get; set; }

        /// <summary>
        /// <p>外网开启状态</p>
        /// </summary>
        [JsonProperty("WanStatus")]
        public string WanStatus{ get; set; }

        /// <summary>
        /// <p>实例外网域名</p>
        /// </summary>
        [JsonProperty("WanDomain")]
        public string WanDomain{ get; set; }

        /// <summary>
        /// <p>实例的网络信息</p>
        /// </summary>
        [JsonProperty("InstanceNetInfo")]
        public InstanceNetInfo[] InstanceNetInfo{ get; set; }

        /// <summary>
        /// <p>付费模式</p><p>枚举值：</p><ul><li>0： 后付费</li><li>1： 预付费</li></ul>
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// <p>正在处理的任务</p>
        /// </summary>
        [JsonProperty("ProcessingTask")]
        public string ProcessingTask{ get; set; }

        /// <summary>
        /// <p>续费标志</p>
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// <p>任务</p>
        /// </summary>
        [JsonProperty("Tasks")]
        public ObjectTask[] Tasks{ get; set; }

        /// <summary>
        /// <p>是否冻结</p>
        /// </summary>
        [JsonProperty("IsFreeze")]
        public string IsFreeze{ get; set; }

        /// <summary>
        /// <p>资源标签</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceTags")]
        public Tag[] ResourceTags{ get; set; }

        /// <summary>
        /// <p>当前实例支持的能力</p>
        /// </summary>
        [JsonProperty("InstanceAbility")]
        public InstanceAbility InstanceAbility{ get; set; }

        /// <summary>
        /// <p>全球数据库唯一标识</p>
        /// </summary>
        [JsonProperty("GdnId")]
        public string GdnId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "InstanceStatusDesc", this.InstanceStatusDesc);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "InstanceCpu", this.InstanceCpu);
            this.SetParamSimple(map, prefix + "MinCpu", this.MinCpu);
            this.SetParamSimple(map, prefix + "MaxCpu", this.MaxCpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "InstanceMemory", this.InstanceMemory);
            this.SetParamSimple(map, prefix + "InstanceStorage", this.InstanceStorage);
            this.SetParamSimple(map, prefix + "InstanceRole", this.InstanceRole);
            this.SetParamSimple(map, prefix + "MaintainStartTime", this.MaintainStartTime);
            this.SetParamSimple(map, prefix + "MaintainDuration", this.MaintainDuration);
            this.SetParamArraySimple(map, prefix + "MaintainWeekDays.", this.MaintainWeekDays);
            this.SetParamArrayObj(map, prefix + "InstanceTasks.", this.InstanceTasks);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "InstanceDeviceType", this.InstanceDeviceType);
            this.SetParamSimple(map, prefix + "InstanceStorageType", this.InstanceStorageType);
            this.SetParamSimple(map, prefix + "DbMode", this.DbMode);
            this.SetParamArraySimple(map, prefix + "NodeList.", this.NodeList);
            this.SetParamSimple(map, prefix + "ServerlessStatus", this.ServerlessStatus);
            this.SetParamObj(map, prefix + "AIOptimizerStatus.", this.AIOptimizerStatus);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "PhysicalZone", this.PhysicalZone);
            this.SetParamSimple(map, prefix + "DbType", this.DbType);
            this.SetParamSimple(map, prefix + "DbVersion", this.DbVersion);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "StorageId", this.StorageId);
            this.SetParamSimple(map, prefix + "StoragePayMode", this.StoragePayMode);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "IsolateTime", this.IsolateTime);
            this.SetParamSimple(map, prefix + "DestroyTime", this.DestroyTime);
            this.SetParamSimple(map, prefix + "DestroyDeadlineText", this.DestroyDeadlineText);
            this.SetParamSimple(map, prefix + "PeriodEndTime", this.PeriodEndTime);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "NetType", this.NetType);
            this.SetParamSimple(map, prefix + "WanIP", this.WanIP);
            this.SetParamSimple(map, prefix + "WanPort", this.WanPort);
            this.SetParamSimple(map, prefix + "WanStatus", this.WanStatus);
            this.SetParamSimple(map, prefix + "WanDomain", this.WanDomain);
            this.SetParamArrayObj(map, prefix + "InstanceNetInfo.", this.InstanceNetInfo);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ProcessingTask", this.ProcessingTask);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamArrayObj(map, prefix + "Tasks.", this.Tasks);
            this.SetParamSimple(map, prefix + "IsFreeze", this.IsFreeze);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamObj(map, prefix + "InstanceAbility.", this.InstanceAbility);
            this.SetParamSimple(map, prefix + "GdnId", this.GdnId);
        }
    }
}

