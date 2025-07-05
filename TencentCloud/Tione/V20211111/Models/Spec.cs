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

    public class Spec : AbstractModel
    {
        
        /// <summary>
        /// 计费项标签
        /// </summary>
        [JsonProperty("SpecId")]
        public string SpecId{ get; set; }

        /// <summary>
        /// 计费项名称
        /// </summary>
        [JsonProperty("SpecName")]
        public string SpecName{ get; set; }

        /// <summary>
        /// 计费项显示名称
        /// </summary>
        [JsonProperty("SpecAlias")]
        public string SpecAlias{ get; set; }

        /// <summary>
        /// 是否售罄
        /// </summary>
        [JsonProperty("Available")]
        public bool? Available{ get; set; }

        /// <summary>
        /// 当前资源售罄时，可用的区域有哪些
        /// </summary>
        [JsonProperty("AvailableRegion")]
        public string[] AvailableRegion{ get; set; }

        /// <summary>
        /// 当前计费项支持的特性
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SpecFeatures")]
        public string[] SpecFeatures{ get; set; }

        /// <summary>
        /// 计费项类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SpecType")]
        public string SpecType{ get; set; }

        /// <summary>
        /// GPU类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GpuType")]
        public string GpuType{ get; set; }

        /// <summary>
        /// 计费项CategoryId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CategoryId")]
        public string CategoryId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SpecId", this.SpecId);
            this.SetParamSimple(map, prefix + "SpecName", this.SpecName);
            this.SetParamSimple(map, prefix + "SpecAlias", this.SpecAlias);
            this.SetParamSimple(map, prefix + "Available", this.Available);
            this.SetParamArraySimple(map, prefix + "AvailableRegion.", this.AvailableRegion);
            this.SetParamArraySimple(map, prefix + "SpecFeatures.", this.SpecFeatures);
            this.SetParamSimple(map, prefix + "SpecType", this.SpecType);
            this.SetParamSimple(map, prefix + "GpuType", this.GpuType);
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
        }
    }
}

