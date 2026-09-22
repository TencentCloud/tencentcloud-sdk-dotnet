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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateLiveSmartEraseTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>模板名称。长度上限：100字节。</p>
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// <p>擦除类型，如&quot;illegal audio|illegal image|logo|privacy protection 。</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>描述信息。<br>长度上限：1024字节。<br>仅支持中文、英文、数字、_、-。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>关联的审核模板id, 表audio_conf 。</p>
        /// </summary>
        [JsonProperty("AuditConfId")]
        public ulong? AuditConfId{ get; set; }

        /// <summary>
        /// <p>天御图片审核策略BizType  Image 。</p>
        /// </summary>
        [JsonProperty("ImageBizType")]
        public string ImageBizType{ get; set; }

        /// <summary>
        /// <p>天御音频审核策略BizType  ShortAudio 。</p>
        /// </summary>
        [JsonProperty("AudioBizType")]
        public string AudioBizType{ get; set; }

        /// <summary>
        /// <p>天御音频文本审核策略BizType  ShortAudio 。</p>
        /// </summary>
        [JsonProperty("AudioTextBizType")]
        public string AudioTextBizType{ get; set; }

        /// <summary>
        /// <p>展示模式，取值 1:延时稳态展示; 3.实时动态展示。默认1 。</p>
        /// </summary>
        [JsonProperty("DisplayMode")]
        public long? DisplayMode{ get; set; }

        /// <summary>
        /// <p>字幕延迟展示时间,单位毫秒。默认10000。</p>
        /// </summary>
        [JsonProperty("DisplayDelayTime")]
        public long? DisplayDelayTime{ get; set; }

        /// <summary>
        /// <p>隐私保护可选的类型名，包括人脸模糊、车牌模糊</p><p>枚举值：</p><ul><li>blur face： 人脸模糊</li><li>blur license plate： 车牌模糊</li><li>blur face|blur license plate： 复选</li></ul>
        /// </summary>
        [JsonProperty("PrivacyProtection")]
        public string PrivacyProtection{ get; set; }

        /// <summary>
        /// <p>音频处理可选项：静音擦除、哔音擦除，默认选择静音擦除</p><p>枚举值：</p><ul><li>0： 静音</li><li>1： 哔音</li></ul><p>默认值：0</p>
        /// </summary>
        [JsonProperty("AudioErasureMode")]
        public ulong? AudioErasureMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "AuditConfId", this.AuditConfId);
            this.SetParamSimple(map, prefix + "ImageBizType", this.ImageBizType);
            this.SetParamSimple(map, prefix + "AudioBizType", this.AudioBizType);
            this.SetParamSimple(map, prefix + "AudioTextBizType", this.AudioTextBizType);
            this.SetParamSimple(map, prefix + "DisplayMode", this.DisplayMode);
            this.SetParamSimple(map, prefix + "DisplayDelayTime", this.DisplayDelayTime);
            this.SetParamSimple(map, prefix + "PrivacyProtection", this.PrivacyProtection);
            this.SetParamSimple(map, prefix + "AudioErasureMode", this.AudioErasureMode);
        }
    }
}

