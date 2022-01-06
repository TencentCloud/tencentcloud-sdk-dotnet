/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Iotvideoindustry.V20201201.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeLiveVideoListRequest : AbstractModel
    {
        
        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页的每页数量
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 直播频道ID
        /// </summary>
        [JsonProperty("LiveChannelId")]
        public string LiveChannelId{ get; set; }

        /// <summary>
        /// 开始录制开始时间
        /// </summary>
        [JsonProperty("StartRecordTime")]
        public long? StartRecordTime{ get; set; }

        /// <summary>
        /// 开始录制结束时间
        /// </summary>
        [JsonProperty("EndRecordTime")]
        public long? EndRecordTime{ get; set; }

        /// <summary>
        /// 过期开始时间
        /// </summary>
        [JsonProperty("StartExpireTime")]
        public long? StartExpireTime{ get; set; }

        /// <summary>
        /// 过期结束时间
        /// </summary>
        [JsonProperty("EndExpireTime")]
        public long? EndExpireTime{ get; set; }

        /// <summary>
        /// 文件大小范围 Byte
        /// </summary>
        [JsonProperty("StartFileSize")]
        public long? StartFileSize{ get; set; }

        /// <summary>
        /// 文件大小范围 Byte
        /// </summary>
        [JsonProperty("EndFileSize")]
        public long? EndFileSize{ get; set; }

        /// <summary>
        /// 录制状态，5: 录制回写完
        /// </summary>
        [JsonProperty("IsRecording")]
        public long? IsRecording{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "LiveChannelId", this.LiveChannelId);
            this.SetParamSimple(map, prefix + "StartRecordTime", this.StartRecordTime);
            this.SetParamSimple(map, prefix + "EndRecordTime", this.EndRecordTime);
            this.SetParamSimple(map, prefix + "StartExpireTime", this.StartExpireTime);
            this.SetParamSimple(map, prefix + "EndExpireTime", this.EndExpireTime);
            this.SetParamSimple(map, prefix + "StartFileSize", this.StartFileSize);
            this.SetParamSimple(map, prefix + "EndFileSize", this.EndFileSize);
            this.SetParamSimple(map, prefix + "IsRecording", this.IsRecording);
        }
    }
}

