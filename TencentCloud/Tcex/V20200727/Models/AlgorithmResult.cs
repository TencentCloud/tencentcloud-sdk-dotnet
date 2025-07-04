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

namespace TencentCloud.Tcex.V20200727.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AlgorithmResult : AbstractModel
    {
        
        /// <summary>
        /// 算法ID
        /// </summary>
        [JsonProperty("AlgoId")]
        public string AlgoId{ get; set; }

        /// <summary>
        /// 算法名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlgoName")]
        public string AlgoName{ get; set; }

        /// <summary>
        /// 算法返回的结果。
        /// - 当算法类型为“OCR（1）”时，结果为文本字符串
        /// - 当算法类型为“文本分类（2）”时，结果字符串为json对象数组：
        ///   Class：分类结果
        ///   Confidence：置信度
        /// - 算法类型为“情感分析（3）”时，结果字符串为json对象：
        ///   Positive：正面情感概率
        ///   Negative：负面情感概率
        ///   Neutral：中性情感概率
        /// - 当算法类型为“合同要素抽取（4）”时，结果字符串为json对象数组：
        ///   NodeName：一级要素名称
        ///   ItemName：二级要素名称
        ///   Content：要素文本内容
        /// - 当算法类型为“实体识别（5）”时，结果字符串为json对象数组：
        ///   - Entity：实体类型
        ///   - Content：实体文本内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// 算法调用错误信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Error")]
        public string Error{ get; set; }

        /// <summary>
        /// 算法类型：
        /// 1：OCR算法
        /// 2：文本分类算法
        /// 3：情感分析算法
        /// 4：合同要素抽取算法
        /// 5、实体识别算法
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlgoType")]
        public long? AlgoType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AlgoId", this.AlgoId);
            this.SetParamSimple(map, prefix + "AlgoName", this.AlgoName);
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "Error", this.Error);
            this.SetParamSimple(map, prefix + "AlgoType", this.AlgoType);
        }
    }
}

