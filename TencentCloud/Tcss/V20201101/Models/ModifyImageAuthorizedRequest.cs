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

    public class ModifyImageAuthorizedRequest : AbstractModel
    {
        
        /// <summary>
        /// 本地镜像是否全部授权的标识，优先权高于根据本地镜像ids授权。等于true时需UpdatedLocalImageCnt大于0。
        /// </summary>
        [JsonProperty("AllLocalImages")]
        public bool? AllLocalImages{ get; set; }

        /// <summary>
        /// 仓库镜像是否全部授权的标识，优先权高于根据镜像ids授权。等于true时需UpdatedRegistryImageCnt大于0。
        /// </summary>
        [JsonProperty("AllRegistryImages")]
        public bool? AllRegistryImages{ get; set; }

        /// <summary>
        /// 指定操作授权的本地镜像数量，判断优先权最高，实际多出的镜像随机忽略，实际不足的部分也忽略。
        /// </summary>
        [JsonProperty("UpdatedLocalImageCnt")]
        public ulong? UpdatedLocalImageCnt{ get; set; }

        /// <summary>
        /// 指定操作授权的仓库镜像数量，判断优先权最高，实际多出的镜像随机忽略，实际不足的部分也忽略；
        /// </summary>
        [JsonProperty("UpdatedRegistryImageCnt")]
        public ulong? UpdatedRegistryImageCnt{ get; set; }

        /// <summary>
        /// 根据满足条件的本地镜像授权,本地镜像来源；ASSETIMAGE:本地镜像列表；IMAGEALL:同步本地镜像；AllLocalImages为false且LocalImageIds为空和UpdatedLocalImageCnt大于0时，需要
        /// </summary>
        [JsonProperty("ImageSourceType")]
        public string ImageSourceType{ get; set; }

        /// <summary>
        /// 根据满足条件的本地镜像授权，AllLocalImages为false且LocalImageIds为空和UpdatedLocalImageCnt大于0时，需要。
        /// </summary>
        [JsonProperty("LocalImageFilter")]
        public AssetFilters[] LocalImageFilter{ get; set; }

        /// <summary>
        /// 根据满足条件的仓库镜像授权，AllRegistryImages为false且RegistryImageIds为空和UpdatedRegistryImageCnt大于0时，需要。
        /// </summary>
        [JsonProperty("RegistryImageFilter")]
        public AssetFilters[] RegistryImageFilter{ get; set; }

        /// <summary>
        /// 根据满足条件的镜像授权,同时排除的本地镜像。
        /// </summary>
        [JsonProperty("ExcludeLocalImageIds")]
        public string[] ExcludeLocalImageIds{ get; set; }

        /// <summary>
        /// 根据满足条件的镜像授权,同时排除的仓库镜像。
        /// </summary>
        [JsonProperty("ExcludeRegistryImageIds")]
        public string[] ExcludeRegistryImageIds{ get; set; }

        /// <summary>
        /// 根据本地镜像ids授权，优先权高于根据满足条件的镜像授权。AllLocalImages为false且LocalImageFilter为空和UpdatedLocalImageCnt大于0时，需要。
        /// </summary>
        [JsonProperty("LocalImageIds")]
        public string[] LocalImageIds{ get; set; }

        /// <summary>
        /// 根据仓库镜像Ids授权，优先权高于根据满足条件的镜像授。AllRegistryImages为false且RegistryImageFilter为空和UpdatedRegistryImageCnt大于0时，需要。
        /// </summary>
        [JsonProperty("RegistryImageIds")]
        public string[] RegistryImageIds{ get; set; }

        /// <summary>
        /// 是否仅最新的镜像；RegistryImageFilter不为空且UpdatedRegistryImageCnt大于0时仓库镜像需要。
        /// </summary>
        [JsonProperty("OnlyShowLatest")]
        public bool? OnlyShowLatest{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AllLocalImages", this.AllLocalImages);
            this.SetParamSimple(map, prefix + "AllRegistryImages", this.AllRegistryImages);
            this.SetParamSimple(map, prefix + "UpdatedLocalImageCnt", this.UpdatedLocalImageCnt);
            this.SetParamSimple(map, prefix + "UpdatedRegistryImageCnt", this.UpdatedRegistryImageCnt);
            this.SetParamSimple(map, prefix + "ImageSourceType", this.ImageSourceType);
            this.SetParamArrayObj(map, prefix + "LocalImageFilter.", this.LocalImageFilter);
            this.SetParamArrayObj(map, prefix + "RegistryImageFilter.", this.RegistryImageFilter);
            this.SetParamArraySimple(map, prefix + "ExcludeLocalImageIds.", this.ExcludeLocalImageIds);
            this.SetParamArraySimple(map, prefix + "ExcludeRegistryImageIds.", this.ExcludeRegistryImageIds);
            this.SetParamArraySimple(map, prefix + "LocalImageIds.", this.LocalImageIds);
            this.SetParamArraySimple(map, prefix + "RegistryImageIds.", this.RegistryImageIds);
            this.SetParamSimple(map, prefix + "OnlyShowLatest", this.OnlyShowLatest);
        }
    }
}

