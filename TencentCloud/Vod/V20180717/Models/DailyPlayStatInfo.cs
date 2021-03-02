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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DailyPlayStatInfo : AbstractModel
    {
        
        /// <summary>
        /// 播放媒体文件的日期，使用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

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
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "PlayTimes", this.PlayTimes);
            this.SetParamSimple(map, prefix + "Traffic", this.Traffic);
        }
    }
}

