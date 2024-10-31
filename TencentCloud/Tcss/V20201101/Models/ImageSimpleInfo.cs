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

    public class ImageSimpleInfo : AbstractModel
    {
        
        /// <summary>
        /// 镜像id
        /// </summary>
        [JsonProperty("ImageID")]
        public string ImageID{ get; set; }

        /// <summary>
        /// 镜像名称
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// 镜像大小
        /// </summary>
        [JsonProperty("Size")]
        public ulong? Size{ get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("ImageType")]
        public string ImageType{ get; set; }

        /// <summary>
        /// 关联容器数
        /// </summary>
        [JsonProperty("ContainerCnt")]
        public long? ContainerCnt{ get; set; }

        /// <summary>
        /// 关联主机数
        /// </summary>
        [JsonProperty("HostCnt")]
        public ulong? HostCnt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageID", this.ImageID);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "ImageType", this.ImageType);
            this.SetParamSimple(map, prefix + "ContainerCnt", this.ContainerCnt);
            this.SetParamSimple(map, prefix + "HostCnt", this.HostCnt);
        }
    }
}

