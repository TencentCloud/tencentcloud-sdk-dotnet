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

    public class MlFlowServerInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>MLflow 实例的 ID</p>
        /// </summary>
        [JsonProperty("ServerId")]
        public string ServerId{ get; set; }

        /// <summary>
        /// <p>实例名称</p>
        /// </summary>
        [JsonProperty("ServerName")]
        public string ServerName{ get; set; }

        /// <summary>
        /// <p>资源分区 ID</p>
        /// </summary>
        [JsonProperty("ResourcePartitionId")]
        public string ResourcePartitionId{ get; set; }

        /// <summary>
        /// <p>资源包名</p>
        /// </summary>
        [JsonProperty("ResourcePartitionName")]
        public string ResourcePartitionName{ get; set; }

        /// <summary>
        /// <p>资源组（逻辑队列名，可选）</p>
        /// </summary>
        [JsonProperty("Queue")]
        public string Queue{ get; set; }

        /// <summary>
        /// <p>集群内MLflow访问地址。用于训练作业上报 metrics</p>
        /// </summary>
        [JsonProperty("TrackingUri")]
        public string TrackingUri{ get; set; }

        /// <summary>
        /// <p>集群外访问地址（Ingress URL）</p>
        /// </summary>
        [JsonProperty("UiUrl")]
        public string UiUrl{ get; set; }

        /// <summary>
        /// <p>状态：CREATED / CREATING / RUNNING / FAILED / STOPPED</p><p>枚举值：</p><ul><li>CREATED： 已创建</li><li>CREATING： 创建中</li><li>RUNNING： 运行中</li><li>FAILED： 失败</li><li>STOPPED： 已停止</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>仅失败时展示错误信息</p>
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }

        /// <summary>
        /// <p>MLflow 镜像地址</p>
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// <p>存储配置 JSON，具体结构按 storageMode 解释（cos / cfs / local）</p>
        /// </summary>
        [JsonProperty("StorageConfig")]
        public string StorageConfig{ get; set; }

        /// <summary>
        /// <p>存储模式</p><p>枚举值：</p><ul><li>cos： cos 对象存储</li><li>cfs： cfs 文件系统存储</li></ul>
        /// </summary>
        [JsonProperty("StorageMode")]
        public string StorageMode{ get; set; }

        /// <summary>
        /// <p>启动参数（用户自定义；null = 默认命令，编辑弹窗预填用）</p>
        /// </summary>
        [JsonProperty("ServerArgs")]
        public string ServerArgs{ get; set; }

        /// <summary>
        /// <p>描述信息（纯文本；null = 未填写）</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>应用 ID</p>
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// <p>创建者 UIN</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>创建人子账号 UIN（实际提交者，存量数据可能为空）</p>
        /// </summary>
        [JsonProperty("SubAccountUin")]
        public string SubAccountUin{ get; set; }

        /// <summary>
        /// <p>创建人子账号名称（CAM 动态回填，非持久化；查询失败时为空）</p>
        /// </summary>
        [JsonProperty("SubAccountName")]
        public string SubAccountName{ get; set; }

        /// <summary>
        /// <p>创建时间（epoch 毫秒）</p><p>单位：毫秒</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间（epoch 毫秒）</p><p>单位：毫秒</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// <p>资源配置 JSON</p>
        /// </summary>
        [JsonProperty("ResourceConfig")]
        public string ResourceConfig{ get; set; }

        /// <summary>
        /// <p>标签列表（TagKey-TagValue）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>最近一次成功探测 Deployment 的时间（epoch millis，Neutrino 透传）；NULL=尚未成功探测过。</p>
        /// </summary>
        [JsonProperty("LastProbeSuccessTime")]
        public long? LastProbeSuccessTime{ get; set; }

        /// <summary>
        /// <p>最近一次成功探测后的连续失败次数（&gt;0 表示当前 Status 可能过期）</p>
        /// </summary>
        [JsonProperty("ConsecutiveProbeFailures")]
        public long? ConsecutiveProbeFailures{ get; set; }

        /// <summary>
        /// <p>最近一次探测失败原因（Neutrino 透传，仅诊断展示）</p>
        /// </summary>
        [JsonProperty("LastProbeError")]
        public string LastProbeError{ get; set; }

        /// <summary>
        /// <p>关联训练实例总数（ray-nexus 侧统计，仅 ListMlflowServers 返回；详情/监控请用 QueryMlFlowServerInstanceStats）</p>
        /// </summary>
        [JsonProperty("TotalInstanceCount")]
        public long? TotalInstanceCount{ get; set; }

        /// <summary>
        /// <p>关联的运行中（RUNNING）训练实例数（仅 ListMlflowServers 返回；详情/监控请用 QueryMlflowServerInstanceStats）</p>
        /// </summary>
        [JsonProperty("RunningInstanceCount")]
        public long? RunningInstanceCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServerId", this.ServerId);
            this.SetParamSimple(map, prefix + "ServerName", this.ServerName);
            this.SetParamSimple(map, prefix + "ResourcePartitionId", this.ResourcePartitionId);
            this.SetParamSimple(map, prefix + "ResourcePartitionName", this.ResourcePartitionName);
            this.SetParamSimple(map, prefix + "Queue", this.Queue);
            this.SetParamSimple(map, prefix + "TrackingUri", this.TrackingUri);
            this.SetParamSimple(map, prefix + "UiUrl", this.UiUrl);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "StorageConfig", this.StorageConfig);
            this.SetParamSimple(map, prefix + "StorageMode", this.StorageMode);
            this.SetParamSimple(map, prefix + "ServerArgs", this.ServerArgs);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "SubAccountUin", this.SubAccountUin);
            this.SetParamSimple(map, prefix + "SubAccountName", this.SubAccountName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ResourceConfig", this.ResourceConfig);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "LastProbeSuccessTime", this.LastProbeSuccessTime);
            this.SetParamSimple(map, prefix + "ConsecutiveProbeFailures", this.ConsecutiveProbeFailures);
            this.SetParamSimple(map, prefix + "LastProbeError", this.LastProbeError);
            this.SetParamSimple(map, prefix + "TotalInstanceCount", this.TotalInstanceCount);
            this.SetParamSimple(map, prefix + "RunningInstanceCount", this.RunningInstanceCount);
        }
    }
}

