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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataEngineInfo : AbstractModel
    {
        
        /// <summary>
        /// DataEngine名称
        /// </summary>
        [JsonProperty("DataEngineName")]
        public string DataEngineName{ get; set; }

        /// <summary>
        /// 引擎类型 spark/presto
        /// </summary>
        [JsonProperty("EngineType")]
        public string EngineType{ get; set; }

        /// <summary>
        /// 集群资源类型 spark_private/presto_private/presto_cu/spark_cu
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// 引用ID
        /// </summary>
        [JsonProperty("QuotaId")]
        public string QuotaId{ get; set; }

        /// <summary>
        /// 数据引擎状态  -2已删除 -1失败 0初始化中 1挂起 2运行中 3准备删除 4删除中
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// 集群规格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

        /// <summary>
        /// 计费模式 0共享模式 1按量计费 2包年包月
        /// </summary>
        [JsonProperty("Mode")]
        public long? Mode{ get; set; }

        /// <summary>
        /// 最小集群数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MinClusters")]
        public long? MinClusters{ get; set; }

        /// <summary>
        /// 最大集群数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxClusters")]
        public long? MaxClusters{ get; set; }

        /// <summary>
        /// 是否自动恢复
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoResume")]
        public bool? AutoResume{ get; set; }

        /// <summary>
        /// 自动恢复时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SpendAfter")]
        public long? SpendAfter{ get; set; }

        /// <summary>
        /// 集群网段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// 是否为默认引擎
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultDataEngine")]
        public bool? DefaultDataEngine{ get; set; }

        /// <summary>
        /// 返回信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// 引擎id
        /// </summary>
        [JsonProperty("DataEngineId")]
        public string DataEngineId{ get; set; }

        /// <summary>
        /// 操作者
        /// </summary>
        [JsonProperty("SubAccountUin")]
        public string SubAccountUin{ get; set; }

        /// <summary>
        /// 到期时间
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 隔离时间
        /// </summary>
        [JsonProperty("IsolatedTime")]
        public string IsolatedTime{ get; set; }

        /// <summary>
        /// 冲正时间
        /// </summary>
        [JsonProperty("ReversalTime")]
        public string ReversalTime{ get; set; }

        /// <summary>
        /// 用户名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserAlias")]
        public string UserAlias{ get; set; }

        /// <summary>
        /// 标签对集合
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagList")]
        public TagInfo[] TagList{ get; set; }

        /// <summary>
        /// 引擎拥有的权限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Permissions")]
        public string[] Permissions{ get; set; }

        /// <summary>
        /// 是否自定挂起集群：false（默认）：不自动挂起、true：自动挂起
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoSuspend")]
        public bool? AutoSuspend{ get; set; }

        /// <summary>
        /// 定时启停集群策略：0（默认）：关闭定时策略、1：开启定时策略（注：定时启停策略与自动挂起策略互斥）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CrontabResumeSuspend")]
        public long? CrontabResumeSuspend{ get; set; }

        /// <summary>
        /// 定时启停策略，复杂类型：包含启停时间、挂起集群策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CrontabResumeSuspendStrategy")]
        public CrontabResumeSuspendStrategy CrontabResumeSuspendStrategy{ get; set; }

        /// <summary>
        /// 引擎执行任务类型，有效值：SQL/BATCH
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineExecType")]
        public string EngineExecType{ get; set; }

        /// <summary>
        /// 自动续费标志，0，初始状态，默认不自动续费，若用户有预付费不停服特权，自动续费。1：自动续费。2：明确不自动续费
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// 集群自动挂起时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoSuspendTime")]
        public long? AutoSuspendTime{ get; set; }

        /// <summary>
        /// 网络连接配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NetworkConnectionSet")]
        public NetworkConnection[] NetworkConnectionSet{ get; set; }

        /// <summary>
        /// ui的跳转地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UiURL")]
        public string UiURL{ get; set; }

        /// <summary>
        /// 引擎的资源类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// 集群镜像版本ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageVersionId")]
        public string ImageVersionId{ get; set; }

        /// <summary>
        /// 集群镜像小版本ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChildImageVersionId")]
        public string ChildImageVersionId{ get; set; }

        /// <summary>
        /// 集群镜像版本名字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageVersionName")]
        public string ImageVersionName{ get; set; }

        /// <summary>
        /// 是否开启备集群
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartStandbyCluster")]
        public bool? StartStandbyCluster{ get; set; }

        /// <summary>
        /// spark jar 包年包月集群是否开启弹性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ElasticSwitch")]
        public bool? ElasticSwitch{ get; set; }

        /// <summary>
        /// spark jar 包年包月集群弹性上限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ElasticLimit")]
        public long? ElasticLimit{ get; set; }

        /// <summary>
        /// 是否为默认引擎
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultHouse")]
        public bool? DefaultHouse{ get; set; }

        /// <summary>
        /// 单个集群任务最大并发数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxConcurrency")]
        public long? MaxConcurrency{ get; set; }

        /// <summary>
        /// 任务排队上限时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TolerableQueueTime")]
        public long? TolerableQueueTime{ get; set; }

        /// <summary>
        /// 用户appid
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserAppId")]
        public long? UserAppId{ get; set; }

        /// <summary>
        /// 用户uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserUin")]
        public string UserUin{ get; set; }

        /// <summary>
        /// SessionResourceTemplate
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SessionResourceTemplate")]
        public SessionResourceTemplate SessionResourceTemplate{ get; set; }

        /// <summary>
        /// 自动授权开关
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AutoAuthorization")]
        public bool? AutoAuthorization{ get; set; }

        /// <summary>
        /// 引擎版本，支持Native/SuperSQL
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineGeneration")]
        public string EngineGeneration{ get; set; }

        /// <summary>
        /// 引擎详细类型，支持：SparkSQL/SparkBatch/PrestoSQL/Kyuubi
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineTypeDetail")]
        public string EngineTypeDetail{ get; set; }

        /// <summary>
        /// 引擎网络ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineNetworkId")]
        public string EngineNetworkId{ get; set; }

        /// <summary>
        /// 标准引擎关联的资源组个数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineResourceGroupCount")]
        public long? EngineResourceGroupCount{ get; set; }

        /// <summary>
        /// 引擎当前使用量（Cu）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineResourceUsedCU")]
        public long? EngineResourceUsedCU{ get; set; }

        /// <summary>
        /// 引擎的访问信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccessInfos")]
        public AccessInfo[] AccessInfos{ get; set; }

        /// <summary>
        /// 引擎所在网络名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EngineNetworkName")]
        public string EngineNetworkName{ get; set; }

        /// <summary>
        /// 是否使用预留池
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsPoolMode")]
        public string IsPoolMode{ get; set; }

        /// <summary>
        /// 是否支持AI，false: 不支持；true：支持
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsSupportAI")]
        public bool? IsSupportAI{ get; set; }

        /// <summary>
        /// 网关id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// 网关状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GatewayState")]
        public long? GatewayState{ get; set; }

        /// <summary>
        /// 是否能执行AI任务
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsAIGateway")]
        public bool? IsAIGateway{ get; set; }

        /// <summary>
        /// 1:AI引擎，0:非AI引擎
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsAIEngine")]
        public long? IsAIEngine{ get; set; }

        /// <summary>
        /// 引擎资源弹性伸缩策略
        /// </summary>
        [JsonProperty("ScheduleElasticityConf")]
        public ScheduleElasticityConf ScheduleElasticityConf{ get; set; }

        /// <summary>
        /// GPU 信息
        /// </summary>
        [JsonProperty("GPUInfo")]
        public GPUInfo GPUInfo{ get; set; }

        /// <summary>
        /// GPU 使用量
        /// </summary>
        [JsonProperty("EngineResourceUsedGPU")]
        public long? EngineResourceUsedGPU{ get; set; }

        /// <summary>
        /// GPU 总规格
        /// </summary>
        [JsonProperty("GPUTotalSize")]
        public long? GPUTotalSize{ get; set; }

        /// <summary>
        /// GPU 机型
        /// </summary>
        [JsonProperty("InstanceModel")]
        public string InstanceModel{ get; set; }

        /// <summary>
        /// 节点数量
        /// </summary>
        [JsonProperty("NodeNum")]
        public long? NodeNum{ get; set; }

        /// <summary>
        /// 引擎规格，包含负载弹性或分时弹性
        /// </summary>
        [JsonProperty("SizeWithElastic")]
        public ulong? SizeWithElastic{ get; set; }

        /// <summary>
        /// 最大弹性值，包含负载弹性或分时弹性
        /// </summary>
        [JsonProperty("MaxElasticSize")]
        public ulong? MaxElasticSize{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataEngineName", this.DataEngineName);
            this.SetParamSimple(map, prefix + "EngineType", this.EngineType);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "QuotaId", this.QuotaId);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "MinClusters", this.MinClusters);
            this.SetParamSimple(map, prefix + "MaxClusters", this.MaxClusters);
            this.SetParamSimple(map, prefix + "AutoResume", this.AutoResume);
            this.SetParamSimple(map, prefix + "SpendAfter", this.SpendAfter);
            this.SetParamSimple(map, prefix + "CidrBlock", this.CidrBlock);
            this.SetParamSimple(map, prefix + "DefaultDataEngine", this.DefaultDataEngine);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "DataEngineId", this.DataEngineId);
            this.SetParamSimple(map, prefix + "SubAccountUin", this.SubAccountUin);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "IsolatedTime", this.IsolatedTime);
            this.SetParamSimple(map, prefix + "ReversalTime", this.ReversalTime);
            this.SetParamSimple(map, prefix + "UserAlias", this.UserAlias);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamArraySimple(map, prefix + "Permissions.", this.Permissions);
            this.SetParamSimple(map, prefix + "AutoSuspend", this.AutoSuspend);
            this.SetParamSimple(map, prefix + "CrontabResumeSuspend", this.CrontabResumeSuspend);
            this.SetParamObj(map, prefix + "CrontabResumeSuspendStrategy.", this.CrontabResumeSuspendStrategy);
            this.SetParamSimple(map, prefix + "EngineExecType", this.EngineExecType);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "AutoSuspendTime", this.AutoSuspendTime);
            this.SetParamArrayObj(map, prefix + "NetworkConnectionSet.", this.NetworkConnectionSet);
            this.SetParamSimple(map, prefix + "UiURL", this.UiURL);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "ImageVersionId", this.ImageVersionId);
            this.SetParamSimple(map, prefix + "ChildImageVersionId", this.ChildImageVersionId);
            this.SetParamSimple(map, prefix + "ImageVersionName", this.ImageVersionName);
            this.SetParamSimple(map, prefix + "StartStandbyCluster", this.StartStandbyCluster);
            this.SetParamSimple(map, prefix + "ElasticSwitch", this.ElasticSwitch);
            this.SetParamSimple(map, prefix + "ElasticLimit", this.ElasticLimit);
            this.SetParamSimple(map, prefix + "DefaultHouse", this.DefaultHouse);
            this.SetParamSimple(map, prefix + "MaxConcurrency", this.MaxConcurrency);
            this.SetParamSimple(map, prefix + "TolerableQueueTime", this.TolerableQueueTime);
            this.SetParamSimple(map, prefix + "UserAppId", this.UserAppId);
            this.SetParamSimple(map, prefix + "UserUin", this.UserUin);
            this.SetParamObj(map, prefix + "SessionResourceTemplate.", this.SessionResourceTemplate);
            this.SetParamSimple(map, prefix + "AutoAuthorization", this.AutoAuthorization);
            this.SetParamSimple(map, prefix + "EngineGeneration", this.EngineGeneration);
            this.SetParamSimple(map, prefix + "EngineTypeDetail", this.EngineTypeDetail);
            this.SetParamSimple(map, prefix + "EngineNetworkId", this.EngineNetworkId);
            this.SetParamSimple(map, prefix + "EngineResourceGroupCount", this.EngineResourceGroupCount);
            this.SetParamSimple(map, prefix + "EngineResourceUsedCU", this.EngineResourceUsedCU);
            this.SetParamArrayObj(map, prefix + "AccessInfos.", this.AccessInfos);
            this.SetParamSimple(map, prefix + "EngineNetworkName", this.EngineNetworkName);
            this.SetParamSimple(map, prefix + "IsPoolMode", this.IsPoolMode);
            this.SetParamSimple(map, prefix + "IsSupportAI", this.IsSupportAI);
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "GatewayState", this.GatewayState);
            this.SetParamSimple(map, prefix + "IsAIGateway", this.IsAIGateway);
            this.SetParamSimple(map, prefix + "IsAIEngine", this.IsAIEngine);
            this.SetParamObj(map, prefix + "ScheduleElasticityConf.", this.ScheduleElasticityConf);
            this.SetParamObj(map, prefix + "GPUInfo.", this.GPUInfo);
            this.SetParamSimple(map, prefix + "EngineResourceUsedGPU", this.EngineResourceUsedGPU);
            this.SetParamSimple(map, prefix + "GPUTotalSize", this.GPUTotalSize);
            this.SetParamSimple(map, prefix + "InstanceModel", this.InstanceModel);
            this.SetParamSimple(map, prefix + "NodeNum", this.NodeNum);
            this.SetParamSimple(map, prefix + "SizeWithElastic", this.SizeWithElastic);
            this.SetParamSimple(map, prefix + "MaxElasticSize", this.MaxElasticSize);
        }
    }
}

