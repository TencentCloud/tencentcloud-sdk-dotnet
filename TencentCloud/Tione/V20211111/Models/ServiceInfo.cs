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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ServiceInfo : AbstractModel
    {
        
        /// <summary>
        /// 期望运行的Pod数量，停止状态是0
        /// 不同计费模式和调节模式下对应关系如下
        /// PREPAID 和 POSTPAID_BY_HOUR:
        /// 手动调节模式下对应 实例数量
        /// 自动调节模式下对应 基于时间的默认策略的实例数量
        /// HYBRID_PAID:
        /// 后付费实例手动调节模式下对应 实例数量
        /// 后付费实例自动调节模式下对应 时间策略的默认策略的实例数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Replicas")]
        public long? Replicas{ get; set; }

        /// <summary>
        /// 镜像信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageInfo")]
        public ImageInfo ImageInfo{ get; set; }

        /// <summary>
        /// 环境变量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Env")]
        public EnvVar[] Env{ get; set; }

        /// <summary>
        /// 资源信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Resources")]
        public ResourceInfo Resources{ get; set; }

        /// <summary>
        /// 后付费实例对应的机型规格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 模型信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelInfo")]
        public ModelInfo ModelInfo{ get; set; }

        /// <summary>
        /// 是否启用日志
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogEnable")]
        public bool? LogEnable{ get; set; }

        /// <summary>
        /// 日志配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogConfig")]
        public LogConfig LogConfig{ get; set; }

        /// <summary>
        /// 是否开启鉴权
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthorizationEnable")]
        public bool? AuthorizationEnable{ get; set; }

        /// <summary>
        /// hpa配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HorizontalPodAutoscaler")]
        public HorizontalPodAutoscaler HorizontalPodAutoscaler{ get; set; }

        /// <summary>
        /// 服务的状态描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public WorkloadStatus Status{ get; set; }

        /// <summary>
        /// 权重
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Weight")]
        public ulong? Weight{ get; set; }

        /// <summary>
        /// 实例列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PodList")]
        public string[] PodList{ get; set; }

        /// <summary>
        /// 资源总量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceTotal")]
        public ResourceInfo ResourceTotal{ get; set; }

        /// <summary>
        /// 历史实例数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OldReplicas")]
        public long? OldReplicas{ get; set; }

        /// <summary>
        /// 计费模式[HYBRID_PAID]时生效, 用于标识混合计费模式下的预付费实例数, 若不填则默认为1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HybridBillingPrepaidReplicas")]
        public long? HybridBillingPrepaidReplicas{ get; set; }

        /// <summary>
        /// 历史 HYBRID_PAID 时的实例数，用户恢复服务
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OldHybridBillingPrepaidReplicas")]
        public long? OldHybridBillingPrepaidReplicas{ get; set; }

        /// <summary>
        /// 是否开启模型的热更新。默认不开启
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelHotUpdateEnable")]
        public bool? ModelHotUpdateEnable{ get; set; }

        /// <summary>
        /// Pod列表信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Pods")]
        public Pod Pods{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Replicas", this.Replicas);
            this.SetParamObj(map, prefix + "ImageInfo.", this.ImageInfo);
            this.SetParamArrayObj(map, prefix + "Env.", this.Env);
            this.SetParamObj(map, prefix + "Resources.", this.Resources);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamObj(map, prefix + "ModelInfo.", this.ModelInfo);
            this.SetParamSimple(map, prefix + "LogEnable", this.LogEnable);
            this.SetParamObj(map, prefix + "LogConfig.", this.LogConfig);
            this.SetParamSimple(map, prefix + "AuthorizationEnable", this.AuthorizationEnable);
            this.SetParamObj(map, prefix + "HorizontalPodAutoscaler.", this.HorizontalPodAutoscaler);
            this.SetParamObj(map, prefix + "Status.", this.Status);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamArraySimple(map, prefix + "PodList.", this.PodList);
            this.SetParamObj(map, prefix + "ResourceTotal.", this.ResourceTotal);
            this.SetParamSimple(map, prefix + "OldReplicas", this.OldReplicas);
            this.SetParamSimple(map, prefix + "HybridBillingPrepaidReplicas", this.HybridBillingPrepaidReplicas);
            this.SetParamSimple(map, prefix + "OldHybridBillingPrepaidReplicas", this.OldHybridBillingPrepaidReplicas);
            this.SetParamSimple(map, prefix + "ModelHotUpdateEnable", this.ModelHotUpdateEnable);
            this.SetParamObj(map, prefix + "Pods.", this.Pods);
        }
    }
}

