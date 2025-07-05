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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeClusterInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 云盘版实例的读写地址信息。
        /// </summary>
        [JsonProperty("ReadWriteAddress")]
        public AddressInfo ReadWriteAddress{ get; set; }

        /// <summary>
        /// 云盘版实例的只读地址信息。
        /// </summary>
        [JsonProperty("ReadOnlyAddress")]
        public AddressInfo[] ReadOnlyAddress{ get; set; }

        /// <summary>
        /// 云盘版实例的节点列表信息。
        /// </summary>
        [JsonProperty("NodeList")]
        public ClusterNodeInfo[] NodeList{ get; set; }

        /// <summary>
        /// 只读空间保护阈值,单位GB
        /// </summary>
        [JsonProperty("ReadonlyLimit")]
        public long? ReadonlyLimit{ get; set; }

        /// <summary>
        /// 实例节点数。
        /// </summary>
        [JsonProperty("NodeCount")]
        public long? NodeCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamObj(map, prefix + "ReadWriteAddress.", this.ReadWriteAddress);
            this.SetParamArrayObj(map, prefix + "ReadOnlyAddress.", this.ReadOnlyAddress);
            this.SetParamArrayObj(map, prefix + "NodeList.", this.NodeList);
            this.SetParamSimple(map, prefix + "ReadonlyLimit", this.ReadonlyLimit);
            this.SetParamSimple(map, prefix + "NodeCount", this.NodeCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

