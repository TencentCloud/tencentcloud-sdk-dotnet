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

    public class AclCondition : AbstractModel
    {
        
        /// <summary>
        /// 匹配字段，取值有：
        /// <li>host：请求域名；</li>
        /// <li>sip：客户端IP；</li>
        /// <li>ua：User-Agent；</li>
        /// <li>cookie：会话 Cookie；</li>
        /// <li>cgi：CGI 脚本；</li>
        /// <li>xff：XFF 扩展头部；</li>
        /// <li>url：请求 URL；</li>
        /// <li>accept：请求内容类型；</li>
        /// <li>method：请求方式；</li>
        /// <li>header：请求头部；</li>
        /// <li>app_proto：应用层协议；</li>
        /// <li>sip_proto：网络层协议；</li>
        /// <li>uabot：UA 特征规则，仅bot自定义规则可用；</li>
        /// <li>idcid：IDC 规则，仅bot自定义规则可用；</li>
        /// <li>sipbot：搜索引擎规则，仅bot自定义规则可用；</li>
        /// <li>portrait：画像分析，仅bot自定义规则可用；</li>
        /// <li>header_seq：请求头顺序，仅bot自定义规则可用；</li>
        /// <li>hdr：请求正文，仅Web防护自定义规则可用。</li>
        /// </summary>
        [JsonProperty("MatchFrom")]
        public string MatchFrom{ get; set; }

        /// <summary>
        /// 匹配字符串。当 MatchFrom 为 header 时，可以填入 header 的 key 作为参数。
        /// </summary>
        [JsonProperty("MatchParam")]
        public string MatchParam{ get; set; }

        /// <summary>
        /// 匹配关系，取值有：
        /// <li>equal：字符串等于；</li>
        /// <li>not_equal：数值不等于；</li>
        /// <li>include：字符包含；</li>
        /// <li>not_include：字符不包含；</li>
        /// <li>match：ip匹配；</li>
        /// <li>not_match：ip不匹配；</li>
        /// <li>include_area：地域包含；</li>
        /// <li>is_empty：存在字段但值为空；</li>
        /// <li>not_exists：不存在关键字段；</li>
        /// <li>regexp：正则匹配；</li>
        /// <li>len_gt：数值大于；</li>
        /// <li>len_lt：数值小于；</li>
        /// <li>len_eq：数值等于；</li>
        /// <li>match_prefix：前缀匹配；</li>
        /// <li>match_suffix：后缀匹配；</li>
        /// <li>wildcard：通配符。</li>
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// 匹配内容。
        /// </summary>
        [JsonProperty("MatchContent")]
        public string MatchContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MatchFrom", this.MatchFrom);
            this.SetParamSimple(map, prefix + "MatchParam", this.MatchParam);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "MatchContent", this.MatchContent);
        }
    }
}

