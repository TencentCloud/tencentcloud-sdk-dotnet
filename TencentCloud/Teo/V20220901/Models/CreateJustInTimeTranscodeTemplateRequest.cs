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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateJustInTimeTranscodeTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 即时转码模板名称，长度限制：64 个字符。
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// 模板描述信息，长度限制：256 个字符。默认为空。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 启用视频流开关，取值：
        /// <li>on：开启；</li>
        /// <li>off：关闭。</li>默认值：on。
        /// </summary>
        [JsonProperty("VideoStreamSwitch")]
        public string VideoStreamSwitch{ get; set; }

        /// <summary>
        /// 启用音频流开关，取值：
        /// <li>on：开启；</li>
        /// <li>off：关闭。</li>默认值：on。
        /// </summary>
        [JsonProperty("AudioStreamSwitch")]
        public string AudioStreamSwitch{ get; set; }

        /// <summary>
        /// 视频流配置参数，当 VideoStreamSwitch 为 on，该字段必填。
        /// </summary>
        [JsonProperty("VideoTemplate")]
        public VideoTemplateInfo VideoTemplate{ get; set; }

        /// <summary>
        /// 音频流配置参数，当 AudioStreamSwitch 为 on，该字段必填。
        /// </summary>
        [JsonProperty("AudioTemplate")]
        public AudioTemplateInfo AudioTemplate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "VideoStreamSwitch", this.VideoStreamSwitch);
            this.SetParamSimple(map, prefix + "AudioStreamSwitch", this.AudioStreamSwitch);
            this.SetParamObj(map, prefix + "VideoTemplate.", this.VideoTemplate);
            this.SetParamObj(map, prefix + "AudioTemplate.", this.AudioTemplate);
        }
    }
}

