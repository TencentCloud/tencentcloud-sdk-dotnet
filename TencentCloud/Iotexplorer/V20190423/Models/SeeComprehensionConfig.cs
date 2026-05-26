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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SeeComprehensionConfig : AbstractModel
    {
        
        /// <summary>
        /// 拓展的目标及事件检测类别
        /// </summary>
        [JsonProperty("DetectTypes")]
        public string[] DetectTypes{ get; set; }

        /// <summary>
        /// 使该视频 / 图片录入搜索库，后续可进行搜索
        /// </summary>
        [JsonProperty("EnableSearch")]
        public bool? EnableSearch{ get; set; }

        /// <summary>
        /// 主输出语言，可选值包括：
        /// - `zh` 中文（默认值）
        /// - `en` 英语
        /// - `ja` 日语
        /// - `ko` 韩文
        /// - `pt-BR` 葡萄牙语（巴西）
        /// - `th` 泰语
        /// - `ms` 马来语
        /// </summary>
        [JsonProperty("OutputLang")]
        public string OutputLang{ get; set; }

        /// <summary>
        /// 次选输出语言，可选值包括：
        /// - `zh` 中文
        /// - `en` 英语
        /// - `ja` 日语
        /// - `ko` 韩文
        /// - `pt-BR` 葡萄牙语（巴西）
        /// - `th` 泰语
        /// - `ms` 马来语
        /// </summary>
        [JsonProperty("AlternativeOutputLang")]
        public string AlternativeOutputLang{ get; set; }

        /// <summary>
        /// 多摄像头布局定义。可选值包括：
        /// 
        /// - 单摄（默认值）：`Single`
        /// 
        /// - 双摄（纵向排列）- 全部画面：`Vertical,Num=2,Index=0;1`
        /// - 双摄（纵向排列）- 画面1：`Vertical,Num=2,Index=0`
        /// - 双摄（纵向排列）- 画面2：`Vertical,Num=2,Index=1`
        /// 
        /// - 三摄（纵向排列）- 全部画面：`Vertical,Num=3,Index=0;1;2`
        /// - 三摄（纵向排列）- 画面1：`Vertical,Num=3,Index=0`
        /// - 三摄（纵向排列）- 画面2：`Vertical,Num=3,Index=1`
        /// - 三摄（纵向排列）- 画面3：`Vertical,Num=3,Index=2`
        /// - 三摄（纵向排列）- 画面1+2：`Vertical,Num=3,Index=0;1`
        /// - 三摄（纵向排列）- 画面1+3：`Vertical,Num=3,Index=0;2`
        /// - 三摄（纵向排列）- 画面2+3：`Vertical,Num=3,Index=1;2`
        /// </summary>
        [JsonProperty("MultiCameraLayout")]
        public string MultiCameraLayout{ get; set; }

        /// <summary>
        /// 最大处理的输入视频时长，单位：秒（仅对视频输入生效）
        /// </summary>
        [JsonProperty("MaxDuration")]
        public long? MaxDuration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DetectTypes.", this.DetectTypes);
            this.SetParamSimple(map, prefix + "EnableSearch", this.EnableSearch);
            this.SetParamSimple(map, prefix + "OutputLang", this.OutputLang);
            this.SetParamSimple(map, prefix + "AlternativeOutputLang", this.AlternativeOutputLang);
            this.SetParamSimple(map, prefix + "MultiCameraLayout", this.MultiCameraLayout);
            this.SetParamSimple(map, prefix + "MaxDuration", this.MaxDuration);
        }
    }
}

