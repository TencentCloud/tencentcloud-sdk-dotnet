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

    public class AppModelConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>AI一键优化模型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AiOptimizeModel")]
        public AIOptimizeModel AiOptimizeModel{ get; set; }

        /// <summary>
        /// <p>实时文件解析模型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileParseModel")]
        public FileParseModel FileParseModel{ get; set; }

        /// <summary>
        /// <p>生成模型配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GenerateModel")]
        public GenerateModel GenerateModel{ get; set; }

        /// <summary>
        /// <p>多模态问答模型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MultiModalQaModel")]
        public MultiModalQAModel MultiModalQaModel{ get; set; }

        /// <summary>
        /// <p>多模态理解模型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MultiModalUnderstandingModel")]
        public MultiModalUnderstandingModel MultiModalUnderstandingModel{ get; set; }

        /// <summary>
        /// <p>Prompt改写模型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PromptRewriteModel")]
        public PromptRewriteModel PromptRewriteModel{ get; set; }

        /// <summary>
        /// <p>思考模型配置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ThinkModel")]
        public ThinkModel ThinkModel{ get; set; }

        /// <summary>
        /// <p>实时文档切分模型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileSplitModel")]
        public FileSplitModel FileSplitModel{ get; set; }

        /// <summary>
        /// <p>表头拆分模型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HeaderExtractModel")]
        public HeaderExtractModel HeaderExtractModel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "AiOptimizeModel.", this.AiOptimizeModel);
            this.SetParamObj(map, prefix + "FileParseModel.", this.FileParseModel);
            this.SetParamObj(map, prefix + "GenerateModel.", this.GenerateModel);
            this.SetParamObj(map, prefix + "MultiModalQaModel.", this.MultiModalQaModel);
            this.SetParamObj(map, prefix + "MultiModalUnderstandingModel.", this.MultiModalUnderstandingModel);
            this.SetParamObj(map, prefix + "PromptRewriteModel.", this.PromptRewriteModel);
            this.SetParamObj(map, prefix + "ThinkModel.", this.ThinkModel);
            this.SetParamObj(map, prefix + "FileSplitModel.", this.FileSplitModel);
            this.SetParamObj(map, prefix + "HeaderExtractModel.", this.HeaderExtractModel);
        }
    }
}

