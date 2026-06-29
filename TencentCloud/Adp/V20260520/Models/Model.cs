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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Model : AbstractModel
    {
        
        /// <summary>
        /// <p>模型徽章列表</p>
        /// </summary>
        [JsonProperty("BadgeList")]
        public ModelBadge[] BadgeList{ get; set; }

        /// <summary>
        /// <p>模型限制信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LimitInfo")]
        public ModelLimit LimitInfo{ get; set; }

        /// <summary>
        /// <p>模型基本信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelBasic")]
        public ModelBasic ModelBasic{ get; set; }

        /// <summary>
        /// <p>模型超参配置</p>
        /// </summary>
        [JsonProperty("ParameterList")]
        public ModelParameter[] ParameterList{ get; set; }

        /// <summary>
        /// <p>模型属性配置</p>
        /// </summary>
        [JsonProperty("PropertyList")]
        public ModelProperty[] PropertyList{ get; set; }

        /// <summary>
        /// <p>模型提供商信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProviderInfo")]
        public ModelProviderBasic ProviderInfo{ get; set; }

        /// <summary>
        /// <p>模型状态信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatusInfo")]
        public ModelStatus StatusInfo{ get; set; }

        /// <summary>
        /// <p>模型标签列表</p>
        /// </summary>
        [JsonProperty("TagList")]
        public string[] TagList{ get; set; }

        /// <summary>
        /// <p>模型作者信息</p>
        /// </summary>
        [JsonProperty("DeveloperInfo")]
        public ModelDeveloperBasic DeveloperInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "BadgeList.", this.BadgeList);
            this.SetParamObj(map, prefix + "LimitInfo.", this.LimitInfo);
            this.SetParamObj(map, prefix + "ModelBasic.", this.ModelBasic);
            this.SetParamArrayObj(map, prefix + "ParameterList.", this.ParameterList);
            this.SetParamArrayObj(map, prefix + "PropertyList.", this.PropertyList);
            this.SetParamObj(map, prefix + "ProviderInfo.", this.ProviderInfo);
            this.SetParamObj(map, prefix + "StatusInfo.", this.StatusInfo);
            this.SetParamArraySimple(map, prefix + "TagList.", this.TagList);
            this.SetParamObj(map, prefix + "DeveloperInfo.", this.DeveloperInfo);
        }
    }
}

