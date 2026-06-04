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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RequestParam : AbstractModel
    {
        
        /// <summary>
        /// 默认值
        /// </summary>
        [JsonProperty("DefaultValue")]
        public string DefaultValue{ get; set; }

        /// <summary>
        /// 参数描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 全局隐藏不可见（区别于Agent场景的agent_hidden），true-全局隐藏不可见，false-可见
        /// </summary>
        [JsonProperty("IsGlobalHidden")]
        public bool? IsGlobalHidden{ get; set; }

        /// <summary>
        /// 是否必选
        /// </summary>
        [JsonProperty("IsRequired")]
        public bool? IsRequired{ get; set; }

        /// <summary>
        /// 参数名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 参数类型
        /// 
        /// 枚举值:
        /// | uint | 描述 |
        /// | --- | --- |
        /// | 0 | 默认值是string，如果不填就按string处理 |
        /// | 1 |  |
        /// | 2 |  |
        /// | 3 |  |
        /// | 4 |  |
        /// | 5 |  |
        /// | 6 |  |
        /// | 7 |  |
        /// | 8 |  |
        /// | 9 |  |
        /// | 20 |  |
        /// | 99 | 空值 |
        /// | 100 | 未指定类型，用于类型为OneOf和AnyOf的场景 |
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// AnyOf类型的参数
        /// </summary>
        [JsonProperty("AnyOf")]
        public RequestParam[] AnyOf{ get; set; }

        /// <summary>
        /// OneOf类型的参数
        /// </summary>
        [JsonProperty("OneOf")]
        public RequestParam[] OneOf{ get; set; }

        /// <summary>
        /// 子参数,ParamType 是OBJECT 或 ARRAY<>类型有用
        /// </summary>
        [JsonProperty("SubParams")]
        public RequestParam[] SubParams{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DefaultValue", this.DefaultValue);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "IsGlobalHidden", this.IsGlobalHidden);
            this.SetParamSimple(map, prefix + "IsRequired", this.IsRequired);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "AnyOf.", this.AnyOf);
            this.SetParamArrayObj(map, prefix + "OneOf.", this.OneOf);
            this.SetParamArrayObj(map, prefix + "SubParams.", this.SubParams);
        }
    }
}

