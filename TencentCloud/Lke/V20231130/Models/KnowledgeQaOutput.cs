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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class KnowledgeQaOutput : AbstractModel
    {
        
        /// <summary>
        /// 输出方式 1：流式 2：非流式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Method")]
        public ulong? Method{ get; set; }

        /// <summary>
        /// 通用模型回复
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UseGeneralKnowledge")]
        public bool? UseGeneralKnowledge{ get; set; }

        /// <summary>
        /// 未知回复语，300字符以内
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BareAnswer")]
        public string BareAnswer{ get; set; }

        /// <summary>
        /// 是否展示问题澄清开关
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShowQuestionClarify")]
        public bool? ShowQuestionClarify{ get; set; }

        /// <summary>
        /// 是否打开问题澄清
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UseQuestionClarify")]
        public bool? UseQuestionClarify{ get; set; }

        /// <summary>
        /// 问题澄清关键词列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QuestionClarifyKeywords")]
        public string[] QuestionClarifyKeywords{ get; set; }

        /// <summary>
        /// 是否打开推荐问题开关
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UseRecommended")]
        public bool? UseRecommended{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "UseGeneralKnowledge", this.UseGeneralKnowledge);
            this.SetParamSimple(map, prefix + "BareAnswer", this.BareAnswer);
            this.SetParamSimple(map, prefix + "ShowQuestionClarify", this.ShowQuestionClarify);
            this.SetParamSimple(map, prefix + "UseQuestionClarify", this.UseQuestionClarify);
            this.SetParamArraySimple(map, prefix + "QuestionClarifyKeywords.", this.QuestionClarifyKeywords);
            this.SetParamSimple(map, prefix + "UseRecommended", this.UseRecommended);
        }
    }
}

