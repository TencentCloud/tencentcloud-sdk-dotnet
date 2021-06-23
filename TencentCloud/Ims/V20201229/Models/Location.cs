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

namespace TencentCloud.Ims.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Location : AbstractModel
    {
        
        /// <summary>
        /// 该参数用于返回检测框**左上角位置的横坐标**（x）所在的像素位置，结合剩余参数可唯一确定检测框的大小和位置。
        /// </summary>
        [JsonProperty("X")]
        public float? X{ get; set; }

        /// <summary>
        /// 该参数用于返回检测框**左上角位置的纵坐标**（y）所在的像素位置，结合剩余参数可唯一确定检测框的大小和位置。
        /// </summary>
        [JsonProperty("Y")]
        public float? Y{ get; set; }

        /// <summary>
        /// 该参数用于返回**检测框的宽度**（由左上角出发在x轴向右延伸的长度），结合剩余参数可唯一确定检测框的大小和位置。
        /// </summary>
        [JsonProperty("Width")]
        public float? Width{ get; set; }

        /// <summary>
        /// 该参数用于返回**检测框的高度**（由左上角出发在y轴向下延伸的长度），结合剩余参数可唯一确定检测框的大小和位置。
        /// </summary>
        [JsonProperty("Height")]
        public float? Height{ get; set; }

        /// <summary>
        /// 该参数用于返回**检测框的旋转角度**，该参数结合X和Y两个坐标参数可唯一确定检测框的具体位置；取值：**0-360**（**角度制**），方向为**逆时针旋转**。
        /// </summary>
        [JsonProperty("Rotate")]
        public float? Rotate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "X", this.X);
            this.SetParamSimple(map, prefix + "Y", this.Y);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Rotate", this.Rotate);
        }
    }
}

