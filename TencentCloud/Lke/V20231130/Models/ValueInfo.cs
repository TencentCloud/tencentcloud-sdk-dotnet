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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ValueInfo : AbstractModel
    {
        
        /// <summary>
        /// 值ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 值类型：0:未知或者空, 1:string, 2:int, 3:float, 4:bool, 5:array(字符串数组), 6: object_array(结构体数组), 7: object(结构体)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ValueType")]
        public long? ValueType{ get; set; }

        /// <summary>
        /// string
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ValueStr")]
        public string ValueStr{ get; set; }

        /// <summary>
        /// int（避免精度丢失使用字符串返回）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ValueInt")]
        public string ValueInt{ get; set; }

        /// <summary>
        /// float
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ValueFloat")]
        public float? ValueFloat{ get; set; }

        /// <summary>
        /// bool
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ValueBool")]
        public bool? ValueBool{ get; set; }

        /// <summary>
        /// array
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ValueStrArray")]
        public string[] ValueStrArray{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ValueType", this.ValueType);
            this.SetParamSimple(map, prefix + "ValueStr", this.ValueStr);
            this.SetParamSimple(map, prefix + "ValueInt", this.ValueInt);
            this.SetParamSimple(map, prefix + "ValueFloat", this.ValueFloat);
            this.SetParamSimple(map, prefix + "ValueBool", this.ValueBool);
            this.SetParamArraySimple(map, prefix + "ValueStrArray.", this.ValueStrArray);
        }
    }
}

