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

namespace TencentCloud.Tione.V20191022.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeNotebookInstanceResponse : AbstractModel
    {
        
        /// <summary>
        /// Notebook实例名称
        /// </summary>
        [JsonProperty("NotebookInstanceName")]
        public string NotebookInstanceName{ get; set; }

        /// <summary>
        /// Notebook算力资源类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 角色的资源描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RoleArn")]
        public string RoleArn{ get; set; }

        /// <summary>
        /// 外网访问权限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DirectInternetAccess")]
        public string DirectInternetAccess{ get; set; }

        /// <summary>
        /// Root用户权限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RootAccess")]
        public string RootAccess{ get; set; }

        /// <summary>
        /// 子网ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 数据卷大小(GB)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VolumeSizeInGB")]
        public ulong? VolumeSizeInGB{ get; set; }

        /// <summary>
        /// 创建失败原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailureReason")]
        public string FailureReason{ get; set; }

        /// <summary>
        /// Notebook实例创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }

        /// <summary>
        /// Notebook实例最近修改时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastModifiedTime")]
        public string LastModifiedTime{ get; set; }

        /// <summary>
        /// Notebook实例日志链接
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogUrl")]
        public string LogUrl{ get; set; }

        /// <summary>
        /// Notebook实例状态
        /// 
        /// Pending: 创建中
        /// Inservice: 运行中
        /// Stopping: 停止中
        /// Stopped: 已停止
        /// Failed: 失败
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NotebookInstanceStatus")]
        public string NotebookInstanceStatus{ get; set; }

        /// <summary>
        /// Notebook实例ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// notebook生命周期脚本名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LifecycleScriptsName")]
        public string LifecycleScriptsName{ get; set; }

        /// <summary>
        /// 默认存储库名称
        /// 可以是已创建的存储库名称或者已https://开头的公共git库
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultCodeRepository")]
        public string DefaultCodeRepository{ get; set; }

        /// <summary>
        /// 其他存储库列表
        /// 每个元素可以是已创建的存储库名称或者已https://开头的公共git库
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AdditionalCodeRepositories")]
        public string[] AdditionalCodeRepositories{ get; set; }

        /// <summary>
        /// 是否开启CLS日志服务
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClsAccess")]
        public string ClsAccess{ get; set; }

        /// <summary>
        /// 是否预付费实例
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Prepay")]
        public bool? Prepay{ get; set; }

        /// <summary>
        /// 实例运行截止时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Deadline")]
        public string Deadline{ get; set; }

        /// <summary>
        /// 自动停止配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StoppingCondition")]
        public StoppingCondition StoppingCondition{ get; set; }

        /// <summary>
        /// Cls配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClsConfig")]
        public ClsConfig ClsConfig{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NotebookInstanceName", this.NotebookInstanceName);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "RoleArn", this.RoleArn);
            this.SetParamSimple(map, prefix + "DirectInternetAccess", this.DirectInternetAccess);
            this.SetParamSimple(map, prefix + "RootAccess", this.RootAccess);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "VolumeSizeInGB", this.VolumeSizeInGB);
            this.SetParamSimple(map, prefix + "FailureReason", this.FailureReason);
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
            this.SetParamSimple(map, prefix + "LastModifiedTime", this.LastModifiedTime);
            this.SetParamSimple(map, prefix + "LogUrl", this.LogUrl);
            this.SetParamSimple(map, prefix + "NotebookInstanceStatus", this.NotebookInstanceStatus);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "LifecycleScriptsName", this.LifecycleScriptsName);
            this.SetParamSimple(map, prefix + "DefaultCodeRepository", this.DefaultCodeRepository);
            this.SetParamArraySimple(map, prefix + "AdditionalCodeRepositories.", this.AdditionalCodeRepositories);
            this.SetParamSimple(map, prefix + "ClsAccess", this.ClsAccess);
            this.SetParamSimple(map, prefix + "Prepay", this.Prepay);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamObj(map, prefix + "StoppingCondition.", this.StoppingCondition);
            this.SetParamObj(map, prefix + "ClsConfig.", this.ClsConfig);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

