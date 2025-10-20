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

namespace TencentCloud.Tmt.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RotateParagraphRect : AbstractModel
    {
        
        /// <summary>
        /// 段落文本坐标
        /// </summary>
        [JsonProperty("Coord")]
        public Coord[] Coord{ get; set; }

        /// <summary>
        /// 旋转角度
        /// </summary>
        [JsonProperty("TiltAngle")]
        public float? TiltAngle{ get; set; }

        /// <summary>
        /// 段落文本信息是否有效
        /// </summary>
        [JsonProperty("Valid")]
        public bool? Valid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Coord.", this.Coord);
            this.SetParamSimple(map, prefix + "TiltAngle", this.TiltAngle);
            this.SetParamSimple(map, prefix + "Valid", this.Valid);
        }
    }
}

