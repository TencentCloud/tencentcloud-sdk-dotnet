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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SlotReplacementInfo : AbstractModel
    {
        
        /// <summary>
        /// 卡槽 Id。
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 替换类型，可取值有：
        /// <li> AUDIO ：音频；</li>
        /// <li> VIDEO ：视频；</li>
        /// <li> IMAGE ：图片；</li>
        /// <li> TEXT ：文本。</li>
        /// 注意：这里必须保证替换的素材类型与模板轨道数据的素材类型一致。如果替换的类型为Text,，则必须保证模板轨道数据中相应卡槽的位置标记的是文本。
        /// </summary>
        [JsonProperty("ReplacementType")]
        public string ReplacementType{ get; set; }

        /// <summary>
        /// 媒体替换信息，仅当要替换的媒体类型为音频、视频、图片时有效。
        /// </summary>
        [JsonProperty("MediaReplacementInfo")]
        public MediaReplacementInfo MediaReplacementInfo{ get; set; }

        /// <summary>
        /// 文本替换信息，仅当要替换的卡槽类型为文本时有效。
        /// </summary>
        [JsonProperty("TextReplacementInfo")]
        public TextReplacementInfo TextReplacementInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ReplacementType", this.ReplacementType);
            this.SetParamObj(map, prefix + "MediaReplacementInfo.", this.MediaReplacementInfo);
            this.SetParamObj(map, prefix + "TextReplacementInfo.", this.TextReplacementInfo);
        }
    }
}

