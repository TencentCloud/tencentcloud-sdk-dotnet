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

namespace TencentCloud.Tms.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModerationDetail : AbstractModel
    {
        
        /// <summary>
        /// 审核建议，Block表示建议拦截，Review表示建议人工复审，Pass表示建议放行
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// 命中标签，含标签码和一二三级标签名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Label")]
        public LabelGrade Label{ get; set; }

        /// <summary>
        /// 标签得分
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Score")]
        public ulong? Score{ get; set; }

        /// <summary>
        /// label对应腾讯侧命中标签码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TcLabelCodes")]
        public string[] TcLabelCodes{ get; set; }

        /// <summary>
        /// 库检测命中详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LibResults")]
        public LibCheckResult[] LibResults{ get; set; }

        /// <summary>
        /// 模型检测详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ModelResults")]
        public ModelResult[] ModelResults{ get; set; }

        /// <summary>
        /// 情绪正负向检测结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SentimentResult")]
        public SentimentDetail SentimentResult{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamObj(map, prefix + "Label.", this.Label);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamArraySimple(map, prefix + "TcLabelCodes.", this.TcLabelCodes);
            this.SetParamArrayObj(map, prefix + "LibResults.", this.LibResults);
            this.SetParamArrayObj(map, prefix + "ModelResults.", this.ModelResults);
            this.SetParamObj(map, prefix + "SentimentResult.", this.SentimentResult);
        }
    }
}

