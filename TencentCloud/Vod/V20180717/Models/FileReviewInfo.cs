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

    public class FileReviewInfo : AbstractModel
    {
        
        /// <summary>
        /// 媒体审核信息\*。
        /// 
        /// \* 只展示通过 [音视频审核(ReviewAudioVideo)](https://cloud.tencent.com/document/api/266/80283) 或 [图片审核(ReviewImage)](https://cloud.tencent.com/document/api/266/73217) 发起的审核结果信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MediaReviewInfo")]
        public ReviewInfo MediaReviewInfo{ get; set; }

        /// <summary>
        /// 媒体封面审核信息\*。
        /// 
        /// \* 只展示通过 [音视频审核(ReviewAudioVideo)](https://cloud.tencent.com/document/api/266/80283) 或 [图片审核(ReviewImage)](https://cloud.tencent.com/document/api/266/73217) 发起的审核结果信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CoverReviewInfo")]
        public ReviewInfo CoverReviewInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "MediaReviewInfo.", this.MediaReviewInfo);
            this.SetParamObj(map, prefix + "CoverReviewInfo.", this.CoverReviewInfo);
        }
    }
}

