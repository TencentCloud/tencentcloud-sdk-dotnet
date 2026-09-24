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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ColumnInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>字段名</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>字段类型</p><p>枚举值：</p><ul><li>integer： 数值类型</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>字段描述</p>
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// <p>字段设置（已废弃）</p>
        /// </summary>
        [JsonProperty("FieldSetting")]
        public string FieldSetting{ get; set; }

        /// <summary>
        /// <p>是否为主键（已废弃）</p><p>枚举值：</p><ul><li>true： 是主键</li></ul>
        /// </summary>
        [JsonProperty("IsPrimaryKey")]
        public bool? IsPrimaryKey{ get; set; }

        /// <summary>
        /// <p>字段类型 sqlType 格式</p>
        /// </summary>
        [JsonProperty("TypeText")]
        public string TypeText{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "FieldSetting", this.FieldSetting);
            this.SetParamSimple(map, prefix + "IsPrimaryKey", this.IsPrimaryKey);
            this.SetParamSimple(map, prefix + "TypeText", this.TypeText);
        }
    }
}

