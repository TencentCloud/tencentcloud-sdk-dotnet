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

namespace TencentCloud.Tms.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TextModerationResponse : AbstractModel
    {
        
        /// <summary>
        /// 该字段用于回显检测对象请求参数中的 BizType，与输入的 BizType 值对应。
        /// </summary>
        [JsonProperty("BizType")]
        public string BizType{ get; set; }

        /// <summary>
        /// 用于标识对本次请求的处置建议，共三种返回值。
        /// 返回值：**Block**: 建议直接做违规处置，**Review**: 建议人工二次确认，**Pass**: 未识别到风险。
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// 该字段用于返回检测结果（DetailResults）中所对应的**优先级最高的恶意标签**，表示模型推荐的审核结果，建议您按照业务所需，对不同违规类型与建议值进行处理。<br>返回值：**Normal**：正常，**Porn**：色情，**Abuse**：谩骂，**Ad**：广告；以及其他令人反感、不安全或不适宜的内容类型
        /// </summary>
        [JsonProperty("Label")]
        public string Label{ get; set; }

        /// <summary>
        /// 对应 Label 字段下的二级子标签，表示该 Label 下更细分的违规点。
        /// </summary>
        [JsonProperty("SubLabel")]
        public string SubLabel{ get; set; }

        /// <summary>
        /// 该字段标识 SubLabel 的置信度，取值范围为 0 - 100，值越高代表置信度越高。
        /// </summary>
        [JsonProperty("Score")]
        public long? Score{ get; set; }

        /// <summary>
        /// 该字段标识被检测文本所命中的关键词，可能返回0个或多个关键词。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Keywords")]
        public string[] Keywords{ get; set; }

        /// <summary>
        /// 该字段返回的检测的详细信息，返回值信息可参阅对应数据结构 DetailResults 的详细描述。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DetailResults")]
        public DetailResults[] DetailResults{ get; set; }

        /// <summary>
        /// 该字段标识入参 User 的检测结果，具体内容参阅数据结构 RiskDetails。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RiskDetails")]
        public RiskDetails[] RiskDetails{ get; set; }

        /// <summary>
        /// 该字段用于返回根据您的需求配置的附加信息（Extra），如未配置则默认返回值为空。
        /// 备注：不同客户或Biztype下返回信息不同，如需配置该字段请提交工单咨询或联系售后专员处理。
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }

        /// <summary>
        /// 该字段用于回显检测对象请求参数中的 DataId，与输入的 DataId 值对应。
        /// </summary>
        [JsonProperty("DataId")]
        public string DataId{ get; set; }

        /// <summary>
        /// 历史上下文关联的字段，不再推荐使用。上下文关联审核可通过入参的 SessionId 来实现。
        /// </summary>
        [JsonProperty("ContextText")]
        public string ContextText{ get; set; }

        /// <summary>
        /// 该字段为历史结构字段，不再推荐使用。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SentimentAnalysis")]
        public SentimentAnalysis SentimentAnalysis{ get; set; }

        /// <summary>
        /// 该字段为历史结构字段，不再推荐使用。
        /// </summary>
        [JsonProperty("HitType")]
        public string HitType{ get; set; }

        /// <summary>
        /// 该字段用于回显检测对象请求参数中的 SessionId，与输入的 SessionId 值对应。
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

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
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "SubLabel", this.SubLabel);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamArraySimple(map, prefix + "Keywords.", this.Keywords);
            this.SetParamArrayObj(map, prefix + "DetailResults.", this.DetailResults);
            this.SetParamArrayObj(map, prefix + "RiskDetails.", this.RiskDetails);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
            this.SetParamSimple(map, prefix + "DataId", this.DataId);
            this.SetParamSimple(map, prefix + "ContextText", this.ContextText);
            this.SetParamObj(map, prefix + "SentimentAnalysis.", this.SentimentAnalysis);
            this.SetParamSimple(map, prefix + "HitType", this.HitType);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

