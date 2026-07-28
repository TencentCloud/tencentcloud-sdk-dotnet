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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProxyGroupInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>Proxy 实例 ID，格式形如：proxygroup-xxxxxxxx</p>
        /// </summary>
        [JsonProperty("ProxyGroupId")]
        public string ProxyGroupId{ get; set; }

        /// <summary>
        /// <p>Proxy 状态：running/isolated/offline 等</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>Proxy 任务状态，无任务时为空</p>
        /// </summary>
        [JsonProperty("TaskStatus")]
        public string TaskStatus{ get; set; }

        /// <summary>
        /// <p>Proxy 描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>Proxy 内核版本号</p>
        /// </summary>
        [JsonProperty("ProxyVersion")]
        public string ProxyVersion{ get; set; }

        /// <summary>
        /// <p>连接池阈值（连接数）</p>
        /// </summary>
        [JsonProperty("ConnectionPoolLimit")]
        public long? ConnectionPoolLimit{ get; set; }

        /// <summary>
        /// <p>Proxy 节点列表</p>
        /// </summary>
        [JsonProperty("ProxyNodeSet")]
        public ProxyNode[] ProxyNodeSet{ get; set; }

        /// <summary>
        /// <p>Proxy 接入地址列表</p>
        /// </summary>
        [JsonProperty("ProxyAddressSet")]
        public ProxyAddress[] ProxyAddressSet{ get; set; }

        /// <summary>
        /// <p>创建时间，格式：YYYY-MM-DD HH:MM:SS</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProxyGroupId", this.ProxyGroupId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ProxyVersion", this.ProxyVersion);
            this.SetParamSimple(map, prefix + "ConnectionPoolLimit", this.ConnectionPoolLimit);
            this.SetParamArrayObj(map, prefix + "ProxyNodeSet.", this.ProxyNodeSet);
            this.SetParamArrayObj(map, prefix + "ProxyAddressSet.", this.ProxyAddressSet);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

