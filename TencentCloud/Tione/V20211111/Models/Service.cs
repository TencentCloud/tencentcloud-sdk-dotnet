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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Service : AbstractModel
    {
        
        /// <summary>
        /// <p>服务组id</p>
        /// </summary>
        [JsonProperty("ServiceGroupId")]
        public string ServiceGroupId{ get; set; }

        /// <summary>
        /// <p>服务id</p>
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// <p>服务组名</p>
        /// </summary>
        [JsonProperty("ServiceGroupName")]
        public string ServiceGroupName{ get; set; }

        /// <summary>
        /// <p>服务描述</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceDescription")]
        public string ServiceDescription{ get; set; }

        /// <summary>
        /// <p>服务的详细信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceInfo")]
        public ServiceInfo ServiceInfo{ get; set; }

        /// <summary>
        /// <p>集群id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>地域</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>命名空间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// <p>付费类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// <p>包年包月服务的资源组id，按量计费的服务为空</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }

        /// <summary>
        /// <p>包年包月服务对应的资源组名字</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceGroupName")]
        public string ResourceGroupName{ get; set; }

        /// <summary>
        /// <p>服务的标签</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>服务所在的 ingress 的 name</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IngressName")]
        public string IngressName{ get; set; }

        /// <summary>
        /// <p>创建者</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedBy")]
        public string CreatedBy{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>主账号</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>子账号</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubUin")]
        public string SubUin{ get; set; }

        /// <summary>
        /// <p>app_id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// <p>服务的业务状态<br>CREATING 创建中<br>CREATE_FAILED 创建失败<br>CREATE_SUCCEED 创建成功<br>ARREARS_STOP 因欠费停止<br>WHITELIST_STOP 白名单额度不足<br>RELEASE_FAILED 资源释放失败<br>WHITELIST_RELEASE_FAILED 白名单资源释放失败<br>TIMEOUT_EXCEPTION 创建超时异常<br>BILLING 计费中<br>WHITELIST_USING 白名单试用中</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BusinessStatus")]
        public string BusinessStatus{ get; set; }

        /// <summary>
        /// <p>已废弃,以ServiceInfo中的对应为准</p>
        /// </summary>
        [JsonProperty("ServiceLimit")]
        [System.Obsolete]
        public ServiceLimit ServiceLimit{ get; set; }

        /// <summary>
        /// <p>已废弃,以ServiceInfo中的对应为准</p>
        /// </summary>
        [JsonProperty("ScheduledAction")]
        [System.Obsolete]
        public ScheduledAction ScheduledAction{ get; set; }

        /// <summary>
        /// <p>服务创建失败的原因，创建成功后该字段为默认值 CREATE_SUCCEED</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateFailedReason")]
        public string CreateFailedReason{ get; set; }

        /// <summary>
        /// <p>服务状态<br>CREATING 创建中<br>CREATE_FAILED 创建失败<br>TIMEOUT_EXCEPTION 创建超时异常<br>Normal 正常运行中<br>Stopped 已停止<br>Stopping 停止中<br>Abnormal 异常<br>Pending 启动中<br>Waiting 就绪中</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>费用信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BillingInfo")]
        public string BillingInfo{ get; set; }

        /// <summary>
        /// <p>模型权重</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// <p>服务的创建来源<br>AUTO_ML: 来自自动学习的一键发布<br>DEFAULT: 其他来源</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateSource")]
        public string CreateSource{ get; set; }

        /// <summary>
        /// <p>版本号</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// <p>服务组下服务的最高版本号</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LatestVersion")]
        public string LatestVersion{ get; set; }

        /// <summary>
        /// <p>资源组类别 托管 NORMAL，纳管 SW</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceGroupSWType")]
        public string ResourceGroupSWType{ get; set; }

        /// <summary>
        /// <p>服务的归档状态  Waiting 等待归档中，Archived 已归档</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ArchiveStatus")]
        public string ArchiveStatus{ get; set; }

        /// <summary>
        /// <p>服务的部署类型 [STANDARD 标准部署，DIST 分布式多机部署] 默认STANDARD</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeployType")]
        public string DeployType{ get; set; }

        /// <summary>
        /// <p>单副本下的实例数，仅在部署类型为DIST时生效，默认1</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstancePerReplicas")]
        public string InstancePerReplicas{ get; set; }

        /// <summary>
        /// <p>用于监控查询的Source<br>枚举值，部分情况下与CreateSource不同，通过该字段兼容</p>
        /// </summary>
        [JsonProperty("MonitorSource")]
        public string MonitorSource{ get; set; }

        /// <summary>
        /// <p>服务创建者的子账号名称</p>
        /// </summary>
        [JsonProperty("SubUinName")]
        public string SubUinName{ get; set; }

        /// <summary>
        /// <p>服务的调度策略</p>
        /// </summary>
        [JsonProperty("SchedulingPolicy")]
        public SchedulingPolicy SchedulingPolicy{ get; set; }

        /// <summary>
        /// <p>外部的资源组信息，表示借调了哪些资源组的资源</p>
        /// </summary>
        [JsonProperty("ExternalResourceGroups")]
        public ResourceGroupInfo[] ExternalResourceGroups{ get; set; }

        /// <summary>
        /// <p>变更服务的子账户</p>
        /// </summary>
        [JsonProperty("Changer")]
        public string Changer{ get; set; }

        /// <summary>
        /// <p>变更服务的子账户名称</p>
        /// </summary>
        [JsonProperty("ChangerName")]
        public string ChangerName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceGroupId", this.ServiceGroupId);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "ServiceGroupName", this.ServiceGroupName);
            this.SetParamSimple(map, prefix + "ServiceDescription", this.ServiceDescription);
            this.SetParamObj(map, prefix + "ServiceInfo.", this.ServiceInfo);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "ResourceGroupId", this.ResourceGroupId);
            this.SetParamSimple(map, prefix + "ResourceGroupName", this.ResourceGroupName);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "IngressName", this.IngressName);
            this.SetParamSimple(map, prefix + "CreatedBy", this.CreatedBy);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "SubUin", this.SubUin);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "BusinessStatus", this.BusinessStatus);
            this.SetParamObj(map, prefix + "ServiceLimit.", this.ServiceLimit);
            this.SetParamObj(map, prefix + "ScheduledAction.", this.ScheduledAction);
            this.SetParamSimple(map, prefix + "CreateFailedReason", this.CreateFailedReason);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "BillingInfo", this.BillingInfo);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "CreateSource", this.CreateSource);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "LatestVersion", this.LatestVersion);
            this.SetParamSimple(map, prefix + "ResourceGroupSWType", this.ResourceGroupSWType);
            this.SetParamSimple(map, prefix + "ArchiveStatus", this.ArchiveStatus);
            this.SetParamSimple(map, prefix + "DeployType", this.DeployType);
            this.SetParamSimple(map, prefix + "InstancePerReplicas", this.InstancePerReplicas);
            this.SetParamSimple(map, prefix + "MonitorSource", this.MonitorSource);
            this.SetParamSimple(map, prefix + "SubUinName", this.SubUinName);
            this.SetParamObj(map, prefix + "SchedulingPolicy.", this.SchedulingPolicy);
            this.SetParamArrayObj(map, prefix + "ExternalResourceGroups.", this.ExternalResourceGroups);
            this.SetParamSimple(map, prefix + "Changer", this.Changer);
            this.SetParamSimple(map, prefix + "ChangerName", this.ChangerName);
        }
    }
}

