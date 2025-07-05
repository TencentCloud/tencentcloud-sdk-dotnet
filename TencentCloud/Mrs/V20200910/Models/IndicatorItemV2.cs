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

    public class IndicatorItemV2 : AbstractModel
    {
        
        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("Item")]
        public BaseItem Item{ get; set; }

        /// <summary>
        /// 英文编码
        /// </summary>
        [JsonProperty("Code")]
        public BaseItem Code{ get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [JsonProperty("Result")]
        public BaseItem Result{ get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [JsonProperty("Unit")]
        public BaseItem Unit{ get; set; }

        /// <summary>
        /// 参考范围
        /// </summary>
        [JsonProperty("Range")]
        public BaseItem Range{ get; set; }

        /// <summary>
        /// 上下箭头
        /// </summary>
        [JsonProperty("Arrow")]
        public BaseItem Arrow{ get; set; }

        /// <summary>
        /// 检测方法
        /// </summary>
        [JsonProperty("Method")]
        public BaseItem Method{ get; set; }

        /// <summary>
        /// 结果是否异常
        /// </summary>
        [JsonProperty("Normal")]
        public bool? Normal{ get; set; }

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        [JsonProperty("Order")]
        public long? Order{ get; set; }

        /// <summary>
        /// 推测结果是否异常
        /// </summary>
        [JsonProperty("InferNormal")]
        public string InferNormal{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Item.", this.Item);
            this.SetParamObj(map, prefix + "Code.", this.Code);
            this.SetParamObj(map, prefix + "Result.", this.Result);
            this.SetParamObj(map, prefix + "Unit.", this.Unit);
            this.SetParamObj(map, prefix + "Range.", this.Range);
            this.SetParamObj(map, prefix + "Arrow.", this.Arrow);
            this.SetParamObj(map, prefix + "Method.", this.Method);
            this.SetParamSimple(map, prefix + "Normal", this.Normal);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "InferNormal", this.InferNormal);
        }
    }
}

