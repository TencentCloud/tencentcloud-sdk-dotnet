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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DNATaskOutput : AbstractModel
    {
        
        /// <summary>
        /// <p>命中的参考媒资 FileId。</p>
        /// </summary>
        [JsonProperty("RefFileId")]
        public string RefFileId{ get; set; }

        /// <summary>
        /// <p>查询媒资命中片段起始时间。</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("QueryStartSec")]
        public float? QueryStartSec{ get; set; }

        /// <summary>
        /// <p>查询媒资命中片段结束时间。</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("QueryEndSec")]
        public float? QueryEndSec{ get; set; }

        /// <summary>
        /// <p>参考媒资对应片段起始时间。</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("RefStartSec")]
        public float? RefStartSec{ get; set; }

        /// <summary>
        /// <p>参考媒资对应片段结束时间。</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("RefEndSec")]
        public float? RefEndSec{ get; set; }

        /// <summary>
        /// <p>匹配置信度。</p><p>取值范围：[0, 1]</p>
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// <p>变速比（1.0 表示原速，非 1 表示加速或者减速）。</p>
        /// </summary>
        [JsonProperty("SpeedRatio")]
        public float? SpeedRatio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RefFileId", this.RefFileId);
            this.SetParamSimple(map, prefix + "QueryStartSec", this.QueryStartSec);
            this.SetParamSimple(map, prefix + "QueryEndSec", this.QueryEndSec);
            this.SetParamSimple(map, prefix + "RefStartSec", this.RefStartSec);
            this.SetParamSimple(map, prefix + "RefEndSec", this.RefEndSec);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "SpeedRatio", this.SpeedRatio);
        }
    }
}

