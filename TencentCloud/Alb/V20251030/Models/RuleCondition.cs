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

namespace TencentCloud.Alb.V20251030.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleCondition : AbstractModel
    {
        
        /// <summary>
        /// 转发条件类型。取值：
        /// Host：主机。
        /// Path：路径。
        /// Header：HTTP Header字段。
        /// QueryString：HTPP查询字符串。
        /// Method：请求方法。
        /// Cookie：Cookie。
        /// SourceIp：源 IP。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// Cookie配置。
        /// </summary>
        [JsonProperty("CookieConfig")]
        public HTTPCookieInfo[] CookieConfig{ get; set; }

        /// <summary>
        /// HTTP Header配置。
        /// </summary>
        [JsonProperty("HeaderConfig")]
        public HTTPHeaderInfo HeaderConfig{ get; set; }

        /// <summary>
        /// 主机名。主机配置在一个规则中只能出现一次，长度3 ~ 128个字符，支持精确匹配，正则匹配，通配匹配。
        /// 不能以半角句号（.）、下划线（_）开头或结尾。
        /// 精确匹配，支持的字符集为：a-z 0-9 . - _ 。
        /// 正则匹配，波浪线（~）开头为正则匹配，支持的字符集为：a-z 0-9 . - ? = ~ _ - + \ ^ * ! $ & | ( ) [ ] 。
        /// 通配匹配，星号（*）多字符通配，半角问号（?）单字符通配，支持的字符集为：a-z 0-9 . - _ * ?。
        /// </summary>
        [JsonProperty("HostConfig")]
        public string[] HostConfig{ get; set; }

        /// <summary>
        /// 请求方法。取值：HEAD、GET、POST、OPTIONS、PUT、PATCH、DELETE。
        /// </summary>
        [JsonProperty("MethodConfig")]
        public string[] MethodConfig{ get; set; }

        /// <summary>
        /// 转发路径。长度1 ~ 128个字符，支持精确匹配，正则匹配，通配匹配。
        /// 精确匹配，支持的字符集为：a-z A-Z 0-9 . - _ / =  :。
        /// 正则匹配，需以 ~ 开头，~ 开头表示区分大小写， ~* 开头表示不区分大小写，支持的字符集为： a-z A-Z 0-9 . - _ / = ?  ~ ^ * $ : ( ) [ ] + |。
        /// 通配匹配，* 表示多字符通配，? 表示单字符通配，支持的字符集为：a-z A-Z 0-9 . - _ / =  :。
        /// </summary>
        [JsonProperty("PathConfig")]
        public string[] PathConfig{ get; set; }

        /// <summary>
        /// 查询字符串配置。
        /// </summary>
        [JsonProperty("QueryStringConfig")]
        public HTTPQueryStringInfo[] QueryStringConfig{ get; set; }

        /// <summary>
        /// 源IP匹配配置。CIDR格式，IP地址x.x.x.x/32，IP网段x.x.x.x/24。
        /// </summary>
        [JsonProperty("SourceIpConfig")]
        public string[] SourceIpConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "CookieConfig.", this.CookieConfig);
            this.SetParamObj(map, prefix + "HeaderConfig.", this.HeaderConfig);
            this.SetParamArraySimple(map, prefix + "HostConfig.", this.HostConfig);
            this.SetParamArraySimple(map, prefix + "MethodConfig.", this.MethodConfig);
            this.SetParamArraySimple(map, prefix + "PathConfig.", this.PathConfig);
            this.SetParamArrayObj(map, prefix + "QueryStringConfig.", this.QueryStringConfig);
            this.SetParamArraySimple(map, prefix + "SourceIpConfig.", this.SourceIpConfig);
        }
    }
}

