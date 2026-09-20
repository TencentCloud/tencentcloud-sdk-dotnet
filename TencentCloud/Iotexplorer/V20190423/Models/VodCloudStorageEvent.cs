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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VodCloudStorageEvent : AbstractModel
    {
        
        /// <summary>
        /// <p>事件id</p>
        /// </summary>
        [JsonProperty("EventId")]
        public string EventId{ get; set; }

        /// <summary>
        /// <p>缩略图url</p>
        /// </summary>
        [JsonProperty("ThumbnailUrl")]
        public string ThumbnailUrl{ get; set; }

        /// <summary>
        /// <p>事件开始时间</p>
        /// </summary>
        [JsonProperty("EventStartTime")]
        public ulong? EventStartTime{ get; set; }

        /// <summary>
        /// <p>事件结束时间</p>
        /// </summary>
        [JsonProperty("EventEndTime")]
        public ulong? EventEndTime{ get; set; }

        /// <summary>
        /// <p>视频相关信息</p>
        /// </summary>
        [JsonProperty("VideoList")]
        public VideoList[] VideoList{ get; set; }

        /// <summary>
        /// <p>是否为图片事件</p><p>枚举值：</p><ul><li>true： 图片事件</li><li>false： 视频事件</li></ul>
        /// </summary>
        [JsonProperty("IsStaticEvent")]
        public bool? IsStaticEvent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "ThumbnailUrl", this.ThumbnailUrl);
            this.SetParamSimple(map, prefix + "EventStartTime", this.EventStartTime);
            this.SetParamSimple(map, prefix + "EventEndTime", this.EventEndTime);
            this.SetParamArrayObj(map, prefix + "VideoList.", this.VideoList);
            this.SetParamSimple(map, prefix + "IsStaticEvent", this.IsStaticEvent);
        }
    }
}

