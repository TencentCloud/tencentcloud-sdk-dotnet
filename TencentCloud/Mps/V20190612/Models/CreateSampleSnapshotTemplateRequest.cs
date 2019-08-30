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

    public class CreateSampleSnapshotTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 图片宽度，取值范围： [128, 4096]，单位：px。
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// 图片高度，取值范围： [128, 4096]，单位：px。
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// 采样截图类型，取值：
        /// <li>Percent：按百分比。</li>
        /// <li>Time：按时间间隔。</li>
        /// </summary>
        [JsonProperty("SampleType")]
        public string SampleType{ get; set; }

        /// <summary>
        /// 采样间隔。
        /// <li>当 SampleType 为 Percent 时，指定采样间隔的百分比。</li>
        /// <li>当 SampleType 为 Time 时，指定采样间隔的时间，单位为秒。</li>
        /// </summary>
        [JsonProperty("SampleInterval")]
        public ulong? SampleInterval{ get; set; }

        /// <summary>
        /// 采样截图模板名称，长度限制：64 个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 图片格式，取值为 jpg 和 png。默认为 jpg。
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// 模板描述信息，长度限制：256 个字符。
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "SampleType", this.SampleType);
            this.SetParamSimple(map, prefix + "SampleInterval", this.SampleInterval);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
        }
    }
}

