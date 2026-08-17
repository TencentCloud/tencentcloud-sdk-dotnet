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

    public class GetInferenceServiceResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>ServiceId</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// <p>服务名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>关联的模型UID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelUid")]
        public string ModelUid{ get; set; }

        /// <summary>
        /// <p>关联的模型名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>关联的模型版本号</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelVersion")]
        public string ModelVersion{ get; set; }

        /// <summary>
        /// <p>模型标识符（OpenAI 兼容 API 中的 model 字段）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelIdentifier")]
        public string ModelIdentifier{ get; set; }

        /// <summary>
        /// <p>关联模型的类型（LLM / VLM / Embedding / Reranker / TTS / ASR / CV / NLP / ML）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelType")]
        public string ModelType{ get; set; }

        /// <summary>
        /// <p>服务状态（Running/Stopped/Deploying/Failed）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>服务端点URL</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndpointUrl")]
        public string EndpointUrl{ get; set; }

        /// <summary>
        /// <p>OpenAI 兼容统一入口 URL（通过 API-Key 路由，适用于 LLM/Embedding/Reranker）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnifiedEndpointUrl")]
        public string UnifiedEndpointUrl{ get; set; }

        /// <summary>
        /// <p>KServe V2 协议统一入口 URL（通过 API-Key + model name 路由，适用于 XGBoost 等传统 ML 模型）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnifiedV2EndpointUrl")]
        public string UnifiedV2EndpointUrl{ get; set; }

        /// <summary>
        /// <p>应用ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// <p>主账号UIN</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>创建时间（Unix 时间戳，毫秒）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间（Unix 时间戳，毫秒）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }

        /// <summary>
        /// <p>部署数量</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeploymentCount")]
        public long? DeploymentCount{ get; set; }

        /// <summary>
        /// <p>是否存在至少一个运行中的部署</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HasRunningDeployment")]
        public bool? HasRunningDeployment{ get; set; }

        /// <summary>
        /// <p>Ray Dashboard 访问地址（通过 Ingress 代理）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RayDashboardUrl")]
        public string RayDashboardUrl{ get; set; }

        /// <summary>
        /// <p>是否启用 API-Key 鉴权</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiKeyAuthEnabled")]
        public bool? ApiKeyAuthEnabled{ get; set; }

        /// <summary>
        /// <p>是否强制开启 API-Key 鉴权（生产环境为 true，不允许关闭）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiKeyAuthForceEnabled")]
        public bool? ApiKeyAuthForceEnabled{ get; set; }

        /// <summary>
        /// <p>是否跳过 TLS 证书验证（自签证书场景，前端 curl 命令需加 -k 参数）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SkipTlsVerify")]
        public bool? SkipTlsVerify{ get; set; }

        /// <summary>
        /// <p>运行中部署的 GPU 资源汇总</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GpuResourceSummary")]
        public GpuSummaryItem[] GpuResourceSummary{ get; set; }

        /// <summary>
        /// <p>子账号UIN（实际操作者）</p>
        /// </summary>
        [JsonProperty("SubAccountUin")]
        public string SubAccountUin{ get; set; }

        /// <summary>
        /// <p>运行中部署的 CPU 资源汇总</p>
        /// </summary>
        [JsonProperty("CpuResourceSummary")]
        public CpuSummaryItem CpuResourceSummary{ get; set; }

        /// <summary>
        /// <p>资源配置（JSON 字符串，取自第一个部署）</p>
        /// </summary>
        [JsonProperty("ResourceConfig")]
        public string ResourceConfig{ get; set; }

        /// <summary>
        /// <p>部署模式</p>
        /// </summary>
        [JsonProperty("DeploymentMode")]
        public string DeploymentMode{ get; set; }

        /// <summary>
        /// <p>是否为自定义代码部署</p>
        /// </summary>
        [JsonProperty("IsCustom")]
        public bool? IsCustom{ get; set; }

        /// <summary>
        /// <p>系统标签列表（TagKey-TagValue）</p>
        /// </summary>
        [JsonProperty("ResourceTags")]
        public Tag[] ResourceTags{ get; set; }

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
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ModelUid", this.ModelUid);
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelVersion", this.ModelVersion);
            this.SetParamSimple(map, prefix + "ModelIdentifier", this.ModelIdentifier);
            this.SetParamSimple(map, prefix + "ModelType", this.ModelType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "EndpointUrl", this.EndpointUrl);
            this.SetParamSimple(map, prefix + "UnifiedEndpointUrl", this.UnifiedEndpointUrl);
            this.SetParamSimple(map, prefix + "UnifiedV2EndpointUrl", this.UnifiedV2EndpointUrl);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "DeploymentCount", this.DeploymentCount);
            this.SetParamSimple(map, prefix + "HasRunningDeployment", this.HasRunningDeployment);
            this.SetParamSimple(map, prefix + "RayDashboardUrl", this.RayDashboardUrl);
            this.SetParamSimple(map, prefix + "ApiKeyAuthEnabled", this.ApiKeyAuthEnabled);
            this.SetParamSimple(map, prefix + "ApiKeyAuthForceEnabled", this.ApiKeyAuthForceEnabled);
            this.SetParamSimple(map, prefix + "SkipTlsVerify", this.SkipTlsVerify);
            this.SetParamArrayObj(map, prefix + "GpuResourceSummary.", this.GpuResourceSummary);
            this.SetParamSimple(map, prefix + "SubAccountUin", this.SubAccountUin);
            this.SetParamObj(map, prefix + "CpuResourceSummary.", this.CpuResourceSummary);
            this.SetParamSimple(map, prefix + "ResourceConfig", this.ResourceConfig);
            this.SetParamSimple(map, prefix + "DeploymentMode", this.DeploymentMode);
            this.SetParamSimple(map, prefix + "IsCustom", this.IsCustom);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

