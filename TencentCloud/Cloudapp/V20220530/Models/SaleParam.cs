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

namespace TencentCloud.Cloudapp.V20220530.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SaleParam : AbstractModel
    {
        
        /// <summary>
        /// 售卖参数标识
        /// </summary>
        [JsonProperty("ParamKey")]
        public string ParamKey{ get; set; }

        /// <summary>
        /// 售卖参数的展示名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParamKeyName")]
        public string ParamKeyName{ get; set; }

        /// <summary>
        /// 售卖参数值，当ParamType=Quant时，该值有可能为Null
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParamValue")]
        public string ParamValue{ get; set; }

        /// <summary>
        /// 售卖参数值的展示名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParamValueName")]
        public string ParamValueName{ get; set; }

        /// <summary>
        /// 售卖参数的类型，目前支持枚举类Enum/数量类Quant
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ParamType")]
        public string ParamType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ParamKey", this.ParamKey);
            this.SetParamSimple(map, prefix + "ParamKeyName", this.ParamKeyName);
            this.SetParamSimple(map, prefix + "ParamValue", this.ParamValue);
            this.SetParamSimple(map, prefix + "ParamValueName", this.ParamValueName);
            this.SetParamSimple(map, prefix + "ParamType", this.ParamType);
        }
    }
}

