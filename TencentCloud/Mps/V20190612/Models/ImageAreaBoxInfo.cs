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

    public class ImageAreaBoxInfo : AbstractModel
    {
        
        /// <summary>
        /// 图片框选区域类型，可选值：
        /// <li>logo：图标；</li>
        /// <li>text：文字；</li>
        /// 默认值：logo。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 图片框选区域坐标 (像素级)，[x1, y1, x2, y2]，即左上角坐标、右下角坐标。
        /// 示例值：[101, 85, 111, 95]
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AreaCoordSet")]
        public long?[] AreaCoordSet{ get; set; }

        /// <summary>
        /// 图片框选区域坐标，[x1, y1, x2, y2]，即左上角坐标、右下角坐标， 当AreaCoordSet未指定时生效。
        /// - [0.1, 0.1, 0.3, 0.3] :  表示比例 （数值小于1）
        /// - [50, 50, 350, 280] : 表示像素 （数值大于等于1）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BoundingBox")]
        public float?[] BoundingBox{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "AreaCoordSet.", this.AreaCoordSet);
            this.SetParamArraySimple(map, prefix + "BoundingBox.", this.BoundingBox);
        }
    }
}

