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

    public class ParseWordsResponse : AbstractModel
    {
        
        /// <summary>
        /// 输入文本正则化的结果。（包括对英文文本中的开头和实体进行大写等）
        /// </summary>
        [JsonProperty("NormalText")]
        public string NormalText{ get; set; }

        /// <summary>
        /// 基础粒度分词和词性标注的结果。（请参见附录[词性表](https://cloud.tencent.com/document/product/271/36460)）
        /// </summary>
        [JsonProperty("BasicParticiples")]
        public BasicParticiple[] BasicParticiples{ get; set; }

        /// <summary>
        /// 复合粒度分词和词性标注的结果。（请参见附录[词性表](https://cloud.tencent.com/document/product/271/36460)）
        /// </summary>
        [JsonProperty("CompoundParticiples")]
        public CompoundParticiple[] CompoundParticiples{ get; set; }

        /// <summary>
        /// 实体识别结果。（请参见附录[实体类型数据](https://cloud.tencent.com/document/product/271/90592)）
        /// </summary>
        [JsonProperty("Entities")]
        public Entity[] Entities{ get; set; }

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
            this.SetParamSimple(map, prefix + "NormalText", this.NormalText);
            this.SetParamArrayObj(map, prefix + "BasicParticiples.", this.BasicParticiples);
            this.SetParamArrayObj(map, prefix + "CompoundParticiples.", this.CompoundParticiples);
            this.SetParamArrayObj(map, prefix + "Entities.", this.Entities);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

