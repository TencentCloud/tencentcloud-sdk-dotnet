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

namespace TencentCloud.Nlp.V20190408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AnalyzeSentimentResponse : AbstractModel
    {
        
        /// <summary>
        /// 正面情感概率。
        /// </summary>
        [JsonProperty("Positive")]
        public float? Positive{ get; set; }

        /// <summary>
        /// 中性情感概率。
        /// </summary>
        [JsonProperty("Neutral")]
        public float? Neutral{ get; set; }

        /// <summary>
        /// 负面情感概率。
        /// </summary>
        [JsonProperty("Negative")]
        public float? Negative{ get; set; }

        /// <summary>
        /// 情感分类结果：
        /// positive：正面情感
        /// negative：负面情感
        /// neutral：中性、无情感
        /// </summary>
        [JsonProperty("Sentiment")]
        public string Sentiment{ get; set; }

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
            this.SetParamSimple(map, prefix + "Positive", this.Positive);
            this.SetParamSimple(map, prefix + "Neutral", this.Neutral);
            this.SetParamSimple(map, prefix + "Negative", this.Negative);
            this.SetParamSimple(map, prefix + "Sentiment", this.Sentiment);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

