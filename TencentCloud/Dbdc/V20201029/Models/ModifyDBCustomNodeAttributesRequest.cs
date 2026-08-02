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

namespace TencentCloud.Dbdc.V20201029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBCustomNodeAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>节点ID</p><p>参数格式：dbcn-hq98qjym</p>
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

        /// <summary>
        /// <p>主机 HostName</p><p>入参限制：参数设置规则参见：<a href="https://cloud.tencent.com/document/api/1322/132929">创建 DB Custom 节点接口</a>的 HostName 参数说明。</p><p>注意：节点在没有加入到集群之前才支持修改主机 HostName。</p>
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// <p>节点名称</p><p>入参限制：参数设置规则参见：<a href="https://cloud.tencent.com/document/api/1322/132929">创建 DB Custom 节点接口</a>的 NodeName 参数说明。</p>
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// <p>修改实例 HostName 是否自动重启实例，不传默认自动重启。</p><p>枚举值：</p><ul><li>true： 修改主机 HostName，并自动重启主机</li><li>false： 修改主机 HostName，不自动重启主机，需要手动重启使新主机 HostName 生效</li></ul><p>默认值：true</p>
        /// </summary>
        [JsonProperty("AutoReboot")]
        public bool? AutoReboot{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "AutoReboot", this.AutoReboot);
        }
    }
}

