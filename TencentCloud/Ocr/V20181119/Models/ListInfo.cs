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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>推理任务的完整提示词。注：仅当QueryType=1/2/3时有效，否则返回为null。</p>
        /// </summary>
        [JsonProperty("QueryInfo")]
        public string QueryInfo{ get; set; }

        /// <summary>
        /// <p>根据QueryType对应任务的返回内容。注：仅当QueryType=1/2/3时有效，其他情况为null。</p>
        /// </summary>
        [JsonProperty("Answer")]
        public string Answer{ get; set; }

        /// <summary>
        /// <p>结构化提取结果。注：仅当QueryType=4时有效，否则返回null。</p>
        /// </summary>
        [JsonProperty("ExtractFields")]
        public FieldsInfo[] ExtractFields{ get; set; }

        /// <summary>
        /// <p>检测到的文本信息，包括内容、坐标以及旋转纠正后的坐标等，具体内容请参见 TextDetection。注：仅当QueryType=0时TextDetections不为空，否则返回null。</p>
        /// </summary>
        [JsonProperty("TextDetections")]
        public TextDetection[] TextDetections{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QueryInfo", this.QueryInfo);
            this.SetParamSimple(map, prefix + "Answer", this.Answer);
            this.SetParamArrayObj(map, prefix + "ExtractFields.", this.ExtractFields);
            this.SetParamArrayObj(map, prefix + "TextDetections.", this.TextDetections);
        }
    }
}

