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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeReplayDetailsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>应用id</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>会话id</p>
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// <p>回放id</p>
        /// </summary>
        [JsonProperty("ReplayId")]
        public string ReplayId{ get; set; }

        /// <summary>
        /// <p>事件类别， 默认为all</p>
        /// </summary>
        [JsonProperty("Categories")]
        public string Categories{ get; set; }

        /// <summary>
        /// <p>每页返回数量</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>游标分页，传上一次返回的 NextCursor 值。首次请求不传</p>
        /// </summary>
        [JsonProperty("Cursor")]
        public long? Cursor{ get; set; }

        /// <summary>
        /// <p>起始偏移（毫秒），相对于录屏开始时间。用于只查某个时间段的事件</p>
        /// </summary>
        [JsonProperty("StartOffsetMs")]
        public long? StartOffsetMs{ get; set; }

        /// <summary>
        /// <p>结束偏移（毫秒），必须 ≥ StartOffsetMs</p>
        /// </summary>
        [JsonProperty("EndOffsetMs")]
        public long? EndOffsetMs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "ReplayId", this.ReplayId);
            this.SetParamSimple(map, prefix + "Categories", this.Categories);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Cursor", this.Cursor);
            this.SetParamSimple(map, prefix + "StartOffsetMs", this.StartOffsetMs);
            this.SetParamSimple(map, prefix + "EndOffsetMs", this.EndOffsetMs);
        }
    }
}

