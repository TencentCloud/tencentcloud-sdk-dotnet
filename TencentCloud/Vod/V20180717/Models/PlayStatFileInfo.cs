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

    public class PlayStatFileInfo : AbstractModel
    {
        
        /// <summary>
        /// 播放统计数据所属日期，使用 [ISO 日期格式](https://cloud.tencent.com/document/product/266/11732#I)。
        /// </summary>
        [JsonProperty("Date")]
        public string Date{ get; set; }

        /// <summary>
        /// 播放统计文件的 URL 地址。播放统计文件内容为：
        /// <li> date：播放日期。</li>
        /// <li> file_id：视频文件 ID。</li>
        /// <li> ip_count：去重后的客户端 IP 数。</li>
        /// <li> flux：播放流量，单位：字节。</li>
        /// <li> play_times：总的播放次数。</li>
        /// <li> pc_play_times：PC 端播放次数。</li>
        /// <li> mobile_play_times：移动端播放次数。</li>
        /// <li> iphone_play_times：iPhone 端播放次数。</li>
        /// <li> android_play_times：Android 端播放次数。</li>
        /// <li> host_name	域名。</li>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Date", this.Date);
            this.SetParamSimple(map, prefix + "Url", this.Url);
        }
    }
}

