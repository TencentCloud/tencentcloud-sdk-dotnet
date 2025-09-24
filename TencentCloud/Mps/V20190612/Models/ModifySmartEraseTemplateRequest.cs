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

    public class ModifySmartEraseTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 智能擦除模板唯一标识
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// 智能擦除模板名称长度限制：64 个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 智能擦除模板描述信息长度限制：256 个字符。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 擦除类型
        /// - subtitle 去字幕
        /// - watermark 去水印
        /// - privacy 隐私保护
        /// </summary>
        [JsonProperty("EraseType")]
        public string EraseType{ get; set; }

        /// <summary>
        /// 字幕擦除配置，EraseType取subtitle或者EraseType不填，对应模板原EraseType为subtitle时生效。
        /// </summary>
        [JsonProperty("EraseSubtitleConfig")]
        public SmartEraseSubtitleConfig EraseSubtitleConfig{ get; set; }

        /// <summary>
        /// 水印擦除配置，EraseType取watermark或者EraseType不填，对应模板原EraseType为watermark时生效。
        /// </summary>
        [JsonProperty("EraseWatermarkConfig")]
        public SmartEraseWatermarkConfig EraseWatermarkConfig{ get; set; }

        /// <summary>
        /// 隐私保护配置，EraseType取privacy或者EraseType不填，对应模板原EraseType为privacy时生效。
        /// </summary>
        [JsonProperty("ErasePrivacyConfig")]
        public SmartErasePrivacyConfig ErasePrivacyConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "EraseType", this.EraseType);
            this.SetParamObj(map, prefix + "EraseSubtitleConfig.", this.EraseSubtitleConfig);
            this.SetParamObj(map, prefix + "EraseWatermarkConfig.", this.EraseWatermarkConfig);
            this.SetParamObj(map, prefix + "ErasePrivacyConfig.", this.ErasePrivacyConfig);
        }
    }
}

