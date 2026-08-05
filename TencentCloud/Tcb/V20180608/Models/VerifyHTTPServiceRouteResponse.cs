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

    public class VerifyHTTPServiceRouteResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>前置校验总开关。所有启用的检查项均为 PASS 或 SKIPPED 时为 true，任一检查项为 FAIL 时为 false。当为 false 时，前端应根据各 CheckItem 的 Code 精确渲染错误提示和操作指引；当为 true 时可继续调用 CreateHTTPServiceRoute 完成创建。 示例值：false</p>
        /// </summary>
        [JsonProperty("Passed")]
        public bool? Passed{ get; set; }

        /// <summary>
        /// <p>域名归属权校验结果</p>
        /// </summary>
        [JsonProperty("Ownership")]
        public VerifyHTTPServiceRouteCheckItem Ownership{ get; set; }

        /// <summary>
        /// <p>证书校验结果；CertId 为空时 Status=SKIPPED</p>
        /// </summary>
        [JsonProperty("Cert")]
        public VerifyHTTPServiceRouteCheckItem Cert{ get; set; }

        /// <summary>
        /// <p>域名/路径数量配额校验结果</p>
        /// </summary>
        [JsonProperty("Quota")]
        public VerifyHTTPServiceRouteCheckItem Quota{ get; set; }

        /// <summary>
        /// <p>同域名下路由路径冲突校验结果</p>
        /// </summary>
        [JsonProperty("RouteConflict")]
        public VerifyHTTPServiceRouteCheckItem RouteConflict{ get; set; }

        /// <summary>
        /// <p>域名被其他环境占用校验结果</p>
        /// </summary>
        [JsonProperty("DomainConflict")]
        public VerifyHTTPServiceRouteCheckItem DomainConflict{ get; set; }

        /// <summary>
        /// <p>内部域名且非内部账号校验结果</p>
        /// </summary>
        [JsonProperty("InternalAccount")]
        public VerifyHTTPServiceRouteCheckItem InternalAccount{ get; set; }

        /// <summary>
        /// <p>域名黑名单校验结果</p>
        /// </summary>
        [JsonProperty("Blacklist")]
        public VerifyHTTPServiceRouteCheckItem Blacklist{ get; set; }

        /// <summary>
        /// <p>AccessType=CDN 时 CDN 资源存在性 / 状态校验结果（含 ICP 未备案的提示）</p>
        /// </summary>
        [JsonProperty("CDNResource")]
        public VerifyHTTPServiceRouteCheckItem CDNResource{ get; set; }

        /// <summary>
        /// <p>AccessType=EO 时的 EdgeOne 预检结果（域名冲突/备案/归属权）</p>
        /// </summary>
        [JsonProperty("EO")]
        public VerifyHTTPServiceRouteCheckItem EO{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Passed", this.Passed);
            this.SetParamObj(map, prefix + "Ownership.", this.Ownership);
            this.SetParamObj(map, prefix + "Cert.", this.Cert);
            this.SetParamObj(map, prefix + "Quota.", this.Quota);
            this.SetParamObj(map, prefix + "RouteConflict.", this.RouteConflict);
            this.SetParamObj(map, prefix + "DomainConflict.", this.DomainConflict);
            this.SetParamObj(map, prefix + "InternalAccount.", this.InternalAccount);
            this.SetParamObj(map, prefix + "Blacklist.", this.Blacklist);
            this.SetParamObj(map, prefix + "CDNResource.", this.CDNResource);
            this.SetParamObj(map, prefix + "EO.", this.EO);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

