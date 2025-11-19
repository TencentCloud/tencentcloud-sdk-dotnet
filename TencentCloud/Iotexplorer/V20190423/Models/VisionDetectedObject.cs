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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VisionDetectedObject : AbstractModel
    {
        
        /// <summary>
        /// 目标出现的媒体时间戳（以图片为输入时始终取值 0）
        /// </summary>
        [JsonProperty("Time")]
        public float? Time{ get; set; }

        /// <summary>
        /// 目标类别名
        /// </summary>
        [JsonProperty("ClassName")]
        public string ClassName{ get; set; }

        /// <summary>
        /// 目标边界框（坐标顺序为 x1, y1, x2, y2）
        /// </summary>
        [JsonProperty("BoundingBox")]
        public float?[] BoundingBox{ get; set; }

        /// <summary>
        /// 置信度（取值范围 0.0 至 1.0）
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "ClassName", this.ClassName);
            this.SetParamArraySimple(map, prefix + "BoundingBox.", this.BoundingBox);
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
        }
    }
}

