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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FieldParam : AbstractModel
    {
        
        /// <summary>
        /// 解析
        /// </summary>
        [JsonProperty("Analyse")]
        public AnalyseParam Analyse{ get; set; }

        /// <summary>
        /// 二次解析
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecondaryAnalyse")]
        public SecondaryAnalyseParam SecondaryAnalyse{ get; set; }

        /// <summary>
        /// 数据处理
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SMT")]
        public SMTParam[] SMT{ get; set; }

        /// <summary>
        /// 测试结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// 解析结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AnalyseResult")]
        public SMTParam[] AnalyseResult{ get; set; }

        /// <summary>
        /// 二次解析结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecondaryAnalyseResult")]
        public SMTParam[] SecondaryAnalyseResult{ get; set; }

        /// <summary>
        /// JSON格式解析结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AnalyseJsonResult")]
        public string AnalyseJsonResult{ get; set; }

        /// <summary>
        /// JSON格式二次解析结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecondaryAnalyseJsonResult")]
        public string SecondaryAnalyseJsonResult{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Analyse.", this.Analyse);
            this.SetParamObj(map, prefix + "SecondaryAnalyse.", this.SecondaryAnalyse);
            this.SetParamArrayObj(map, prefix + "SMT.", this.SMT);
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamArrayObj(map, prefix + "AnalyseResult.", this.AnalyseResult);
            this.SetParamArrayObj(map, prefix + "SecondaryAnalyseResult.", this.SecondaryAnalyseResult);
            this.SetParamSimple(map, prefix + "AnalyseJsonResult", this.AnalyseJsonResult);
            this.SetParamSimple(map, prefix + "SecondaryAnalyseJsonResult", this.SecondaryAnalyseJsonResult);
        }
    }
}

