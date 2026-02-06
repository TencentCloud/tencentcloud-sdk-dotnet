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

    public class AigcFaceIdentityInfo : AbstractModel
    {
        
        /// <summary>
        /// 视频中的人脸 ID。同一个人脸在视频中间隔超过1s时会视作不同 ID。
        /// </summary>
        [JsonProperty("FaceId")]
        public string FaceId{ get; set; }

        /// <summary>
        /// 从视频中截取的人脸示意图。
        /// </summary>
        [JsonProperty("FaceImage")]
        public string FaceImage{ get; set; }

        /// <summary>
        /// 该人脸可对口型区间的起点时间，可作为对口型最佳开始时间。单位：毫秒。
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 该人脸可对口型区间的终点时间；注：此结果存在毫秒级误差，会长于实际区间终点。单位：毫秒。
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FaceId", this.FaceId);
            this.SetParamSimple(map, prefix + "FaceImage", this.FaceImage);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

