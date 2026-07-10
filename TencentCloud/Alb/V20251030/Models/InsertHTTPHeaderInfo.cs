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

    public class InsertHTTPHeaderInfo : AbstractModel
    {
        
        /// <summary>
        /// 插入的HTTP Header键，长度1 ~ 40个字符，支持的字符集为：a-z A-Z 0-9 - _ 。
        /// 不支持中文，不支持Cookie,Host,Content-Length,Connection,Upgrade,transfer-encoding,keep-alive,te,authority,x-forwarded-for,x-forwarded-proto,x-forwarded-host,x-forwarded-port。
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// HTTP Header值的类型。
        /// ValueType为SystemDefined时，取值范围 ClientPort：客户端端口，ClientIp：客户端 IP 地址，Protocol：客户端请求的协议，CLBPort：负载均衡实例监听端口。
        /// ValueType为UserDefined时，长度1 ~ 128的可打印字符，不支持"，开头和结尾不能为空格，结尾不能为\。
        /// ValueType为ReferenceHeader时，引用请求头中的某一个header，长度1~128的可打印字符，不支持"，开头和结尾不能为空格，结尾不能为\。
        /// </summary>
        [JsonProperty("Value")]
        public string Value{ get; set; }

        /// <summary>
        /// HTTP Header值的类型，取值：
        /// SystemDefined：系统定义的header。
        /// UserDefined：用户自定义的header。
        /// ReferenceHeader：引用请求头中的某一个header。
        /// </summary>
        [JsonProperty("ValueType")]
        public string ValueType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "ValueType", this.ValueType);
        }
    }
}

