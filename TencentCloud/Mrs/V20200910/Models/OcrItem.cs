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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OcrItem : AbstractModel
    {
        
        /// <summary>
        /// 图片中文字的字符串
        /// </summary>
        [JsonProperty("Words")]
        public string Words{ get; set; }

        /// <summary>
        /// Words 中每个文字的坐标数组，顺序与Words中的字符顺序一致
        /// </summary>
        [JsonProperty("Coords")]
        public Coordinate[] Coords{ get; set; }

        /// <summary>
        /// 整个字符块的坐标信息
        /// </summary>
        [JsonProperty("WordCoords")]
        public Coordinate WordCoords{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Words", this.Words);
            this.SetParamArrayObj(map, prefix + "Coords.", this.Coords);
            this.SetParamObj(map, prefix + "WordCoords.", this.WordCoords);
        }
    }
}

