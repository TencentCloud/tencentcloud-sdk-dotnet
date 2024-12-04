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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleCondition : AbstractModel
    {
        
        /// <summary>
        /// 运算符，取值有：
        /// <li> equal: 等于； </li>
        /// <li> notequal: 不等于；</li>
        /// <li> exist: 存在； </li>
        /// <li> notexist: 不存在。</li>
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// 匹配类型，取值有： <li> filename：文件名； </li> <li> extension：文件后缀； </li> <li> host：HOST； </li> <li> full_url：URL Full，当前站点下完整 URL 路径，必须包含 HTTP 协议，Host 和 路径； </li> <li> url：URL Path，当前站点下 URL 路径的请求； </li><li>client_country：客户端国家/地区；</li> <li> query_string：查询字符串，当前站点下请求 URL 的查询字符串； </li> <li> request_header：HTTP 请求头部。 </li><li> client_ip：客户端 IP。 </li><li> request_protocol：请求协议。 </li><li> request_method：HTTP 请求方法。 </li>
        /// </summary>
        [JsonProperty("Target")]
        public string Target{ get; set; }

        /// <summary>
        /// 对应匹配类型的参数值，仅在匹配类型为查询字符串或HTTP请求头并且运算符取值为存在或不存在时允许传空数组，对应匹配类型有：
        /// <li> 文件后缀：jpg、txt 等文件后缀；</li>
        /// <li> 文件名称：例如 foo.jpg 中的 foo；</li>
        /// <li> 全部（站点任意请求）：all；</li>
        /// <li> HOST：当前站点下的 host ，例如www.maxx55.com；</li>
        /// <li> URL Path：当前站点下 URL 路径的请求，例如：/example；</li>
        /// <li> URL Full：当前站点下完整 URL 请求，必须包含 HTTP 协议，Host 和 路径，例如：https://www.maxx55.cn/example；</li>
        /// <li> 客户端国家/地区：符合 ISO3166 标准的国家/地区标识；</li>
        /// <li> 查询字符串: 当前站点下 URL 请求中查询字符串的参数值，例如 lang=cn&version=1 中的 cn 和 1； </li>
        /// <li> HTTP 请求头: HTTP 请求头部字段值，例如 Accept-Language:zh-CN,zh;q=0.9中的zh-CN,zh;q=0.9 ；</li>
        /// <li> 客户端 IP: 当前请求携带的客户端请求 IP，支持 IPv4/IPv6, 支持 IP 段； </li>
        /// <li> 请求协议: 当前请求的协议，取值范围为：HTTP、HTTPS；</li>
        /// <li> HTTP 请求方法: 当前请求的方法，取值范围为：GET、HEAD、POST、PUT、DELETE、TRACE、CONNECT、OPTIONS、PATCH、COPY、LOCK、MKCOL、MOVE、PROPFIND、PROPPATCH、UNLOCK。 </li>
        /// </summary>
        [JsonProperty("Values")]
        public string[] Values{ get; set; }

        /// <summary>
        /// 是否忽略参数值的大小写，默认值为 false。
        /// </summary>
        [JsonProperty("IgnoreCase")]
        public bool? IgnoreCase{ get; set; }

        /// <summary>
        /// 对应匹配类型的参数名称，在 Target 值为以下取值时有效，有效时值不能为空：
        /// <li> query_string（查询字符串）: 当前站点下URL请求中查询字符串的参数名称，例如lang=cn&version=1中的lang和version； </li>
        /// <li> request_header（HTTP 请求头）: HTTP请求头部字段名，例如Accept-Language:zh-CN,zh;q=0.9中的Accept-Language。 </li>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 是否忽略参数名称的大小写，默认值为 false。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IgnoreNameCase")]
        [System.Obsolete]
        public bool? IgnoreNameCase{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "Target", this.Target);
            this.SetParamArraySimple(map, prefix + "Values.", this.Values);
            this.SetParamSimple(map, prefix + "IgnoreCase", this.IgnoreCase);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IgnoreNameCase", this.IgnoreNameCase);
        }
    }
}

