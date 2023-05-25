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

    public class RoundPlayInfo : AbstractModel
    {
        
        /// <summary>
        /// 轮播播单标识。
        /// </summary>
        [JsonProperty("RoundPlayId")]
        public string RoundPlayId{ get; set; }

        /// <summary>
        /// 启播时间，格式按照 ISO 8601标准表示，详见 [ISO 日期格式说明](https://cloud.tencent.com/document/product/266/11732#52)。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 轮播列表。
        /// </summary>
        [JsonProperty("RoundPlaylist")]
        public RoundPlayListItemInfo[] RoundPlaylist{ get; set; }

        /// <summary>
        /// 轮播播单名称，长度限制：64 个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 轮播播单描述信息，长度限制：256 个字符。
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// 播放状态，可选值：
        /// <li>Enabled：启动状态；</li>
        /// <li>Disabled：停止状态。</li>
        /// 默认值：Enabled。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 播放模式，可选值：
        /// <li>Loop：循环播放播单；</li>
        /// <li>Linear：单次播放，播单播放完停止播放。</li>
        /// 默认值：Loop。
        /// </summary>
        [JsonProperty("PlayBackMode")]
        public string PlayBackMode{ get; set; }

        /// <summary>
        /// 轮播播放地址。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoundPlayId", this.RoundPlayId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamArrayObj(map, prefix + "RoundPlaylist.", this.RoundPlaylist);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "PlayBackMode", this.PlayBackMode);
            this.SetParamSimple(map, prefix + "Url", this.Url);
        }
    }
}

