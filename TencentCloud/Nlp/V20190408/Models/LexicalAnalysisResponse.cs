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

    public class LexicalAnalysisResponse : AbstractModel
    {
        
        /// <summary>
        /// 命名实体识别结果。取值范围：
        /// <li>PER：表示人名</li>
        /// <li>LOC：表示地名</li>
        /// <li>ORG：表示机构团体名</li>
        /// </summary>
        [JsonProperty("NerTokens")]
        public NerToken[] NerTokens{ get; set; }

        /// <summary>
        /// 分词&词性标注结果（词性表请参见附录）
        /// </summary>
        [JsonProperty("PosTokens")]
        public PosToken[] PosTokens{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "NerTokens.", this.NerTokens);
            this.SetParamArrayObj(map, prefix + "PosTokens.", this.PosTokens);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

