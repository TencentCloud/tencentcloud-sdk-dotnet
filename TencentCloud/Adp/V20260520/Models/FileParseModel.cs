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

    public class FileParseModel : AbstractModel
    {
        
        /// <summary>
        /// 模型别名
        /// </summary>
        [JsonProperty("Alias")]
        public string Alias{ get; set; }

        /// <summary>
        /// 模型描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 增强模式
        /// </summary>
        [JsonProperty("EnhancementMode")]
        public string EnhancementMode{ get; set; }

        /// <summary>
        /// 模型唯一ID
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// 模型类型
        /// </summary>
        [JsonProperty("ModelProviderType")]
        public string ModelProviderType{ get; set; }

        /// <summary>
        /// 是否启用公式增强
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableFormulaEnhancement")]
        public bool? EnableFormulaEnhancement{ get; set; }

        /// <summary>
        /// 是否启用 LLM 增强
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableLLMEnhancement")]
        public bool? EnableLLMEnhancement{ get; set; }

        /// <summary>
        /// 是否输出 HTML 表格
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutputHtmlTable")]
        public bool? OutputHtmlTable{ get; set; }

        /// <summary>
        /// 支持的文件类型列表
        /// </summary>
        [JsonProperty("SupportedFileList")]
        public SupportedFileType[] SupportedFileList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Alias", this.Alias);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "EnhancementMode", this.EnhancementMode);
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "ModelProviderType", this.ModelProviderType);
            this.SetParamSimple(map, prefix + "EnableFormulaEnhancement", this.EnableFormulaEnhancement);
            this.SetParamSimple(map, prefix + "EnableLLMEnhancement", this.EnableLLMEnhancement);
            this.SetParamSimple(map, prefix + "OutputHtmlTable", this.OutputHtmlTable);
            this.SetParamArrayObj(map, prefix + "SupportedFileList.", this.SupportedFileList);
        }
    }
}

