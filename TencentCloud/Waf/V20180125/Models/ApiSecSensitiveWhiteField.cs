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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApiSecSensitiveWhiteField : AbstractModel
    {
        
        /// <summary>
        /// <p>字段名称</p>
        /// </summary>
        [JsonProperty("FieldName")]
        public string FieldName{ get; set; }

        /// <summary>
        /// <p>字段位置</p>
        /// </summary>
        [JsonProperty("FieldType")]
        public string FieldType{ get; set; }

        /// <summary>
        /// <p>敏感数据类型列表</p>
        /// </summary>
        [JsonProperty("SensitiveTypes")]
        public string[] SensitiveTypes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FieldName", this.FieldName);
            this.SetParamSimple(map, prefix + "FieldType", this.FieldType);
            this.SetParamArraySimple(map, prefix + "SensitiveTypes.", this.SensitiveTypes);
        }
    }
}

