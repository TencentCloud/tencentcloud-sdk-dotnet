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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Strategy : AbstractModel
    {
        
        /// <summary>
        /// 匹配字段
        ///  
        /// 有以下枚举值：
        /// IP-来源IP
        /// 	IPV6-来源IPv6
        /// 	Referer-Referer
        /// 	URL-请求路径
        /// UserAgent-UserAgent
        /// 	HTTP_METHOD-HTTP请求方法
        /// 	QUERY_STRING-请求字符串
        /// 	GET-GET参数值
        /// 	GET_PARAMS_NAMES-GET参数名
        /// 	POST-POST参数值
        /// 	GET_POST_NAMES-POST参数名
        /// 	POST_BODY-完整BODY
        /// 	COOKIE-Cookie
        /// 	GET_COOKIES_NAMES-Cookie参数名
        /// 	ARGS_COOKIE-Cookie参数值
        /// 	GET_HEADERS_NAMES-Header参数名
        /// 	ARGS_HEADER-Header参数值
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Field")]
        public string Field{ get; set; }

        /// <summary>
        /// 逻辑符号 
        /// 
        /// 有以下枚举值：
        /// empty - 内容为空
        ///   	null - 不存在
        ///   	eq - 等于
        ///   	neq - 不等于
        ///   	contains - 包含
        ///  	ncontains - 不包含
        ///   	strprefix - 前缀匹配
        ///   	strsuffix - 后缀匹配
        ///   	len_eq - 长度等于
        ///   	len_gt - 长度大于
        ///   	len_lt - 长度小于
        ///   	ipmatch - 属于
        ///  	ipnmatch - 不属于
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompareFunc")]
        public string CompareFunc{ get; set; }

        /// <summary>
        /// 匹配内容
        /// 
        /// 目前 只有匹配字段为COOKIE-Cookie时，才不需要输入 匹配内容
        /// 其他都需要
        /// 
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 匹配参数
        /// 
        /// 目前 只有匹配字段为以下4个时，匹配参数才能选择，否则置灰无法选择	
        /// 
        /// GET-GET参数值
        /// 	POST-POST参数值
        /// 	ARGS_COOKIE-Cookie参数值
        /// 	ARGS_HEADER-Header参数值
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Arg")]
        public string Arg{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Field", this.Field);
            this.SetParamSimple(map, prefix + "CompareFunc", this.CompareFunc);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "Arg", this.Arg);
        }
    }
}

