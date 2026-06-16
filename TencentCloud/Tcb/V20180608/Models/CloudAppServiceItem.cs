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

    public class CloudAppServiceItem : AbstractModel
    {
        
        /// <summary>
        /// 服务名
        /// </summary>
        [JsonProperty("ServiceName")]
        public string ServiceName{ get; set; }

        /// <summary>
        /// 框架名
        /// </summary>
        [JsonProperty("Framework")]
        public string Framework{ get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 应用路径
        /// </summary>
        [JsonProperty("AppPath")]
        public string AppPath{ get; set; }

        /// <summary>
        /// 服务创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 最新版本名
        /// </summary>
        [JsonProperty("LatestVersionName")]
        public string LatestVersionName{ get; set; }

        /// <summary>
        /// 最新版本状态
        /// </summary>
        [JsonProperty("LatestStatus")]
        public string LatestStatus{ get; set; }

        /// <summary>
        /// 最新版本构建时间
        /// </summary>
        [JsonProperty("LatestBuildTime")]
        public string LatestBuildTime{ get; set; }

        /// <summary>
        /// 部署类型
        /// </summary>
        [JsonProperty("DeployType")]
        public string DeployType{ get; set; }


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
        }
    }
}

