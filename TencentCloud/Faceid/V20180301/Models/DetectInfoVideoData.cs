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

    public class DetectInfoVideoData : AbstractModel
    {
        
        /// <summary>
        /// 活体视频的base64编码。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LivenessVideo")]
        public string LivenessVideo{ get; set; }

        /// <summary>
        /// 当次token中所有用户活体视频的COS存储路径，仅当您开启数据存储服务且“IsReturnAllVideo”入参取值为true 时返回。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LivenessVideos")]
        public VideoDetailData[] LivenessVideos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LivenessVideo", this.LivenessVideo);
            this.SetParamArrayObj(map, prefix + "LivenessVideos.", this.LivenessVideos);
        }
    }
}

