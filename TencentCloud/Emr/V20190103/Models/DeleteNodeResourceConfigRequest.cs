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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteNodeResourceConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群实例Id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 节点配置Id
        /// </summary>
        [JsonProperty("ResourceConfigId")]
        public ulong? ResourceConfigId{ get; set; }

        /// <summary>
        /// 节点类型 CORE TASK ROUTER
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// 类型为ComputeResource和EMR以及默认，默认为EMR
        /// </summary>
        [JsonProperty("ResourceBaseType")]
        public string ResourceBaseType{ get; set; }

        /// <summary>
        /// 计算资源id
        /// </summary>
        [JsonProperty("ComputeResourceId")]
        public string ComputeResourceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ResourceConfigId", this.ResourceConfigId);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "ResourceBaseType", this.ResourceBaseType);
            this.SetParamSimple(map, prefix + "ComputeResourceId", this.ComputeResourceId);
        }
    }
}

