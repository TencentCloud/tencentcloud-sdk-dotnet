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

    public class HTTPRedirectInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>重定向的HTTP码，支持301、302、303、307、 308。</p>
        /// </summary>
        [JsonProperty("HttpCode")]
        public long? HttpCode{ get; set; }

        /// <summary>
        /// <p>重定向的主机地址，默认值${host}。长度3 ~ 128个字符，支持的字符集为：a-z 0-9 _ . -。</p>
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// <p>重定向的路径，默认值${path}。长度1 ~ 128个字符，支持的字符集为：a-z A-Z 0-9  ? =  _  . - / : 。</p>
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// <p>重定向的端口，默认值 ${port}。取值1 ~ 65535。</p>
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// <p>重定向的协议，取值：HTTP,HTTPS，默认值${protocol}。</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>重定向的查询字符串，默认值${query}。长度1 ~ 128字符，支持可打印字符，不支持 #[]{}|&lt;&gt;&amp; 和空格。</p>
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HttpCode", this.HttpCode);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Query", this.Query);
        }
    }
}

