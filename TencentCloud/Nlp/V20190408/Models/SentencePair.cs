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

namespace TencentCloud.Nlp.V20190408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SentencePair : AbstractModel
    {
        
        /// <summary>
        /// 需要与目标句子计算相似度的源句子。（仅支持UTF-8格式，不超过500字符）
        /// </summary>
        [JsonProperty("SourceText")]
        public string SourceText{ get; set; }

        /// <summary>
        /// 目标句子。（仅支持UTF-8格式，不超过500字符）
        /// </summary>
        [JsonProperty("TargetText")]
        public string TargetText{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceText", this.SourceText);
            this.SetParamSimple(map, prefix + "TargetText", this.TargetText);
        }
    }
}

