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

    public class ImageComposeLayer : AbstractModel
    {
        
        /// <summary>
        /// <p>图层堆叠顺序，必填。同一请求内不可重复，数值越大越靠上（建议从 0 开始连续编号）。</p>
        /// </summary>
        [JsonProperty("ZIndex")]
        public long? ZIndex{ get; set; }

        /// <summary>
        /// <p>图层图片来源，必填。支持 URL / COS / AWS-S3 / VOD。</p>
        /// </summary>
        [JsonProperty("InputInfo")]
        public MediaInputInfo InputInfo{ get; set; }

        /// <summary>
        /// <p>图层在画布中的位置与尺寸，必填。长度为 4 的数组 [X1, Y1, X2, Y2]：左上角 + 右下角坐标，要求 X2 &gt; X1、Y2 &gt;    Y1。</p><p>两种语义（与图片擦除能力的 BoundingBox 对齐）：</p><ul><li>像素：坐标值，取值范围 [-10240,    10240]，允许为负或超出画布（超出部分被裁掉）；</li><li>比例：各值 ∈ [-1, 1]，按画布宽高换算（x 乘画布宽、y    乘画布高）。</li></ul><p>图层会缩放填满该矩形；超出画布的部分一律裁掉，输出尺寸恒等于画布尺寸。</p>
        /// </summary>
        [JsonProperty("BoundingBox")]
        public float?[] BoundingBox{ get; set; }

        /// <summary>
        /// <p>坐标单位，与图片擦除能力对齐。取值：</p><ul><li>0：自动判定（不传时的默认值）；</li><li>1：比例；</li><li>2：像素。</li></ul><p>自动判定规则：四个值全部大于 1 按像素解释、全部不大于 1 按比例解释；混合取值会返回InvalidParameter，建议始终显式指定。</p>
        /// </summary>
        [JsonProperty("BoundingBoxUnitType")]
        public ulong? BoundingBoxUnitType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZIndex", this.ZIndex);
            this.SetParamObj(map, prefix + "InputInfo.", this.InputInfo);
            this.SetParamArraySimple(map, prefix + "BoundingBox.", this.BoundingBox);
            this.SetParamSimple(map, prefix + "BoundingBoxUnitType", this.BoundingBoxUnitType);
        }
    }
}

