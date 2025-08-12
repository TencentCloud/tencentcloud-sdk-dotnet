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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CardWarnInfo : AbstractModel
    {
        
        /// <summary>
        /// 证件边缘是否完整
        /// 0：正常
        /// 1：边缘不完整
        /// </summary>
        [JsonProperty("BorderCheck")]
        public long? BorderCheck{ get; set; }

        /// <summary>
        /// 证件是否被遮挡
        /// 0：正常
        /// 1：有遮挡
        /// </summary>
        [JsonProperty("OcclusionCheck")]
        public long? OcclusionCheck{ get; set; }

        /// <summary>
        /// 是否复印
        /// 0:正常
        /// 1:复印件
        /// </summary>
        [JsonProperty("CopyCheck")]
        public long? CopyCheck{ get; set; }

        /// <summary>
        /// 是否屏幕翻拍
        /// 0:正常
        /// 1:翻拍
        /// </summary>
        [JsonProperty("ReshootCheck")]
        public long? ReshootCheck{ get; set; }

        /// <summary>
        /// 证件是否有PS
        /// 0：正常
        /// 1：有PS
        /// </summary>
        [JsonProperty("PSCheck")]
        public long? PSCheck{ get; set; }

        /// <summary>
        /// 是否模糊：
        /// 0:正常
        /// 1:模糊
        /// </summary>
        [JsonProperty("BlurCheck")]
        public long? BlurCheck{ get; set; }

        /// <summary>
        /// 模糊分数， 范围：0.0-1.0，分数越高越模糊，建议阈值为0.5
        /// </summary>
        [JsonProperty("BlurScore")]
        public float? BlurScore{ get; set; }

        /// <summary>
        /// 是否电子身份证
        /// 0：否
        /// 1：是电子身份证
        /// </summary>
        [JsonProperty("ElectronCheck")]
        public long? ElectronCheck{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BorderCheck", this.BorderCheck);
            this.SetParamSimple(map, prefix + "OcclusionCheck", this.OcclusionCheck);
            this.SetParamSimple(map, prefix + "CopyCheck", this.CopyCheck);
            this.SetParamSimple(map, prefix + "ReshootCheck", this.ReshootCheck);
            this.SetParamSimple(map, prefix + "PSCheck", this.PSCheck);
            this.SetParamSimple(map, prefix + "BlurCheck", this.BlurCheck);
            this.SetParamSimple(map, prefix + "BlurScore", this.BlurScore);
            this.SetParamSimple(map, prefix + "ElectronCheck", this.ElectronCheck);
        }
    }
}

