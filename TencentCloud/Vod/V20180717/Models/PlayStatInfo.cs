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

    public class PlayStatInfo : AbstractModel
    {
        
        /// <summary>
        /// 数据所在时间区间的开始时间，使用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#I)。如：当时间粒度为天，2018-12-01T00:00:00+08:00，表示2018年12月1日（含）到2018年12月2日（不含）区间。
        /// <li>表示小时级别数据时，2019-08-22T00:00:00+08:00表示2019-08-22日0点到1点的统计数据。</li>
        /// <li>表示天级别数据时，2019-08-22T00:00:00+08:00表示2019-08-22日的统计数据。</li>
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// 媒体文件ID。
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// 播放次数。
        /// </summary>
        [JsonProperty("PlayTimes")]
        public ulong? PlayTimes{ get; set; }

        /// <summary>
        /// 播放流量，单位：字节。
        /// </summary>
        [JsonProperty("Traffic")]
        public ulong? Traffic{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "PlayTimes", this.PlayTimes);
            this.SetParamSimple(map, prefix + "Traffic", this.Traffic);
        }
    }
}

