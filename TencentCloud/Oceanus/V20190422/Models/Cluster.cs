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

namespace TencentCloud.Oceanus.V20190422.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Cluster : AbstractModel
    {
        
        /// <summary>
        /// 集群 ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 用户 AppID
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 主账号 UIN
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// 创建者 UIN
        /// </summary>
        [JsonProperty("CreatorUin")]
        public string CreatorUin{ get; set; }

        /// <summary>
        /// 集群状态, 1 未初始化,3 初始化中，2 运行中
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 集群创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 最后一次操作集群的时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// CU 数量
        /// </summary>
        [JsonProperty("CuNum")]
        public ulong? CuNum{ get; set; }

        /// <summary>
        /// CU 内存规格
        /// </summary>
        [JsonProperty("CuMem")]
        public ulong? CuMem{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 状态描述
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// 网络
        /// </summary>
        [JsonProperty("CCNs")]
        public CCN[] CCNs{ get; set; }

        /// <summary>
        /// 网络
        /// </summary>
        [JsonProperty("NetEnvironmentType")]
        public ulong? NetEnvironmentType{ get; set; }

        /// <summary>
        /// 空闲 CU
        /// </summary>
        [JsonProperty("FreeCuNum")]
        public long? FreeCuNum{ get; set; }

        /// <summary>
        /// 集群绑定的标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 集群隔离时间; 没隔离时间，则为 -
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsolatedTime")]
        public string IsolatedTime{ get; set; }

        /// <summary>
        /// 集群过期时间; 没过期概念，则为 -
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 距离过期还有多少秒; 没过期概念，则为 -
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecondsUntilExpiry")]
        public string SecondsUntilExpiry{ get; set; }

        /// <summary>
        /// 自动续费标记，0 表示默认状态 (用户未设置，即初始状态，用户开通了预付费不停服特权会进行自动续费)， 1 表示自动续费，2表示明确不自动续费(用户设置)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 集群的默认 COS 存储桶
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultCOSBucket")]
        public string DefaultCOSBucket{ get; set; }

        /// <summary>
        /// 集群的CLS 日志集 LogSet
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CLSLogSet")]
        public string CLSLogSet{ get; set; }

        /// <summary>
        /// 集群的CLS 日志主题 TopicId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CLSTopicId")]
        public string CLSTopicId{ get; set; }

        /// <summary>
        /// 集群的CLS 日志集  名字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CLSLogName")]
        public string CLSLogName{ get; set; }

        /// <summary>
        /// 集群的CLS 日志主题  名字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CLSTopicName")]
        public string CLSTopicName{ get; set; }

        /// <summary>
        /// 集群的版本信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Version")]
        public ClusterVersion Version{ get; set; }

        /// <summary>
        /// 细粒度资源下的空闲CU
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FreeCu")]
        public float? FreeCu{ get; set; }

        /// <summary>
        /// 集群的默认日志采集配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultLogCollectConf")]
        public string DefaultLogCollectConf{ get; set; }

        /// <summary>
        /// 取值：0-没有设置，1-已设置，2-不允许设置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomizedDNSEnabled")]
        public long? CustomizedDNSEnabled{ get; set; }

        /// <summary>
        /// 空间信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Correlations")]
        public WorkSpaceClusterItem[] Correlations{ get; set; }

        /// <summary>
        /// 运行CU
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunningCu")]
        public float? RunningCu{ get; set; }

        /// <summary>
        /// 0 后付费,1 预付费
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// 前端区分 集群是否需要2CU逻辑 因为历史集群 变配不需要, default 1  新集群都需要
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsNeedManageNode")]
        public long? IsNeedManageNode{ get; set; }

        /// <summary>
        /// session集群信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterSessions")]
        public ClusterSession[] ClusterSessions{ get; set; }

        /// <summary>
        /// V3版本 = 2
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ArchGeneration")]
        public ulong? ArchGeneration{ get; set; }

        /// <summary>
        /// 0:TKE, 1:EKS
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterType")]
        public ulong? ClusterType{ get; set; }

        /// <summary>
        /// 订单信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Orders")]
        public Order[] Orders{ get; set; }

        /// <summary>
        /// Gateway信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SqlGateways")]
        public SqlGatewayItem[] SqlGateways{ get; set; }

        /// <summary>
        /// 0 公网访问 // 1 内网访问	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WebUIType")]
        public long? WebUIType{ get; set; }

        /// <summary>
        /// 2 独享集群
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 子eks集群
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubEks")]
        public SubEks SubEks{ get; set; }

        /// <summary>
        /// 上级集群
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AgentSerialId")]
        public string AgentSerialId{ get; set; }

        /// <summary>
        /// 资源类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceType")]
        public long? ResourceType{ get; set; }

        /// <summary>
        /// 集群类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BillingResourceMode")]
        public string BillingResourceMode{ get; set; }

        /// <summary>
        /// Cu比例
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MemRatio")]
        public long? MemRatio{ get; set; }

        /// <summary>
        /// 是否开启跨租户弹性网卡
        /// </summary>
        [JsonProperty("CrossTenantEniMode")]
        public long? CrossTenantEniMode{ get; set; }

        /// <summary>
        /// 总的CPU
        /// </summary>
        [JsonProperty("TotalCpu")]
        public float? TotalCpu{ get; set; }

        /// <summary>
        /// 总的内存
        /// </summary>
        [JsonProperty("TotalMem")]
        public float? TotalMem{ get; set; }

        /// <summary>
        /// 运行的CPU
        /// </summary>
        [JsonProperty("RunningCpu")]
        public float? RunningCpu{ get; set; }

        /// <summary>
        /// 运行的内存
        /// </summary>
        [JsonProperty("RunningMem")]
        public float? RunningMem{ get; set; }

        /// <summary>
        /// setats集群
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Setats")]
        public Setats Setats{ get; set; }

        /// <summary>
        /// []
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Yarns")]
        public HadoopYarnItem[] Yarns{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "CreatorUin", this.CreatorUin);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "CuNum", this.CuNum);
            this.SetParamSimple(map, prefix + "CuMem", this.CuMem);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamArrayObj(map, prefix + "CCNs.", this.CCNs);
            this.SetParamSimple(map, prefix + "NetEnvironmentType", this.NetEnvironmentType);
            this.SetParamSimple(map, prefix + "FreeCuNum", this.FreeCuNum);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "IsolatedTime", this.IsolatedTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "SecondsUntilExpiry", this.SecondsUntilExpiry);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "DefaultCOSBucket", this.DefaultCOSBucket);
            this.SetParamSimple(map, prefix + "CLSLogSet", this.CLSLogSet);
            this.SetParamSimple(map, prefix + "CLSTopicId", this.CLSTopicId);
            this.SetParamSimple(map, prefix + "CLSLogName", this.CLSLogName);
            this.SetParamSimple(map, prefix + "CLSTopicName", this.CLSTopicName);
            this.SetParamObj(map, prefix + "Version.", this.Version);
            this.SetParamSimple(map, prefix + "FreeCu", this.FreeCu);
            this.SetParamSimple(map, prefix + "DefaultLogCollectConf", this.DefaultLogCollectConf);
            this.SetParamSimple(map, prefix + "CustomizedDNSEnabled", this.CustomizedDNSEnabled);
            this.SetParamArrayObj(map, prefix + "Correlations.", this.Correlations);
            this.SetParamSimple(map, prefix + "RunningCu", this.RunningCu);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "IsNeedManageNode", this.IsNeedManageNode);
            this.SetParamArrayObj(map, prefix + "ClusterSessions.", this.ClusterSessions);
            this.SetParamSimple(map, prefix + "ArchGeneration", this.ArchGeneration);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamArrayObj(map, prefix + "Orders.", this.Orders);
            this.SetParamArrayObj(map, prefix + "SqlGateways.", this.SqlGateways);
            this.SetParamSimple(map, prefix + "WebUIType", this.WebUIType);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "SubEks.", this.SubEks);
            this.SetParamSimple(map, prefix + "AgentSerialId", this.AgentSerialId);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "BillingResourceMode", this.BillingResourceMode);
            this.SetParamSimple(map, prefix + "MemRatio", this.MemRatio);
            this.SetParamSimple(map, prefix + "CrossTenantEniMode", this.CrossTenantEniMode);
            this.SetParamSimple(map, prefix + "TotalCpu", this.TotalCpu);
            this.SetParamSimple(map, prefix + "TotalMem", this.TotalMem);
            this.SetParamSimple(map, prefix + "RunningCpu", this.RunningCpu);
            this.SetParamSimple(map, prefix + "RunningMem", this.RunningMem);
            this.SetParamObj(map, prefix + "Setats.", this.Setats);
            this.SetParamArrayObj(map, prefix + "Yarns.", this.Yarns);
        }
    }
}

