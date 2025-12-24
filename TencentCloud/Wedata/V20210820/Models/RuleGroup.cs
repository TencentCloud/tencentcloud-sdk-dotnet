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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleGroup : AbstractModel
    {
        
        /// <summary>
        /// 规则组Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleGroupId")]
        public ulong? RuleGroupId{ get; set; }

        /// <summary>
        /// 数据源Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasourceId")]
        public string DatasourceId{ get; set; }

        /// <summary>
        /// 数据源名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasourceName")]
        public string DatasourceName{ get; set; }

        /// <summary>
        /// 数据源类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatasourceType")]
        public ulong? DatasourceType{ get; set; }

        /// <summary>
        /// 监控类型 1.未配置, 2.关联生产调度, 3.离线周期检测
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MonitorType")]
        public ulong? MonitorType{ get; set; }

        /// <summary>
        /// 更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 关联数据表名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 关联数据表Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableId")]
        public string TableId{ get; set; }

        /// <summary>
        /// 关联数据表负责人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableOwnerName")]
        public string TableOwnerName{ get; set; }

        /// <summary>
        /// 执行策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecStrategy")]
        public RuleGroupExecStrategy ExecStrategy{ get; set; }

        /// <summary>
        /// 执行策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Subscription")]
        public RuleGroupSubscribe Subscription{ get; set; }

        /// <summary>
        /// 数据库id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatabaseId")]
        public string DatabaseId{ get; set; }

        /// <summary>
        /// 数据库名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// 模式名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SchemaName")]
        public string SchemaName{ get; set; }

        /// <summary>
        /// 是否有权限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Permission")]
        public bool? Permission{ get; set; }

        /// <summary>
        /// 已经配置的规则数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleCount")]
        public ulong? RuleCount{ get; set; }

        /// <summary>
        /// 监控状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MonitorStatus")]
        public bool? MonitorStatus{ get; set; }

        /// <summary>
        /// 表负责人UserId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableOwnerUserId")]
        public ulong? TableOwnerUserId{ get; set; }

        /// <summary>
        /// 实例ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 是否已配置执行策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StrategyConfig")]
        public bool? StrategyConfig{ get; set; }

        /// <summary>
        /// 是否已配置执行策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubscribeConfig")]
        public bool? SubscribeConfig{ get; set; }

        /// <summary>
        /// 数据源环境：0或者未返回.未定义，1.生产 2.开发
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DsEnvType")]
        public long? DsEnvType{ get; set; }

        /// <summary>
        /// EMR集群部署方式：CVM/TKE
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterDeployType")]
        public string ClusterDeployType{ get; set; }

        /// <summary>
        /// 任务名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 执行详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExecDetail")]
        public string ExecDetail{ get; set; }

        /// <summary>
        /// 事中关联任务数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PipelineTaskCount")]
        public long? PipelineTaskCount{ get; set; }

        /// <summary>
        /// 有效规则数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableRuleCount")]
        public long? EnableRuleCount{ get; set; }

        /// <summary>
        /// 任务描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 监控创建人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateUserName")]
        public string CreateUserName{ get; set; }

        /// <summary>
        /// 任务类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupType")]
        public string GroupType{ get; set; }

        /// <summary>
        /// 任务id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AspectTaskId")]
        public string AspectTaskId{ get; set; }

        /// <summary>
        /// catalog名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CatalogName")]
        public string CatalogName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RuleGroupId", this.RuleGroupId);
            this.SetParamSimple(map, prefix + "DatasourceId", this.DatasourceId);
            this.SetParamSimple(map, prefix + "DatasourceName", this.DatasourceName);
            this.SetParamSimple(map, prefix + "DatasourceType", this.DatasourceType);
            this.SetParamSimple(map, prefix + "MonitorType", this.MonitorType);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "TableId", this.TableId);
            this.SetParamSimple(map, prefix + "TableOwnerName", this.TableOwnerName);
            this.SetParamObj(map, prefix + "ExecStrategy.", this.ExecStrategy);
            this.SetParamObj(map, prefix + "Subscription.", this.Subscription);
            this.SetParamSimple(map, prefix + "DatabaseId", this.DatabaseId);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "SchemaName", this.SchemaName);
            this.SetParamSimple(map, prefix + "Permission", this.Permission);
            this.SetParamSimple(map, prefix + "RuleCount", this.RuleCount);
            this.SetParamSimple(map, prefix + "MonitorStatus", this.MonitorStatus);
            this.SetParamSimple(map, prefix + "TableOwnerUserId", this.TableOwnerUserId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "StrategyConfig", this.StrategyConfig);
            this.SetParamSimple(map, prefix + "SubscribeConfig", this.SubscribeConfig);
            this.SetParamSimple(map, prefix + "DsEnvType", this.DsEnvType);
            this.SetParamSimple(map, prefix + "ClusterDeployType", this.ClusterDeployType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ExecDetail", this.ExecDetail);
            this.SetParamSimple(map, prefix + "PipelineTaskCount", this.PipelineTaskCount);
            this.SetParamSimple(map, prefix + "EnableRuleCount", this.EnableRuleCount);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "CreateUserName", this.CreateUserName);
            this.SetParamSimple(map, prefix + "GroupType", this.GroupType);
            this.SetParamSimple(map, prefix + "AspectTaskId", this.AspectTaskId);
            this.SetParamSimple(map, prefix + "CatalogName", this.CatalogName);
        }
    }
}

