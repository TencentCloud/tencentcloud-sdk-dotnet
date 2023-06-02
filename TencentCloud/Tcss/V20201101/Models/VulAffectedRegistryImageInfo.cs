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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VulAffectedRegistryImageInfo : AbstractModel
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
        /// 镜像版本
        /// </summary>
        [JsonProperty("ImageTag")]
        public string ImageTag{ get; set; }

        /// <summary>
        /// 镜像命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 镜像地址
        /// </summary>
        [JsonProperty("ImageRepoAddress")]
        public string ImageRepoAddress{ get; set; }

        /// <summary>
        /// 组件列表
        /// </summary>
        [JsonProperty("ComponentList")]
        public VulAffectedImageComponentInfo[] ComponentList{ get; set; }

        /// <summary>
        /// 是否为镜像的最新版本
        /// </summary>
        [JsonProperty("IsLatestImage")]
        public bool? IsLatestImage{ get; set; }

        /// <summary>
        /// 内部镜像资产ID
        /// </summary>
        [JsonProperty("ImageAssetId")]
        public long? ImageAssetId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageID", this.ImageID);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ImageTag", this.ImageTag);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "ImageRepoAddress", this.ImageRepoAddress);
            this.SetParamArrayObj(map, prefix + "ComponentList.", this.ComponentList);
            this.SetParamSimple(map, prefix + "IsLatestImage", this.IsLatestImage);
            this.SetParamSimple(map, prefix + "ImageAssetId", this.ImageAssetId);
        }
    }
}

