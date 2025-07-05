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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VulAffectedImageInfo : AbstractModel
    {
        
        /// <summary>
        /// 镜像ID
        /// </summary>
        [JsonProperty("ImageID")]
        public string ImageID{ get; set; }

        /// <summary>
        /// 镜像名称
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// 关联的主机数(包含普通节点数和超级节点数)
        /// </summary>
        [JsonProperty("HostCount")]
        public long? HostCount{ get; set; }

        /// <summary>
        /// 关联的超级节点数
        /// </summary>
        [JsonProperty("SuperNodeCount")]
        public long? SuperNodeCount{ get; set; }

        /// <summary>
        /// 关联的容器数
        /// </summary>
        [JsonProperty("ContainerCount")]
        public long? ContainerCount{ get; set; }

        /// <summary>
        /// 组件列表
        /// </summary>
        [JsonProperty("ComponentList")]
        public VulAffectedImageComponentInfo[] ComponentList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageID", this.ImageID);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "HostCount", this.HostCount);
            this.SetParamSimple(map, prefix + "SuperNodeCount", this.SuperNodeCount);
            this.SetParamSimple(map, prefix + "ContainerCount", this.ContainerCount);
            this.SetParamArrayObj(map, prefix + "ComponentList.", this.ComponentList);
        }
    }
}

