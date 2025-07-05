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

    public class CustomField : AbstractModel
    {
        
        /// <summary>
        /// 自定义日志字段类型。从 HTTP 请求和响应中的指定位置提取数据，取值有：
        /// <li>ReqHeader：从 HTTP 请求头中提取指定字段值；</li>
        /// <li>RspHeader：从 HTTP 响应头中提取指定字段值；</li>
        /// <li>Cookie: 从 Cookie 中提取指定字段值；</li>
        /// <li>ReqBody: 从 HTTP 请求正文中通过 Google RE2 正则表达式提取指定内容。</li>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 根据字段类型（Name）填入字段值的定义。需要区分大小写。
        /// <li>当字段类型为 ReqHeader、RspHeader、Cookie 时，填入需要提取值的参数名称，例如：Accept-Language。可输入 1-100 个字符，允许的字符开头为字母，中间为字母、数字、-，结尾为字母、数字；</li>
        /// <li>当字段类型为 ReqBody 时，填入 Google RE2 正则表达式，正则表达式长度上限为 4KB。</li>
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// 是否投递该字段，不填表示不投递此字段。
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
        }
    }
}

