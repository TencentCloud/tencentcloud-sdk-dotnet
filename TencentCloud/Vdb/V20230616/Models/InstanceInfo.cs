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

namespace TencentCloud.Vdb.V20230616.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例自定义名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 用户APPID。
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 地域。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 可用区。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 产品。
        /// </summary>
        [JsonProperty("Product")]
        public string Product{ get; set; }

        /// <summary>
        /// 网络信息。
        /// </summary>
        [JsonProperty("Networks")]
        public Network[] Networks{ get; set; }

        /// <summary>
        /// 分片信息。
        /// </summary>
        [JsonProperty("ShardNum")]
        public ulong? ShardNum{ get; set; }

        /// <summary>
        /// 副本数。
        /// </summary>
        [JsonProperty("ReplicaNum")]
        public ulong? ReplicaNum{ get; set; }

        /// <summary>
        /// CPU.
        /// </summary>
        [JsonProperty("Cpu")]
        public float? Cpu{ get; set; }

        /// <summary>
        /// 内存。
        /// </summary>
        [JsonProperty("Memory")]
        public float? Memory{ get; set; }

        /// <summary>
        /// 磁盘。
        /// </summary>
        [JsonProperty("Disk")]
        public ulong? Disk{ get; set; }

        /// <summary>
        /// 健康得分。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HealthScore")]
        [System.Obsolete]
        public float? HealthScore{ get; set; }

        /// <summary>
        /// 异常告警。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Warning")]
        [System.Obsolete]
        public long? Warning{ get; set; }

        /// <summary>
        /// 所属项目。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Project")]
        [System.Obsolete]
        public string Project{ get; set; }

        /// <summary>
        /// 所属标签。
        /// </summary>
        [JsonProperty("ResourceTags")]
        public Tag[] ResourceTags{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// 资源状态。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 引擎名称。
        /// </summary>
        [JsonProperty("EngineName")]
        public string EngineName{ get; set; }

        /// <summary>
        /// 引擎版本。
        /// </summary>
        [JsonProperty("EngineVersion")]
        public string EngineVersion{ get; set; }

        /// <summary>
        /// api版本
        /// </summary>
        [JsonProperty("ApiVersion")]
        public string ApiVersion{ get; set; }

        /// <summary>
        /// 计费模式。
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// 差异化扩展信息, json格式。
        /// </summary>
        [JsonProperty("Extend")]
        public string Extend{ get; set; }

        /// <summary>
        /// 过期时间。
        /// </summary>
        [JsonProperty("ExpiredAt")]
        public string ExpiredAt{ get; set; }

        /// <summary>
        /// 是否不过期(永久)。
        /// </summary>
        [JsonProperty("IsNoExpired")]
        public bool? IsNoExpired{ get; set; }

        /// <summary>
        /// 产品版本，0-标准版，1-容量增强版
        /// </summary>
        [JsonProperty("ProductType")]
        public long? ProductType{ get; set; }

        /// <summary>
        /// 实例类型
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 节点类型
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// 外网地址。
        /// </summary>
        [JsonProperty("WanAddress")]
        public string WanAddress{ get; set; }

        /// <summary>
        /// 隔离时间
        /// </summary>
        [JsonProperty("IsolateAt")]
        public string IsolateAt{ get; set; }

        /// <summary>
        /// 是否自动续费。0: 不自动续费(可以支持特权不停服)；1:自动续费；2:到期不续费.
        /// </summary>
        [JsonProperty("AutoRenew")]
        public long? AutoRenew{ get; set; }

        /// <summary>
        /// 任务状态：0-无任务；1-待执行任务；2-密钥更新中；3-网络变更中；4-参数变更中；5-embedding变更中；6-ai套件变更中；7-滚动升级中；8-纵向扩容中；9-纵向缩容中；10-横向扩容中；11-横向缩容中
        /// </summary>
        [JsonProperty("TaskStatus")]
        public long? TaskStatus{ get; set; }

        /// <summary>
        /// 绑定的安全组id
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Product", this.Product);
            this.SetParamArrayObj(map, prefix + "Networks.", this.Networks);
            this.SetParamSimple(map, prefix + "ShardNum", this.ShardNum);
            this.SetParamSimple(map, prefix + "ReplicaNum", this.ReplicaNum);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Disk", this.Disk);
            this.SetParamSimple(map, prefix + "HealthScore", this.HealthScore);
            this.SetParamSimple(map, prefix + "Warning", this.Warning);
            this.SetParamSimple(map, prefix + "Project", this.Project);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "EngineName", this.EngineName);
            this.SetParamSimple(map, prefix + "EngineVersion", this.EngineVersion);
            this.SetParamSimple(map, prefix + "ApiVersion", this.ApiVersion);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "Extend", this.Extend);
            this.SetParamSimple(map, prefix + "ExpiredAt", this.ExpiredAt);
            this.SetParamSimple(map, prefix + "IsNoExpired", this.IsNoExpired);
            this.SetParamSimple(map, prefix + "ProductType", this.ProductType);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "WanAddress", this.WanAddress);
            this.SetParamSimple(map, prefix + "IsolateAt", this.IsolateAt);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
        }
    }
}

