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

    public class CreateImageSpriteTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 采样类型，取值：
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
        /// 雪碧图中小图的行数。
        /// </summary>
        [JsonProperty("RowCount")]
        public ulong? RowCount{ get; set; }

        /// <summary>
        /// 雪碧图中小图的列数。
        /// </summary>
        [JsonProperty("ColumnCount")]
        public ulong? ColumnCount{ get; set; }

        /// <summary>
        /// 雪碧图模板名称，长度限制：64 个字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 雪碧图中小图的宽度（或长边）的最大值，取值范围：0 和 [128, 4096]，单位：px。
        /// <li>当 Width、Height 均为 0，则分辨率同源；</li>
        /// <li>当 Width 为 0，Height 非 0，则 Width 按比例缩放；</li>
        /// <li>当 Width 非 0，Height 为 0，则 Height 按比例缩放；</li>
        /// <li>当 Width、Height 均非 0，则分辨率按用户指定。</li>
        /// 默认值：0。
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// 雪碧图中小图的高度（或短边）的最大值，取值范围：0 和 [128, 4096]，单位：px。
        /// <li>当 Width、Height 均为 0，则分辨率同源；</li>
        /// <li>当 Width 为 0，Height 非 0，则 Width 按比例缩放；</li>
        /// <li>当 Width 非 0，Height 为 0，则 Height 按比例缩放；</li>
        /// <li>当 Width、Height 均非 0，则分辨率按用户指定。</li>
        /// 默认值：0。
        /// </summary>
        [JsonProperty("Height")]
        public ulong? Height{ get; set; }

        /// <summary>
        /// 分辨率自适应，可选值：
        /// <li>open：开启，此时，Width 代表视频的长边，Height 表示视频的短边；</li>
        /// <li>close：关闭，此时，Width 代表视频的宽度，Height 表示视频的高度。</li>
        /// 默认值：open。
        /// </summary>
        [JsonProperty("ResolutionAdaptive")]
        public string ResolutionAdaptive{ get; set; }

        /// <summary>
        /// 填充方式，当视频流配置宽高参数与原始视频的宽高比不一致时，对转码的处理方式，即为“填充”。可选填充方式：
        /// <li> stretch：拉伸，对每一帧进行拉伸，填满整个画面，可能导致转码后的视频被“压扁“或者“拉长“；</li>
        /// <li>black：留黑，保持视频宽高比不变，边缘剩余部分使用黑色填充。</li>
        /// 默认值：black 。
        /// </summary>
        [JsonProperty("FillType")]
        public string FillType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SampleType", this.SampleType);
            this.SetParamSimple(map, prefix + "SampleInterval", this.SampleInterval);
            this.SetParamSimple(map, prefix + "RowCount", this.RowCount);
            this.SetParamSimple(map, prefix + "ColumnCount", this.ColumnCount);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "ResolutionAdaptive", this.ResolutionAdaptive);
            this.SetParamSimple(map, prefix + "FillType", this.FillType);
        }
    }
}

