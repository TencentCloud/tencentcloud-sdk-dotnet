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

    public class ParameterConfig : AbstractModel
    {
        
        /// <summary>
        /// 字段名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 字段描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 字段类型
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 是否必填
        /// </summary>
        [JsonProperty("IsRequired")]
        public bool? IsRequired{ get; set; }

        /// <summary>
        /// 子参数
        /// </summary>
        [JsonProperty("SubParams")]
        public ParameterConfig[] SubParams{ get; set; }

        /// <summary>
        /// OneOf类型的参数
        /// </summary>
        [JsonProperty("OneOf")]
        public ParameterConfig[] OneOf{ get; set; }

        /// <summary>
        /// AnyOf类型的参数
        /// </summary>
        [JsonProperty("AnyOf")]
        public ParameterConfig[] AnyOf{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "IsRequired", this.IsRequired);
            this.SetParamArrayObj(map, prefix + "SubParams.", this.SubParams);
            this.SetParamArrayObj(map, prefix + "OneOf.", this.OneOf);
            this.SetParamArrayObj(map, prefix + "AnyOf.", this.AnyOf);
        }
    }
}

