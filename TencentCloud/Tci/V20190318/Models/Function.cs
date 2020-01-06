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

namespace TencentCloud.Tci.V20190318.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Function : AbstractModel
    {
        
        /// <summary>
        /// 输出全部文本标识，当该值设置为true时，会输出当前音频的全部文本
        /// </summary>
        [JsonProperty("EnableAllText")]
        public bool? EnableAllText{ get; set; }

        /// <summary>
        /// 输出关键词信息标识，当该值设置为true时，会输出当前音频的关键词信息。
        /// </summary>
        [JsonProperty("EnableKeyword")]
        public bool? EnableKeyword{ get; set; }

        /// <summary>
        /// 静音检测标识，当设置为 true 时，需要设置静音时间阈值字段mute_threshold，统计结果中会返回静音片段。
        /// </summary>
        [JsonProperty("EnableMuteDetect")]
        public bool? EnableMuteDetect{ get; set; }

        /// <summary>
        /// 输出音频统计信息标识，当设置为 true 时，任务查询结果会输出音频的统计信息（AsrStat）
        /// </summary>
        [JsonProperty("EnableVadInfo")]
        public bool? EnableVadInfo{ get; set; }

        /// <summary>
        /// 输出音频音量信息标识，当设置为 true 时，会输出当前音频音量信息。
        /// </summary>
        [JsonProperty("EnableVolume")]
        public bool? EnableVolume{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnableAllText", this.EnableAllText);
            this.SetParamSimple(map, prefix + "EnableKeyword", this.EnableKeyword);
            this.SetParamSimple(map, prefix + "EnableMuteDetect", this.EnableMuteDetect);
            this.SetParamSimple(map, prefix + "EnableVadInfo", this.EnableVadInfo);
            this.SetParamSimple(map, prefix + "EnableVolume", this.EnableVolume);
        }
    }
}

