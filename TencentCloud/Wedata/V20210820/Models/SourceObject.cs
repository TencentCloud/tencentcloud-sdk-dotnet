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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SourceObject : AbstractModel
    {
        
        /// <summary>
        /// 源字段详细类型，int、string
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceObjectDataTypeName")]
        [System.Obsolete]
        public string SourceObjectDataTypeName{ get; set; }

        /// <summary>
        /// 源字段名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceObjectValue")]
        [System.Obsolete]
        public string SourceObjectValue{ get; set; }

        /// <summary>
        /// 源字段详细类型，int、string
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ObjectDataTypeName")]
        public string ObjectDataTypeName{ get; set; }

        /// <summary>
        /// 源字段名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ObjectValue")]
        public string ObjectValue{ get; set; }

        /// <summary>
        /// 对象类型 1.常量  2.离线表级   3.离线字段级
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ObjectType")]
        public ulong? ObjectType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceObjectDataTypeName", this.SourceObjectDataTypeName);
            this.SetParamSimple(map, prefix + "SourceObjectValue", this.SourceObjectValue);
            this.SetParamSimple(map, prefix + "ObjectDataTypeName", this.ObjectDataTypeName);
            this.SetParamSimple(map, prefix + "ObjectValue", this.ObjectValue);
            this.SetParamSimple(map, prefix + "ObjectType", this.ObjectType);
        }
    }
}

