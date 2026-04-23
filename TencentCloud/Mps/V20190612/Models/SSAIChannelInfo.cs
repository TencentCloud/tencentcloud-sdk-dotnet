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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SSAIChannelInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>频道ID，全局唯一标识。</p>
        /// </summary>
        [JsonProperty("ID")]
        public string ID{ get; set; }

        /// <summary>
        /// <p>频道名称。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>广告源信息。</p>
        /// </summary>
        [JsonProperty("ContentSource")]
        public string ContentSource{ get; set; }

        /// <summary>
        /// <p>播放地址。兼容旧版本参数，推荐使用HlsPlaybackPrefix或DashPlaybackPrefix</p>
        /// </summary>
        [JsonProperty("PlaybackPrefix")]
        public string PlaybackPrefix{ get; set; }

        /// <summary>
        /// <p>hls播放地址</p>
        /// </summary>
        [JsonProperty("HlsPlaybackPrefix")]
        public string HlsPlaybackPrefix{ get; set; }

        /// <summary>
        /// <p>dash播放地址</p>
        /// </summary>
        [JsonProperty("DashPlaybackPrefix")]
        public string DashPlaybackPrefix{ get; set; }

        /// <summary>
        /// <p>广告插入SSAI配置信息。</p>
        /// </summary>
        [JsonProperty("SSAIInfo")]
        public SSAIConf SSAIInfo{ get; set; }

        /// <summary>
        /// <p>地域信息。</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>用于clickthrough地址</p>
        /// </summary>
        [JsonProperty("SessionInitPrefix")]
        public string SessionInitPrefix{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ContentSource", this.ContentSource);
            this.SetParamSimple(map, prefix + "PlaybackPrefix", this.PlaybackPrefix);
            this.SetParamSimple(map, prefix + "HlsPlaybackPrefix", this.HlsPlaybackPrefix);
            this.SetParamSimple(map, prefix + "DashPlaybackPrefix", this.DashPlaybackPrefix);
            this.SetParamObj(map, prefix + "SSAIInfo.", this.SSAIInfo);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "SessionInitPrefix", this.SessionInitPrefix);
        }
    }
}

