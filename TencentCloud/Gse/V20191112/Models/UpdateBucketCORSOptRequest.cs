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

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateBucketCORSOptRequest : AbstractModel
    {
        
        /// <summary>
        /// 允许的访问来源;具体参见 [cos文档](https://cloud.tencent.com/document/product/436/8279)
        /// </summary>
        [JsonProperty("AllowedOrigins")]
        public string[] AllowedOrigins{ get; set; }

        /// <summary>
        /// 允许的 HTTP 操作方法;可以配置多个:PUT、GET、POST、HEAD。[cos文档](https://cloud.tencent.com/document/product/436/8279)
        /// </summary>
        [JsonProperty("AllowedMethods")]
        public string[] AllowedMethods{ get; set; }

        /// <summary>
        /// 用于指定允许浏览器发送 CORS 请求时携带的自定义 HTTP 请求头部;可以配置*，代表允许所有头部，为了避免遗漏，推荐配置为*。[cos文档](https://cloud.tencent.com/document/product/436/8279)
        /// </summary>
        [JsonProperty("AllowedHeaders")]
        public string[] AllowedHeaders{ get; set; }

        /// <summary>
        /// 跨域资源共享配置的有效时间，单位为秒。[cos文档](https://cloud.tencent.com/document/product/436/8279)
        /// </summary>
        [JsonProperty("MaxAgeSeconds")]
        public long? MaxAgeSeconds{ get; set; }

        /// <summary>
        /// 允许浏览器获取的 CORS 请求响应中的头部，不区分大小写；默认情况下浏览器只能访问简单响应头部：Cache-Control、Content-Type、Expires、Last-Modified，如果需要访问其他响应头部，需要添加 ExposeHeader 配置。[cos文档](https://cloud.tencent.com/document/product/436/8279)
        /// </summary>
        [JsonProperty("ExposeHeaders")]
        public string[] ExposeHeaders{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "AllowedOrigins.", this.AllowedOrigins);
            this.SetParamArraySimple(map, prefix + "AllowedMethods.", this.AllowedMethods);
            this.SetParamArraySimple(map, prefix + "AllowedHeaders.", this.AllowedHeaders);
            this.SetParamSimple(map, prefix + "MaxAgeSeconds", this.MaxAgeSeconds);
            this.SetParamArraySimple(map, prefix + "ExposeHeaders.", this.ExposeHeaders);
        }
    }
}

