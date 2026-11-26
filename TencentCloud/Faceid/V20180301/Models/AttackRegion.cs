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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AttackRegion : AbstractModel
    {
        
        /// <summary>
        /// <p>攻击区域的四点坐标，固定为轴对齐矩形，按 左上 → 右上 → 右下 → 左下 顺时针顺序排列。单位为像素，坐标原点为图像左上角。数组长度固定为 4。</p>
        /// </summary>
        [JsonProperty("Polygon")]
        public Point[] Polygon{ get; set; }

        /// <summary>
        /// <p>攻击描述，对该区域命中的可疑特征进行详细说明。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Polygon.", this.Polygon);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

