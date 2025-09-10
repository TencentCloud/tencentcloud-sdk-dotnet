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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApmField : AbstractModel
    {
        
        /// <summary>
        /// 指标名
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// 指标数值
        /// </summary>
        [JsonProperty("Value")]
        public float? Value{ get; set; }

        /// <summary>
        /// 指标所对应的单位
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// 同比结果数组，推荐使用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompareVals")]
        public APMKVItem[] CompareVals{ get; set; }

        /// <summary>
        /// 同比上一个周期的具体指标数值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastPeriodValue")]
        public APMKV[] LastPeriodValue{ get; set; }

        /// <summary>
        /// 同比指标值，已弃用，不建议使用
        /// </summary>
        [JsonProperty("CompareVal")]
        public string CompareVal{ get; set; }

        /// <summary>
        /// 指标中文名
        /// </summary>
        [JsonProperty("NameCN")]
        public string NameCN{ get; set; }

        /// <summary>
        /// 指标英文名
        /// </summary>
        [JsonProperty("NameEN")]
        public string NameEN{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamArrayObj(map, prefix + "CompareVals.", this.CompareVals);
            this.SetParamArrayObj(map, prefix + "LastPeriodValue.", this.LastPeriodValue);
            this.SetParamSimple(map, prefix + "CompareVal", this.CompareVal);
            this.SetParamSimple(map, prefix + "NameCN", this.NameCN);
            this.SetParamSimple(map, prefix + "NameEN", this.NameEN);
        }
    }
}

