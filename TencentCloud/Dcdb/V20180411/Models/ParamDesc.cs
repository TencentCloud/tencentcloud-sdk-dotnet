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

namespace TencentCloud.Dcdb.V20180411.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ParamDesc : AbstractModel
    {
        
        /// <summary>
        /// 参数名字
        /// </summary>
        [JsonProperty("Param")]
        public string Param{ get; set; }

        /// <summary>
        /// 当前参数值
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// 设置过的值，参数生效后，该值和value一样。未设置过就不返回该字段。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SetValue")]
        public string SetValue{ get; set; }

        /// <summary>
        /// 系统默认值
        /// </summary>
        [JsonProperty("Default")]
        public string Default{ get; set; }

        /// <summary>
        /// 参数限制
        /// </summary>
        [JsonProperty("Constraint")]
        public ParamConstraint Constraint{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Param", this.Param);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "SetValue", this.SetValue);
            this.SetParamSimple(map, prefix + "Default", this.Default);
            this.SetParamObj(map, prefix + "Constraint.", this.Constraint);
        }
    }
}

