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

namespace TencentCloud.Dayu.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HttpStatusMap : AbstractModel
    {
        
        /// <summary>
        /// http2xx状态码
        /// </summary>
        [JsonProperty("Http2xx")]
        public float?[] Http2xx{ get; set; }

        /// <summary>
        /// http3xx状态码
        /// </summary>
        [JsonProperty("Http3xx")]
        public float?[] Http3xx{ get; set; }

        /// <summary>
        /// http404状态码
        /// </summary>
        [JsonProperty("Http404")]
        public float?[] Http404{ get; set; }

        /// <summary>
        /// http4xx状态码
        /// </summary>
        [JsonProperty("Http4xx")]
        public float?[] Http4xx{ get; set; }

        /// <summary>
        /// http5xx状态码
        /// </summary>
        [JsonProperty("Http5xx")]
        public float?[] Http5xx{ get; set; }

        /// <summary>
        /// http2xx回源状态码
        /// </summary>
        [JsonProperty("SourceHttp2xx")]
        public float?[] SourceHttp2xx{ get; set; }

        /// <summary>
        /// http3xx回源状态码
        /// </summary>
        [JsonProperty("SourceHttp3xx")]
        public float?[] SourceHttp3xx{ get; set; }

        /// <summary>
        /// http404回源状态码
        /// </summary>
        [JsonProperty("SourceHttp404")]
        public float?[] SourceHttp404{ get; set; }

        /// <summary>
        /// http4xx回源状态码
        /// </summary>
        [JsonProperty("SourceHttp4xx")]
        public float?[] SourceHttp4xx{ get; set; }

        /// <summary>
        /// http5xx回源状态码
        /// </summary>
        [JsonProperty("SourceHttp5xx")]
        public float?[] SourceHttp5xx{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Http2xx.", this.Http2xx);
            this.SetParamArraySimple(map, prefix + "Http3xx.", this.Http3xx);
            this.SetParamArraySimple(map, prefix + "Http404.", this.Http404);
            this.SetParamArraySimple(map, prefix + "Http4xx.", this.Http4xx);
            this.SetParamArraySimple(map, prefix + "Http5xx.", this.Http5xx);
            this.SetParamArraySimple(map, prefix + "SourceHttp2xx.", this.SourceHttp2xx);
            this.SetParamArraySimple(map, prefix + "SourceHttp3xx.", this.SourceHttp3xx);
            this.SetParamArraySimple(map, prefix + "SourceHttp404.", this.SourceHttp404);
            this.SetParamArraySimple(map, prefix + "SourceHttp4xx.", this.SourceHttp4xx);
            this.SetParamArraySimple(map, prefix + "SourceHttp5xx.", this.SourceHttp5xx);
        }
    }
}

