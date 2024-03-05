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

    public class CustomEndpoint : AbstractModel
    {
        
        /// <summary>
        /// 实时日志投递的自定义 HTTP 接口地址，暂仅支持 HTTP/HTTPS 协议。
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 填写自定义的 SecretId 用于生成加密签名，如果源站需要鉴权此参数必填。
        /// </summary>
        [JsonProperty("AccessId")]
        public string AccessId{ get; set; }

        /// <summary>
        /// 填写自定义的 SecretKey 用于生成加密签名，如果源站需要鉴权此参数必填。
        /// </summary>
        [JsonProperty("AccessKey")]
        public string AccessKey{ get; set; }

        /// <summary>
        /// 数据压缩类型，取值有: <li> gzip：使用 gzip 方式压缩。</li>不填表示不启用压缩。
        /// </summary>
        [JsonProperty("CompressType")]
        public string CompressType{ get; set; }

        /// <summary>
        /// POST 请求投递日志时，使用的应用层协议类型，取值有： 
        /// <li>http：HTTP 协议；</li>
        /// <li>https：HTTPS 协议。</li>如果不填默认根据填写的 URL 地址解析出协议类型。	
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 投递日志时携带的自定义请求头，注意 Content-Type、Accept-Encoding 不支持添加修改。
        /// </summary>
        [JsonProperty("Headers")]
        public Header[] Headers{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "AccessId", this.AccessId);
            this.SetParamSimple(map, prefix + "AccessKey", this.AccessKey);
            this.SetParamSimple(map, prefix + "CompressType", this.CompressType);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamArrayObj(map, prefix + "Headers.", this.Headers);
        }
    }
}

