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

    public class Polygon : AbstractModel
    {
        
        /// <summary>
        /// 左上顶点坐标
        /// </summary>
        [JsonProperty("LeftTop")]
        public Coord LeftTop{ get; set; }

        /// <summary>
        /// 右上顶点坐标
        /// </summary>
        [JsonProperty("RightTop")]
        public Coord RightTop{ get; set; }

        /// <summary>
        /// 右下顶点坐标
        /// </summary>
        [JsonProperty("RightBottom")]
        public Coord RightBottom{ get; set; }

        /// <summary>
        /// 左下顶点坐标
        /// </summary>
        [JsonProperty("LeftBottom")]
        public Coord LeftBottom{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "LeftTop.", this.LeftTop);
            this.SetParamObj(map, prefix + "RightTop.", this.RightTop);
            this.SetParamObj(map, prefix + "RightBottom.", this.RightBottom);
            this.SetParamObj(map, prefix + "LeftBottom.", this.LeftBottom);
        }
    }
}

