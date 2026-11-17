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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BlackListItem : AbstractModel
    {
        
        /// <summary>
        /// <p>黑名单条目 ID，客户创建条目时自定义，用于回溯是哪一条命中</p>
        /// </summary>
        [JsonProperty("ModelId")]
        public string ModelId{ get; set; }

        /// <summary>
        /// <p>条目类型。当前仅有 face（人脸）</p>
        /// </summary>
        [JsonProperty("ModelType")]
        public string ModelType{ get; set; }

        /// <summary>
        /// <p>人脸相似度，字符串形式表示，保留 4 位小数，取值 0.0000–1.0000</p>
        /// </summary>
        [JsonProperty("FaceScore")]
        public string FaceScore{ get; set; }

        /// <summary>
        /// <p>背景相似度</p>
        /// </summary>
        [JsonProperty("BackgroundScore")]
        public string BackgroundScore{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "ModelType", this.ModelType);
            this.SetParamSimple(map, prefix + "FaceScore", this.FaceScore);
            this.SetParamSimple(map, prefix + "BackgroundScore", this.BackgroundScore);
        }
    }
}

