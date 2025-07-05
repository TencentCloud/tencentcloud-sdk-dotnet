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

    public class QualityControlResult : AbstractModel
    {
        
        /// <summary>
        /// 异常类型，取值范围：
        /// Jitter：抖动，
        /// Blur：模糊，
        /// LowLighting：低光照，
        /// HighLighting：过曝，
        /// CrashScreen：花屏，
        /// BlackWhiteEdge：黑白边，
        /// SolidColorScreen：纯色屏，
        /// Noise：噪点，
        /// Mosaic：马赛克，
        /// QRCode：二维码，
        /// AppletCode：小程序码，
        /// BarCode：条形码，
        /// LowVoice：低音，
        /// HighVoice：爆音，
        /// NoVoice：静音，
        /// LowEvaluation：无参考打分低于阈值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 质检结果项。
        /// </summary>
        [JsonProperty("QualityControlItems")]
        public QualityControlItem[] QualityControlItems{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "QualityControlItems.", this.QualityControlItems);
        }
    }
}

