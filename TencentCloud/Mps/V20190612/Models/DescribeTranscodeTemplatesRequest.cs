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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTranscodeTemplatesRequest : AbstractModel
    {
        
        /// <summary>
        /// 转码模板唯一标识过滤条件，数组长度限制：100。
        /// </summary>
        [JsonProperty("Definitions")]
        public long?[] Definitions{ get; set; }

        /// <summary>
        /// 模板类型过滤条件，可选值：
        /// <li>Preset：系统预置模板；</li>
        /// <li>Custom：用户自定义模板。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 封装格式过滤条件，可选值：
        /// <li>Video：视频格式，可以同时包含视频流和音频流的封装格式板；</li>
        /// <li>PureAudio：纯音频格式，只能包含音频流的封装格式。</li>
        /// </summary>
        [JsonProperty("ContainerType")]
        public string ContainerType{ get; set; }

        /// <summary>
        /// （建议使用TranscodeType代替）极速高清过滤条件，用于过滤普通转码或极速高清转码模板，可选值：
        /// <li>Common：普通转码模板；</li>
        /// <li>TEHD：极速高清模板。</li>
        /// </summary>
        [JsonProperty("TEHDType")]
        public string TEHDType{ get; set; }

        /// <summary>
        /// 分页偏移量，默认值：0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回记录条数，默认值：10，最大值：100。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 模板类型（替换旧版本 TEHDType），可选值：
        /// <li>Common：普通转码模板；</li>
        /// <li>TEHD：视频极速高清，老的类型（建议使用 TEHD-100） 。</li>
        /// <li>TEHD-100：视频极速高清</li>
        /// <li>TEHD-200：音频极速高清</li>
        /// <li>Enhance：音视频增强模板。</li>
        /// 默认空，不限制类型。
        /// </summary>
        [JsonProperty("TranscodeType")]
        public string TranscodeType{ get; set; }

        /// <summary>
        /// 转码模板标识过滤条件，长度限制：64 个字符。	
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Definitions.", this.Definitions);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ContainerType", this.ContainerType);
            this.SetParamSimple(map, prefix + "TEHDType", this.TEHDType);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "TranscodeType", this.TranscodeType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
        }
    }
}

