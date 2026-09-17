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
        /// <p>证件边缘是否完整<br>0：正常<br>1：边缘不完整</p>
        /// </summary>
        [JsonProperty("BorderCheck")]
        public long? BorderCheck{ get; set; }

        /// <summary>
        /// <p>证件是否被遮挡<br>0：正常<br>1：有遮挡</p>
        /// </summary>
        [JsonProperty("OcclusionCheck")]
        public long? OcclusionCheck{ get; set; }

        /// <summary>
        /// <p>是否复印<br>0:正常<br>1:复印件</p>
        /// </summary>
        [JsonProperty("CopyCheck")]
        public long? CopyCheck{ get; set; }

        /// <summary>
        /// <p>是否屏幕翻拍<br>0:正常<br>1:翻拍</p>
        /// </summary>
        [JsonProperty("ReshootCheck")]
        public long? ReshootCheck{ get; set; }

        /// <summary>
        /// <p>证件是否有PS<br>0：正常<br>1：有PS</p>
        /// </summary>
        [JsonProperty("PSCheck")]
        public long? PSCheck{ get; set; }

        /// <summary>
        /// <p>是否模糊：<br>0:正常<br>1:模糊</p>
        /// </summary>
        [JsonProperty("BlurCheck")]
        public long? BlurCheck{ get; set; }

        /// <summary>
        /// <p>模糊分数， 范围：0.0-1.0，分数越高越模糊，建议阈值为0.5</p>
        /// </summary>
        [JsonProperty("BlurScore")]
        public float? BlurScore{ get; set; }

        /// <summary>
        /// <p>是否电子身份证<br>0：否<br>1：是电子身份证</p>
        /// </summary>
        [JsonProperty("ElectronCheck")]
        public long? ElectronCheck{ get; set; }

        /// <summary>
        /// <p>是否存在反光</p><p>枚举值：</p><ul><li>0： 正常</li><li>1： 反光</li></ul><p>默认值：0</p>
        /// </summary>
        [JsonProperty("ReflectCheck")]
        public long? ReflectCheck{ get; set; }


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
            this.SetParamSimple(map, prefix + "ReflectCheck", this.ReflectCheck);
        }
    }
}

