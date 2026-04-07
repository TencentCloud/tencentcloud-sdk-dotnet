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

    public class CreateStreamPackageLinearAssemblyProgramRequest : AbstractModel
    {
        
        /// <summary>
        /// Program名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 绑定的channel。
        /// </summary>
        [JsonProperty("AttachedChannel")]
        public string AttachedChannel{ get; set; }

        /// <summary>
        /// 编排的目标source的类型，分直播Live和点播VOD。Tier为Basic时只支持VOD，Tier为Standard时支持Live和VOD
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// 关联的source location。
        /// </summary>
        [JsonProperty("SourceLocationId")]
        public string SourceLocationId{ get; set; }

        /// <summary>
        /// 关联的直播or点播，source名称，location下全局唯一。
        /// </summary>
        [JsonProperty("SourceName")]
        public string SourceName{ get; set; }

        /// <summary>
        /// PlaybackConf。
        /// </summary>
        [JsonProperty("PlaybackConf")]
        public PlaybackInfoReq PlaybackConf{ get; set; }

        /// <summary>
        /// AdBreaks，只有source类型为Vod时有效。
        /// </summary>
        [JsonProperty("AdBreaks")]
        public AdBreakInfo[] AdBreaks{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "AttachedChannel", this.AttachedChannel);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "SourceLocationId", this.SourceLocationId);
            this.SetParamSimple(map, prefix + "SourceName", this.SourceName);
            this.SetParamObj(map, prefix + "PlaybackConf.", this.PlaybackConf);
            this.SetParamArrayObj(map, prefix + "AdBreaks.", this.AdBreaks);
        }
    }
}

