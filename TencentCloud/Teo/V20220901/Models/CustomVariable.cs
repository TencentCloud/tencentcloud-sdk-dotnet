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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomVariable : AbstractModel
    {
        
        /// <summary>
        /// <p>变量名称。需填写完整前缀：user.zone.* 表示站点级自定义变量，user.rule.* 表示规则级自定义变量。前缀后的自定义部分仅支持大小写字母、数字和下划线。变量名称区分大小写，长度不能超过 50 个字符。变量创建成功后，名称不可修改。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>变量初始值。支持使用常量字符串、变量以及公式。长度不能超过 255 个字符。</p>
        /// </summary>
        [JsonProperty("InitialValue")]
        public string InitialValue{ get; set; }

        /// <summary>
        /// <p>变量描述。长度限制不超过 60 个字符。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "InitialValue", this.InitialValue);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

