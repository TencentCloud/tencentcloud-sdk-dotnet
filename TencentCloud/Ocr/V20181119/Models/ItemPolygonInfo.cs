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

    public class ItemPolygonInfo : AbstractModel
    {
        
        /// <summary>
        /// 发票的英文字段名称（如Title）
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// 字段值所在位置的四点坐标
        /// </summary>
        [JsonProperty("Polygon")]
        public Polygon Polygon{ get; set; }

        /// <summary>
        /// 字段属于第几行，用于相同字段的排版，如发票明细表格项目，普通字段使用默认值为-1，表示无列排版。
        /// </summary>
        [JsonProperty("Row")]
        public long? Row{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamObj(map, prefix + "Polygon.", this.Polygon);
            this.SetParamSimple(map, prefix + "Row", this.Row);
        }
    }
}

