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

    public class CreateCloudBaseGWAPIRequest : AbstractModel
    {
        
        /// <summary>
        /// Service ID
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// API Path
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// API类型（1表示云函数，2表示容器）
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// API Name
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// APIId，如果非空，表示修改绑定Path
        /// </summary>
        [JsonProperty("APIId")]
        public string APIId{ get; set; }

        /// <summary>
        /// 自定义值通用字段（当Type为容器时必填）
        /// </summary>
        [JsonProperty("Custom")]
        public string Custom{ get; set; }

        /// <summary>
        /// 认证开关 1为开启 2为关闭
        /// </summary>
        [JsonProperty("AuthSwitch")]
        public ulong? AuthSwitch{ get; set; }

        /// <summary>
        /// 是否开启多地域
        /// </summary>
        [JsonProperty("EnableRegion")]
        public bool? EnableRegion{ get; set; }

        /// <summary>
        /// 是否启用统一域名
        /// </summary>
        [JsonProperty("EnableUnion")]
        public bool? EnableUnion{ get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 访问类型："OA", "PUBLIC", "MINIAPP", "VPC" （不传默认PUBLIC+MINIAPP+VPC）
        /// </summary>
        [JsonProperty("AccessTypes")]
        public string[] AccessTypes{ get; set; }

        /// <summary>
        /// 是否开启路径透传，默认true表示短路径，即不开启路径透传(已弃用)
        /// </summary>
        [JsonProperty("IsShortPath")]
        public bool? IsShortPath{ get; set; }

        /// <summary>
        /// 路径透传，默认0关闭，1开启，2关闭
        /// </summary>
        [JsonProperty("PathTransmission")]
        public ulong? PathTransmission{ get; set; }

        /// <summary>
        /// 跨域校验，默认0开启，1开启，2关闭
        /// </summary>
        [JsonProperty("EnableCheckAcrossDomain")]
        public ulong? EnableCheckAcrossDomain{ get; set; }

        /// <summary>
        /// 静态托管资源目录
        /// </summary>
        [JsonProperty("StaticFileDirectory")]
        public string StaticFileDirectory{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "APIId", this.APIId);
            this.SetParamSimple(map, prefix + "Custom", this.Custom);
            this.SetParamSimple(map, prefix + "AuthSwitch", this.AuthSwitch);
            this.SetParamSimple(map, prefix + "EnableRegion", this.EnableRegion);
            this.SetParamSimple(map, prefix + "EnableUnion", this.EnableUnion);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamArraySimple(map, prefix + "AccessTypes.", this.AccessTypes);
            this.SetParamSimple(map, prefix + "IsShortPath", this.IsShortPath);
            this.SetParamSimple(map, prefix + "PathTransmission", this.PathTransmission);
            this.SetParamSimple(map, prefix + "EnableCheckAcrossDomain", this.EnableCheckAcrossDomain);
            this.SetParamSimple(map, prefix + "StaticFileDirectory", this.StaticFileDirectory);
        }
    }
}

