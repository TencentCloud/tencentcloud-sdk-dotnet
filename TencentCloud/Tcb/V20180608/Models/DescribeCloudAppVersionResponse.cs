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

    public class DescribeCloudAppVersionResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>构建类型</p>
        /// </summary>
        [JsonProperty("BuildType")]
        public string BuildType{ get; set; }

        /// <summary>
        /// <p>构建Id</p>
        /// </summary>
        [JsonProperty("BuildId")]
        public string BuildId{ get; set; }

        /// <summary>
        /// <p>构建状态</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>框架</p>
        /// </summary>
        [JsonProperty("Framework")]
        public string Framework{ get; set; }

        /// <summary>
        /// <p>静态托管配置信息</p>
        /// </summary>
        [JsonProperty("StaticConfig")]
        public StaticConfig StaticConfig{ get; set; }

        /// <summary>
        /// <p>构建时间</p>
        /// </summary>
        [JsonProperty("BuildTime")]
        public string BuildTime{ get; set; }

        /// <summary>
        /// <p>[]BuildStepStatus 的 JSON 序列化</p>
        /// </summary>
        [JsonProperty("Steps")]
        public BuildStepStatus[] Steps{ get; set; }

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
            this.SetParamSimple(map, prefix + "BuildType", this.BuildType);
            this.SetParamSimple(map, prefix + "BuildId", this.BuildId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Framework", this.Framework);
            this.SetParamObj(map, prefix + "StaticConfig.", this.StaticConfig);
            this.SetParamSimple(map, prefix + "BuildTime", this.BuildTime);
            this.SetParamArrayObj(map, prefix + "Steps.", this.Steps);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

