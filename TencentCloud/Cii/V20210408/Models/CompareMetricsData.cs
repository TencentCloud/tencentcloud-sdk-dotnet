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

namespace TencentCloud.Cii.V20210408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CompareMetricsData : AbstractModel
    {
        
        /// <summary>
        /// 短文准确率
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShortStructAccuracy")]
        public string ShortStructAccuracy{ get; set; }

        /// <summary>
        /// 短文召回率
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ShortStructRecall")]
        public string ShortStructRecall{ get; set; }

        /// <summary>
        /// 长文结构化准确率
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LongStructAccuracy")]
        public string LongStructAccuracy{ get; set; }

        /// <summary>
        /// 长文结构化召回率
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LongStructRecall")]
        public string LongStructRecall{ get; set; }

        /// <summary>
        /// 长文提取准确率
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LongContentAccuracy")]
        public string LongContentAccuracy{ get; set; }

        /// <summary>
        /// 长文提取召回率
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LongContentRecall")]
        public string LongContentRecall{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ShortStructAccuracy", this.ShortStructAccuracy);
            this.SetParamSimple(map, prefix + "ShortStructRecall", this.ShortStructRecall);
            this.SetParamSimple(map, prefix + "LongStructAccuracy", this.LongStructAccuracy);
            this.SetParamSimple(map, prefix + "LongStructRecall", this.LongStructRecall);
            this.SetParamSimple(map, prefix + "LongContentAccuracy", this.LongContentAccuracy);
            this.SetParamSimple(map, prefix + "LongContentRecall", this.LongContentRecall);
        }
    }
}

