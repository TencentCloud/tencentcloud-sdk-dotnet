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

    public class SearchInput : AbstractModel
    {
        
        /// <summary>
        /// <p>图片 URL 列表</p>
        /// </summary>
        [JsonProperty("ImageUrlList")]
        public string[] ImageUrlList{ get; set; }

        /// <summary>
        /// <p>问题</p>
        /// </summary>
        [JsonProperty("Question")]
        public string Question{ get; set; }

        /// <summary>
        /// <p>拆解的子问题列表</p>
        /// </summary>
        [JsonProperty("SubQuestionList")]
        public string[] SubQuestionList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ImageUrlList.", this.ImageUrlList);
            this.SetParamSimple(map, prefix + "Question", this.Question);
            this.SetParamArraySimple(map, prefix + "SubQuestionList.", this.SubQuestionList);
        }
    }
}

