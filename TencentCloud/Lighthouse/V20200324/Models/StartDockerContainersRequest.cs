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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StartDockerContainersRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID。可通过[DescribeInstances](https://cloud.tencent.com/document/product/1207/47573)接口返回值中的InstanceId获取。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 容器ID列表。可通过[DescribeDockerContainers](https://cloud.tencent.com/document/product/1207/95473)接口返回值中的ContainerId获取。
        /// </summary>
        [JsonProperty("ContainerIds")]
        public string[] ContainerIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "ContainerIds.", this.ContainerIds);
        }
    }
}

