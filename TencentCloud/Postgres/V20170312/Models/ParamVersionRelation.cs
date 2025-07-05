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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ParamVersionRelation : AbstractModel
    {
        
        /// <summary>
        /// 参数名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 参数信息所属内核版本
        /// </summary>
        [JsonProperty("DBKernelVersion")]
        public string DBKernelVersion{ get; set; }

        /// <summary>
        /// 参数在该版本该规格下的默认值
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// 参数值单位。参数没有单位时，该字段返回空
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// 数值类型（integer、real）参数，取值上界
        /// </summary>
        [JsonProperty("Max")]
        public float? Max{ get; set; }

        /// <summary>
        /// 数值类型（integer、real）参数，取值下界
        /// </summary>
        [JsonProperty("Min")]
        public float? Min{ get; set; }

        /// <summary>
        /// 枚举类型参数，取值范围
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnumValue")]
        public string[] EnumValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DBKernelVersion", this.DBKernelVersion);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamSimple(map, prefix + "Max", this.Max);
            this.SetParamSimple(map, prefix + "Min", this.Min);
            this.SetParamArraySimple(map, prefix + "EnumValue.", this.EnumValue);
        }
    }
}

