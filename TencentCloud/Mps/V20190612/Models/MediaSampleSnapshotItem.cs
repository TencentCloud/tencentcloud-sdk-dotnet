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

    public class MediaSampleSnapshotItem : AbstractModel
    {
        
        /// <summary>
        /// 采样截图规格 ID，参见[采样截图参数模板](https://cloud.tencent.com/document/product/266/33480#.E9.87.87.E6.A0.B7.E6.88.AA.E5.9B.BE.E6.A8.A1.E6.9D.BF)。
        /// </summary>
        [JsonProperty("Definition")]
        public long? Definition{ get; set; }

        /// <summary>
        /// 采样方式，取值范围：
        /// <li>Percent：根据百分比间隔采样。</li>
        /// <li>Time：根据时间间隔采样。</li>
        /// </summary>
        [JsonProperty("SampleType")]
        public string SampleType{ get; set; }

        /// <summary>
        /// 采样间隔
        /// <li>当 SampleType 为 Percent 时，该值表示多少百分比一张图。</li>
        /// <li>当 SampleType 为 Time 时，该值表示多少时间间隔一张图，单位秒， 第一张图均为视频首帧。</li>
        /// </summary>
        [JsonProperty("Interval")]
        public long? Interval{ get; set; }

        /// <summary>
        /// 截图后文件的存储位置。
        /// </summary>
        [JsonProperty("Storage")]
        public TaskOutputStorage Storage{ get; set; }

        /// <summary>
        /// 生成的截图 path 列表。
        /// </summary>
        [JsonProperty("ImagePathSet")]
        public string[] ImagePathSet{ get; set; }

        /// <summary>
        /// 截图如果被打上了水印，被打水印的模板 ID 列表。
        /// </summary>
        [JsonProperty("WaterMarkDefinition")]
        public long?[] WaterMarkDefinition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Definition", this.Definition);
            this.SetParamSimple(map, prefix + "SampleType", this.SampleType);
            this.SetParamSimple(map, prefix + "Interval", this.Interval);
            this.SetParamObj(map, prefix + "Storage.", this.Storage);
            this.SetParamArraySimple(map, prefix + "ImagePathSet.", this.ImagePathSet);
            this.SetParamArraySimple(map, prefix + "WaterMarkDefinition.", this.WaterMarkDefinition);
        }
    }
}

