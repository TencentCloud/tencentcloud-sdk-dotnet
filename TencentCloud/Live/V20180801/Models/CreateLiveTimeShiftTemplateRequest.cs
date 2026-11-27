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

    public class CreateLiveTimeShiftTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>模板名称。<br>长度上限：255字节。<br>仅支持中文、英文、数字、_、-。</p>
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// <p>时移时长。单位：s。取值范围：86400 259200 604800 1296000 2592000。</p>
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }

        /// <summary>
        /// <p>描述信息。<br>仅支持中文、英文、数字、_、-。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>地域。<br>Mainland：中国大陆。<br>Overseas：海外及港澳台地区。<br>EuropeFrankfurt：欧洲-法兰克福。<br>NorthAmericaSiliconValley：北美-硅谷。<br>MiddleEastRiyadh：中东-利雅得。<br>AsiaTokyo：亚太-东京。<br>AsiaSeoul：亚太-首尔。<br>默认值：Mainland。</p>
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// <p>分片时长。<br>可取3-10。<br>单位：s。<br>默认值：5。</p>
        /// </summary>
        [JsonProperty("ItemDuration")]
        public ulong? ItemDuration{ get; set; }

        /// <summary>
        /// <p>是否去除水印。<br>传true则将录制原始流。<br>默认值：false。</p>
        /// </summary>
        [JsonProperty("RemoveWatermark")]
        public bool? RemoveWatermark{ get; set; }

        /// <summary>
        /// <p>转码流id列表。<br>此参数仅在 RemoveWatermark为false时生效。</p>
        /// </summary>
        [JsonProperty("TranscodeTemplateIds")]
        public long?[] TranscodeTemplateIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "ItemDuration", this.ItemDuration);
            this.SetParamSimple(map, prefix + "RemoveWatermark", this.RemoveWatermark);
            this.SetParamArraySimple(map, prefix + "TranscodeTemplateIds.", this.TranscodeTemplateIds);
        }
    }
}

