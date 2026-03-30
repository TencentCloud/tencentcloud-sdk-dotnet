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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateOrModifyCloudNativeAPIGatewayCORSRequest : AbstractModel
    {
        
        /// <summary>
        /// 网关ID
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// 跨域插件绑定的资源类型：route|service
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// 路由或服务的id
        /// </summary>
        [JsonProperty("SourceId")]
        public string SourceId{ get; set; }

        /// <summary>
        /// 是否启用插件
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// 跨域 Access-Control-Allow-Origin
        /// </summary>
        [JsonProperty("Origins")]
        public string[] Origins{ get; set; }

        /// <summary>
        /// 跨域 Access-Control-Allow-Headers header
        /// </summary>
        [JsonProperty("Headers")]
        public string[] Headers{ get; set; }

        /// <summary>
        /// 跨域 Access-Control-Allow-Methods
        /// </summary>
        [JsonProperty("Methods")]
        public string[] Methods{ get; set; }

        /// <summary>
        /// 跨域 Access-Control-Expose-Headers
        /// </summary>
        [JsonProperty("ExposedHeaders")]
        public string[] ExposedHeaders{ get; set; }

        /// <summary>
        /// preflight 请求缓存时间
        /// </summary>
        [JsonProperty("MaxAge")]
        public long? MaxAge{ get; set; }

        /// <summary>
        /// 跨域 Access-Control-Allow-Credentials
        /// </summary>
        [JsonProperty("Credentials")]
        public bool? Credentials{ get; set; }

        /// <summary>
        /// 是否把OPTIONS请求透传后端
        /// </summary>
        [JsonProperty("PreFlightContinue")]
        public bool? PreFlightContinue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "SourceId", this.SourceId);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamArraySimple(map, prefix + "Origins.", this.Origins);
            this.SetParamArraySimple(map, prefix + "Headers.", this.Headers);
            this.SetParamArraySimple(map, prefix + "Methods.", this.Methods);
            this.SetParamArraySimple(map, prefix + "ExposedHeaders.", this.ExposedHeaders);
            this.SetParamSimple(map, prefix + "MaxAge", this.MaxAge);
            this.SetParamSimple(map, prefix + "Credentials", this.Credentials);
            this.SetParamSimple(map, prefix + "PreFlightContinue", this.PreFlightContinue);
        }
    }
}

