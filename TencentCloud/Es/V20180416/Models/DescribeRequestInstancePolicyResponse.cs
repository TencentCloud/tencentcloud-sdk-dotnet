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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRequestInstancePolicyResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>GET路径可请求的命令合集</p>
        /// </summary>
        [JsonProperty("GetPaths")]
        public string[] GetPaths{ get; set; }

        /// <summary>
        /// <p>POST路径可请求的命令合集</p>
        /// </summary>
        [JsonProperty("PostPaths")]
        public string[] PostPaths{ get; set; }

        /// <summary>
        /// <p>PUT路径可请求的命令合集</p>
        /// </summary>
        [JsonProperty("PutPaths")]
        public string[] PutPaths{ get; set; }

        /// <summary>
        /// <p>是否是默认的参数</p>
        /// </summary>
        [JsonProperty("IsDefault")]
        public bool? IsDefault{ get; set; }

        /// <summary>
        /// <p>变更时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>变更人</p>
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

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
            this.SetParamArraySimple(map, prefix + "GetPaths.", this.GetPaths);
            this.SetParamArraySimple(map, prefix + "PostPaths.", this.PostPaths);
            this.SetParamArraySimple(map, prefix + "PutPaths.", this.PutPaths);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

