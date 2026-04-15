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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IndicatorItem : AbstractModel
    {
        
        /// <summary>
        /// <p>英文缩写</p>
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// <p>标准缩写</p>
        /// </summary>
        [JsonProperty("Scode")]
        public string Scode{ get; set; }

        /// <summary>
        /// <p>项目名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>标准名</p>
        /// </summary>
        [JsonProperty("Sname")]
        public string Sname{ get; set; }

        /// <summary>
        /// <p>结果</p>
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// <p>单位</p>
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// <p>参考范围</p>
        /// </summary>
        [JsonProperty("Range")]
        public string Range{ get; set; }

        /// <summary>
        /// <p>上下箭头</p>
        /// </summary>
        [JsonProperty("Arrow")]
        public string Arrow{ get; set; }

        /// <summary>
        /// <p>是否正常</p>
        /// </summary>
        [JsonProperty("Normal")]
        public bool? Normal{ get; set; }

        /// <summary>
        /// <p>项目原文</p>
        /// </summary>
        [JsonProperty("ItemString")]
        public string ItemString{ get; set; }

        /// <summary>
        /// <p>指标项ID</p>
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// <p>指标项坐标位置</p>
        /// </summary>
        [JsonProperty("Coords")]
        [System.Obsolete]
        public Coordinate Coords{ get; set; }

        /// <summary>
        /// <p>推测结果是否异常</p>
        /// </summary>
        [JsonProperty("InferNormal")]
        public string InferNormal{ get; set; }

        /// <summary>
        /// <p>标本</p>
        /// </summary>
        [JsonProperty("Sample")]
        public string Sample{ get; set; }

        /// <summary>
        /// <p>检测方法</p>
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// <p>检验指标项坐标信息</p>
        /// </summary>
        [JsonProperty("ItemCoords")]
        public ItemCoordinate ItemCoords{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Scode", this.Scode);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Sname", this.Sname);
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamSimple(map, prefix + "Range", this.Range);
            this.SetParamSimple(map, prefix + "Arrow", this.Arrow);
            this.SetParamSimple(map, prefix + "Normal", this.Normal);
            this.SetParamSimple(map, prefix + "ItemString", this.ItemString);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamObj(map, prefix + "Coords.", this.Coords);
            this.SetParamSimple(map, prefix + "InferNormal", this.InferNormal);
            this.SetParamSimple(map, prefix + "Sample", this.Sample);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamObj(map, prefix + "ItemCoords.", this.ItemCoords);
        }
    }
}

