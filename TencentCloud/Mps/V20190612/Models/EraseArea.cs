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

    public class EraseArea : AbstractModel
    {
        
        /// <summary>
        /// 区域左上角X坐标。
        /// 如当Unit取1即使用百分比单位时，0.05表示区域左上角离整个画面左上角的横向距离为画面宽度的5%。
        /// </summary>
        [JsonProperty("LeftTopX")]
        public float? LeftTopX{ get; set; }

        /// <summary>
        /// 区域左上角Y坐标。
        /// 如当Unit取1即使用百分比单位时，0.1表示区域左上角离整个画面左上角的纵向距离为画面高度的10%。
        /// </summary>
        [JsonProperty("LeftTopY")]
        public float? LeftTopY{ get; set; }

        /// <summary>
        /// 区域右下角X坐标。
        /// 如当Unit取1即使用百分比单位时，0.75表示区域右下角离整个画面左上角的横向距离为画面宽度的75%。
        /// </summary>
        [JsonProperty("RightBottomX")]
        public float? RightBottomX{ get; set; }

        /// <summary>
        /// 区域右下角Y坐标。
        /// 如当Unit取1即使用百分比单位时，0.9表示区域右下角离整个画面左上角的纵向距离为画面高度的90%。
        /// </summary>
        [JsonProperty("RightBottomY")]
        public float? RightBottomY{ get; set; }

        /// <summary>
        /// 坐标单位
        /// - 1 百分比
        /// - 2 像素值
        /// </summary>
        [JsonProperty("Unit")]
        public ulong? Unit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LeftTopX", this.LeftTopX);
            this.SetParamSimple(map, prefix + "LeftTopY", this.LeftTopY);
            this.SetParamSimple(map, prefix + "RightBottomX", this.RightBottomX);
            this.SetParamSimple(map, prefix + "RightBottomY", this.RightBottomY);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
        }
    }
}

