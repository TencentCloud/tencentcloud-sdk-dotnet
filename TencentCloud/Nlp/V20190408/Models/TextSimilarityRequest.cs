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

    public class TextSimilarityRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要与目标句子计算相似度的源句子（仅支持UTF-8格式，不超过500字符）
        /// </summary>
        [JsonProperty("SrcText")]
        public string SrcText{ get; set; }

        /// <summary>
        /// 需要与源句子计算相似度的一个或多个目标句子（仅支持UTF-8格式，目标句子的数量不超过100个，每个句子不超过500字符）
        /// 注意：每成功计算1个目标句子与源句子的相似度算1次调用
        /// </summary>
        [JsonProperty("TargetText")]
        public string[] TargetText{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SrcText", this.SrcText);
            this.SetParamArraySimple(map, prefix + "TargetText.", this.TargetText);
        }
    }
}

