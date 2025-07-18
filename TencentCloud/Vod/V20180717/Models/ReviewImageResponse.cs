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

    public class ReviewImageResponse : AbstractModel
    {
        
        /// <summary>
        /// 图片审核任务结果。
        /// <font color=red>注意：该字段已废弃，建议使用 MediaReviewResult。</font> 
        /// </summary>
        [JsonProperty("ReviewResultSet")]
        [System.Obsolete]
        public ContentReviewResult[] ReviewResultSet{ get; set; }

        /// <summary>
        /// 图片审核任务结果。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MediaReviewResult")]
        public ReviewImageResult MediaReviewResult{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "ReviewResultSet.", this.ReviewResultSet);
            this.SetParamObj(map, prefix + "MediaReviewResult.", this.MediaReviewResult);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

