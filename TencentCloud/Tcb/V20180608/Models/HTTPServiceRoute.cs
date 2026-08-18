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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class HTTPServiceRoute : AbstractModel
    {
        
        /// <summary>
        /// <p>路径</p>
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// <p>路径重写规则</p>
        /// </summary>
        [JsonProperty("PathRewrite")]
        public HTTPServicePathRewrite PathRewrite{ get; set; }

        /// <summary>
        /// <p>上游服务类型。SCF: 云函数，CBR: 云托管，STATIC_STORE: 静态托管，WEB_SCF: WEB云函数，LH: Lighthouse</p>
        /// </summary>
        [JsonProperty("UpstreamResourceType")]
        public string UpstreamResourceType{ get; set; }

        /// <summary>
        /// <p>上游服务名</p>
        /// </summary>
        [JsonProperty("UpstreamResourceName")]
        public string UpstreamResourceName{ get; set; }

        /// <summary>
        /// <p>是否开启安全域名</p>
        /// </summary>
        [JsonProperty("EnableSafeDomain")]
        public bool? EnableSafeDomain{ get; set; }

        /// <summary>
        /// <p>是否开启身份认证</p>
        /// </summary>
        [JsonProperty("EnableAuth")]
        public bool? EnableAuth{ get; set; }

        /// <summary>
        /// <p>是否开启路径透传</p>
        /// </summary>
        [JsonProperty("EnablePathTransmission")]
        public bool? EnablePathTransmission{ get; set; }

        /// <summary>
        /// <p>QPS限频策略</p>
        /// </summary>
        [JsonProperty("QPSPolicy")]
        public HTTPServiceRouteQPSPolicy QPSPolicy{ get; set; }

        /// <summary>
        /// <p>是否开启路由</p>
        /// </summary>
        [JsonProperty("Enable")]
        public bool? Enable{ get; set; }

        /// <summary>
        /// <p>扩展字段，内部包含headers处理等</p>
        /// </summary>
        [JsonProperty("Extension")]
        public HTTPServiceExtension Extension{ get; set; }

        /// <summary>
        /// <p>路由创建时间，格式  YYYY-MM-DDTHH:mm:ss±HH:mm，时区为 UTC+8</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>路由更新时间，格式  YYYY-MM-DDTHH:mm:ss±HH:mm，时区为 UTC+8</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamObj(map, prefix + "PathRewrite.", this.PathRewrite);
            this.SetParamSimple(map, prefix + "UpstreamResourceType", this.UpstreamResourceType);
            this.SetParamSimple(map, prefix + "UpstreamResourceName", this.UpstreamResourceName);
            this.SetParamSimple(map, prefix + "EnableSafeDomain", this.EnableSafeDomain);
            this.SetParamSimple(map, prefix + "EnableAuth", this.EnableAuth);
            this.SetParamSimple(map, prefix + "EnablePathTransmission", this.EnablePathTransmission);
            this.SetParamObj(map, prefix + "QPSPolicy.", this.QPSPolicy);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamObj(map, prefix + "Extension.", this.Extension);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

