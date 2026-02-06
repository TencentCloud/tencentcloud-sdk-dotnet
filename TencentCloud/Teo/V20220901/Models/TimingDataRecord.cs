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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TimingDataRecord : AbstractModel
    {
        
        /// <summary>
        /// 查询维度值。
        /// </summary>
        [JsonProperty("TypeKey")]
        public string TypeKey{ get; set; }

        /// <summary>
        /// <code>Integer</code> 类型的详细时序数据，查询指标值类型为 <code>Integer</code> 指标会由本字段返回对应时序数据。<br> **注意**：若查询指标未明确说明指标值类型，默认由本字段返回数据。
        /// </summary>
        [JsonProperty("TypeValue")]
        public TimingTypeValue[] TypeValue{ get; set; }

        /// <summary>
        /// <code>Float</code> 类型的详细时序数据，查询指标值类型为 <code>Float</code> 指标会由本字段返回对应时序数据。
        /// </summary>
        [JsonProperty("FloatTypeValue")]
        public FloatTimingTypeValue[] FloatTypeValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TypeKey", this.TypeKey);
            this.SetParamArrayObj(map, prefix + "TypeValue.", this.TypeValue);
            this.SetParamArrayObj(map, prefix + "FloatTypeValue.", this.FloatTypeValue);
        }
    }
}

