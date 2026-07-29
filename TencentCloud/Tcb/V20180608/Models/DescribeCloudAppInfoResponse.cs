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

    public class DescribeCloudAppInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>服务名称</p>
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// <p>框架名称</p>
        /// </summary>
        [JsonProperty("Framework")]
        public string Framework{ get; set; }

        /// <summary>
        /// <p>域名</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>构建路径</p>
        /// </summary>
        [JsonProperty("AppPath")]
        public string AppPath{ get; set; }

        /// <summary>
        /// <p>服务创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>最新版本名</p>
        /// </summary>
        [JsonProperty("LatestVersionName")]
        public string LatestVersionName{ get; set; }

        /// <summary>
        /// <p>最新版本状态</p>
        /// </summary>
        [JsonProperty("LatestStatus")]
        public string LatestStatus{ get; set; }

        /// <summary>
        /// <p>最新版本构建时间</p>
        /// </summary>
        [JsonProperty("LatestBuildTime")]
        public string LatestBuildTime{ get; set; }

        /// <summary>
        /// <p>部署类型</p>
        /// </summary>
        [JsonProperty("DeployType")]
        public string DeployType{ get; set; }

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
            this.SetParamSimple(map, prefix + "ServiceName", this.ServiceName);
            this.SetParamSimple(map, prefix + "Framework", this.Framework);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "AppPath", this.AppPath);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "LatestVersionName", this.LatestVersionName);
            this.SetParamSimple(map, prefix + "LatestStatus", this.LatestStatus);
            this.SetParamSimple(map, prefix + "LatestBuildTime", this.LatestBuildTime);
            this.SetParamSimple(map, prefix + "DeployType", this.DeployType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

