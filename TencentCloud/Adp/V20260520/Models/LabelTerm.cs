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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LabelTerm : AbstractModel
    {
        
        /// <summary>
        /// <p>同义词列表</p>
        /// </summary>
        [JsonProperty("SynonymList")]
        public string[] SynonymList{ get; set; }

        /// <summary>
        /// <p>标准词</p>
        /// </summary>
        [JsonProperty("Term")]
        public string Term{ get; set; }

        /// <summary>
        /// <p>标准词 ID（由后台生成，创建时不传）</p>
        /// </summary>
        [JsonProperty("TermId")]
        public string TermId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "SynonymList.", this.SynonymList);
            this.SetParamSimple(map, prefix + "Term", this.Term);
            this.SetParamSimple(map, prefix + "TermId", this.TermId);
        }
    }
}

