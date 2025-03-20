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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OverviewBasicResourceUsage : AbstractModel
    {
        
        /// <summary>
        /// 应用总数
        /// </summary>
        [JsonProperty("ApplicationCount")]
        public long? ApplicationCount{ get; set; }

        /// <summary>
        /// 命名空间总数
        /// </summary>
        [JsonProperty("NamespaceCount")]
        public long? NamespaceCount{ get; set; }

        /// <summary>
        /// 部署组个数
        /// </summary>
        [JsonProperty("GroupCount")]
        public long? GroupCount{ get; set; }

        /// <summary>
        /// 程序包存储空间用量，单位字节
        /// </summary>
        [JsonProperty("PackageSpaceUsed")]
        public long? PackageSpaceUsed{ get; set; }

        /// <summary>
        /// 已注册实例数
        /// </summary>
        [JsonProperty("ConsulInstanceCount")]
        public long? ConsulInstanceCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationCount", this.ApplicationCount);
            this.SetParamSimple(map, prefix + "NamespaceCount", this.NamespaceCount);
            this.SetParamSimple(map, prefix + "GroupCount", this.GroupCount);
            this.SetParamSimple(map, prefix + "PackageSpaceUsed", this.PackageSpaceUsed);
            this.SetParamSimple(map, prefix + "ConsulInstanceCount", this.ConsulInstanceCount);
        }
    }
}

