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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HttpCallbackConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>http 标准 url</p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>http header 参数</p>
        /// </summary>
        [JsonProperty("HeaderParams")]
        public HeaderParams[] HeaderParams{ get; set; }

        /// <summary>
        /// <p>http 请求包参数</p>
        /// </summary>
        [JsonProperty("Params")]
        public HttpParams[] Params{ get; set; }

        /// <summary>
        /// <p>对端输出值，由对端 url 返回的 json 包里包含该字段就行</p>
        /// </summary>
        [JsonProperty("Returns")]
        public ReturnKey[] Returns{ get; set; }

        /// <summary>
        /// <p>是否异步</p>
        /// </summary>
        [JsonProperty("Async")]
        public bool? Async{ get; set; }

        /// <summary>
        /// <p>是否鉴权</p><p>枚举值：</p><ul><li>0： 不开启鉴权</li><li>1： 启用鉴权</li></ul>
        /// </summary>
        [JsonProperty("AuthType")]
        public ulong? AuthType{ get; set; }

        /// <summary>
        /// <p>basic token 鉴权</p>
        /// </summary>
        [JsonProperty("BasicAuth")]
        public BasicAuth BasicAuth{ get; set; }

        /// <summary>
        /// <p>bearer token 鉴权</p>
        /// </summary>
        [JsonProperty("BearerAuth")]
        public BearerAuth BearerAuth{ get; set; }

        /// <summary>
        /// <p>自定义鉴权</p>
        /// </summary>
        [JsonProperty("CustomAuth")]
        public HttpParams CustomAuth{ get; set; }

        /// <summary>
        /// <p>oauth2 鉴权</p>
        /// </summary>
        [JsonProperty("Oauth2Auth")]
        public OauthConfig Oauth2Auth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamArrayObj(map, prefix + "HeaderParams.", this.HeaderParams);
            this.SetParamArrayObj(map, prefix + "Params.", this.Params);
            this.SetParamArrayObj(map, prefix + "Returns.", this.Returns);
            this.SetParamSimple(map, prefix + "Async", this.Async);
            this.SetParamSimple(map, prefix + "AuthType", this.AuthType);
            this.SetParamObj(map, prefix + "BasicAuth.", this.BasicAuth);
            this.SetParamObj(map, prefix + "BearerAuth.", this.BearerAuth);
            this.SetParamObj(map, prefix + "CustomAuth.", this.CustomAuth);
            this.SetParamObj(map, prefix + "Oauth2Auth.", this.Oauth2Auth);
        }
    }
}

