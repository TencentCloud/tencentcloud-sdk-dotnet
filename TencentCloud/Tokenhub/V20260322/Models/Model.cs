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

namespace TencentCloud.Tokenhub.V20260322.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Model : AbstractModel
    {
        
        /// <summary>
        /// <p>模型名称</p>
        /// </summary>
        [JsonProperty("ModelName")]
        public string ModelName{ get; set; }

        /// <summary>
        /// <p>模型 ID。</p>
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// <p>模型显示名称。</p>
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// <p>模型描述。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>模型概要。</p>
        /// </summary>
        [JsonProperty("Summary")]
        public string Summary{ get; set; }

        /// <summary>
        /// <p>模型类型。取值：Text（文本）、Vision（视觉）、Multimodal（多模态）、Speech（语音）、Embedding（向量）。</p><p>枚举值：</p><ul><li>Text： 语言模型</li><li>Vision： 视觉模型</li><li>Multimodal： 多模态模型</li></ul>
        /// </summary>
        [JsonProperty("ModelType")]
        public string ModelType{ get; set; }

        /// <summary>
        /// <p>模型品牌。</p>
        /// </summary>
        [JsonProperty("Brand")]
        public string Brand{ get; set; }

        /// <summary>
        /// <p>模型图标。</p>
        /// </summary>
        [JsonProperty("ModelImage")]
        public ModelImage ModelImage{ get; set; }

        /// <summary>
        /// <p>模型供应商。</p>
        /// </summary>
        [JsonProperty("Provider")]
        public string Provider{ get; set; }

        /// <summary>
        /// <p>模型状态。取值：online（上线）、offline（下线）。</p><p>枚举值：</p><ul><li>online ： 上线</li><li>pre-offline： 预下线</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>标签列表。</p>
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// <p>计费信息列表。</p>
        /// </summary>
        [JsonProperty("ModelChargingInfo")]
        public ModelChargingInfo[] ModelChargingInfo{ get; set; }

        /// <summary>
        /// <p>模型规格。</p>
        /// </summary>
        [JsonProperty("ModelSpec")]
        public ModelSpec ModelSpec{ get; set; }

        /// <summary>
        /// <p>发布时间。</p>
        /// </summary>
        [JsonProperty("ReleaseAt")]
        public string ReleaseAt{ get; set; }

        /// <summary>
        /// <p>推荐顺序，值越小排序越靠前。</p>
        /// </summary>
        [JsonProperty("RecommendWeight")]
        public long? RecommendWeight{ get; set; }

        /// <summary>
        /// <p>模型访问信息。包含模型在各站点和地域的可用性配置。为空时表示未配置地域信息，模型不可用。</p>
        /// </summary>
        [JsonProperty("ModelAccessInfo")]
        public ModelAccessInfo ModelAccessInfo{ get; set; }

        /// <summary>
        /// <p>体验包信息。</p>
        /// </summary>
        [JsonProperty("FreeTrialInfo")]
        public ModelFreeTrialInfo FreeTrialInfo{ get; set; }

        /// <summary>
        /// <p>模型下线时间，Status=pre-offline 时，会配置模型下线时间</p>
        /// </summary>
        [JsonProperty("OfflineAt")]
        public string OfflineAt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelName", this.ModelName);
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Summary", this.Summary);
            this.SetParamSimple(map, prefix + "ModelType", this.ModelType);
            this.SetParamSimple(map, prefix + "Brand", this.Brand);
            this.SetParamObj(map, prefix + "ModelImage.", this.ModelImage);
            this.SetParamSimple(map, prefix + "Provider", this.Provider);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamArrayObj(map, prefix + "ModelChargingInfo.", this.ModelChargingInfo);
            this.SetParamObj(map, prefix + "ModelSpec.", this.ModelSpec);
            this.SetParamSimple(map, prefix + "ReleaseAt", this.ReleaseAt);
            this.SetParamSimple(map, prefix + "RecommendWeight", this.RecommendWeight);
            this.SetParamObj(map, prefix + "ModelAccessInfo.", this.ModelAccessInfo);
            this.SetParamObj(map, prefix + "FreeTrialInfo.", this.FreeTrialInfo);
            this.SetParamSimple(map, prefix + "OfflineAt", this.OfflineAt);
        }
    }
}

