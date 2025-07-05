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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateEKSContainerInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 容器实例 ID
        /// </summary>
        [JsonProperty("EksCiId")]
        public string EksCiId{ get; set; }

        /// <summary>
        /// 实例重启策略： Always(总是重启)、Never(从不重启)、OnFailure(失败时重启)
        /// </summary>
        [JsonProperty("RestartPolicy")]
        public string RestartPolicy{ get; set; }

        /// <summary>
        /// 数据卷，包含NfsVolume数组和CbsVolume数组
        /// </summary>
        [JsonProperty("EksCiVolume")]
        public EksCiVolume EksCiVolume{ get; set; }

        /// <summary>
        /// 容器组
        /// </summary>
        [JsonProperty("Containers")]
        public Container[] Containers{ get; set; }

        /// <summary>
        /// Init 容器组
        /// </summary>
        [JsonProperty("InitContainers")]
        public Container[] InitContainers{ get; set; }

        /// <summary>
        /// 容器实例名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 镜像仓库凭证数组
        /// </summary>
        [JsonProperty("ImageRegistryCredentials")]
        public ImageRegistryCredential[] ImageRegistryCredentials{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EksCiId", this.EksCiId);
            this.SetParamSimple(map, prefix + "RestartPolicy", this.RestartPolicy);
            this.SetParamObj(map, prefix + "EksCiVolume.", this.EksCiVolume);
            this.SetParamArrayObj(map, prefix + "Containers.", this.Containers);
            this.SetParamArrayObj(map, prefix + "InitContainers.", this.InitContainers);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "ImageRegistryCredentials.", this.ImageRegistryCredentials);
        }
    }
}

