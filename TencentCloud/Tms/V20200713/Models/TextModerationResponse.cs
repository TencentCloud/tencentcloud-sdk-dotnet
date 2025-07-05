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

namespace TencentCloud.Tms.V20200713.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TextModerationResponse : AbstractModel
    {
        
        /// <summary>
        /// 您在入参时所填入的Biztype参数
        /// </summary>
        [JsonProperty("BizType")]
        public string BizType{ get; set; }

        /// <summary>
        /// 数据是否属于恶意类型，0：正常 1：可疑
        /// </summary>
        [JsonProperty("EvilFlag")]
        public long? EvilFlag{ get; set; }

        /// <summary>
        /// 恶意标签，Normal：正常，Porn：色情，Abuse：谩骂，Ad：广告，Custom：自定义词库，以及令人反感、不安全或不适宜的内容类型
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// 建议您拿到判断结果后的执行操作
        /// 建议值，Block：建议屏蔽，Review：建议复审，Pass：建议通过
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// 文本命中的关键词信息，用于提示您文本违规的具体原因，可能会返回多个命中的关键词。（如：加我微信）
        /// 如返回值为空，Score不为空，即识别结果（Label）是来自于语义模型判断的返回值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Keywords")]
        public string[] Keywords{ get; set; }

        /// <summary>
        /// 机器判断当前分类的置信度，取值范围：0.00~100.00。分数越高，表示越有可能属于当前分类。
        /// （如：色情 99.99，则该样本属于色情的置信度非常高。）
        /// </summary>
        [JsonProperty("Score")]
        public long? Score{ get; set; }

        /// <summary>
        /// 接口识别样本后返回的详细结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DetailResults")]
        public DetailResults[] DetailResults{ get; set; }

        /// <summary>
        /// 接口识别样本中存在违规账号风险的检测结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RiskDetails")]
        public RiskDetails[] RiskDetails{ get; set; }

        /// <summary>
        /// 扩展字段，用于特定信息返回，不同客户/Biztype下返回信息不同
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }

        /// <summary>
        /// 请求参数中的DataId
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataId")]
        public string DataId{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "EvilFlag", this.EvilFlag);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamArraySimple(map, prefix + "Keywords.", this.Keywords);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamArrayObj(map, prefix + "DetailResults.", this.DetailResults);
            this.SetParamArrayObj(map, prefix + "RiskDetails.", this.RiskDetails);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
            this.SetParamSimple(map, prefix + "DataId", this.DataId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

