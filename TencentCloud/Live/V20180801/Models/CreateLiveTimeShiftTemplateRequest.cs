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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateLiveTimeShiftTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 模板名称。
        /// 长度上限：255字节。
        /// 仅支持中文、英文、数字、_、-。
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// 时移时长。
        /// 单位：s。
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }

        /// <summary>
        /// 描述信息。
        /// 仅支持中文、英文、数字、_、-。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 地域。
        /// Mainland：中国大陆。
        /// Overseas：海外及港澳台地区。
        /// 默认值：Mainland。
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 分片时长。
        /// 可取3-10。
        /// 单位：s。
        /// 默认值：5。
        /// </summary>
        [JsonProperty("ItemDuration")]
        public ulong? ItemDuration{ get; set; }

        /// <summary>
        /// 是否去除水印。
        /// 传true则将录制原始流。
        /// 默认值：false。
        /// </summary>
        [JsonProperty("RemoveWatermark")]
        public bool? RemoveWatermark{ get; set; }

        /// <summary>
        /// 转码流id列表。
        /// 此参数仅在 RemoveWatermark为false时生效。
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

