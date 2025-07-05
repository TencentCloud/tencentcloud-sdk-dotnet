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

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAssetWithImageRequest : AbstractModel
    {
        
        /// <summary>
        /// 生成包名字，最小长度为1，最大长度为64
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// 生成包版本，最小长度为1，最大长度为64
        /// </summary>
        [JsonProperty("AssetVersion")]
        public string AssetVersion{ get; set; }

        /// <summary>
        /// 生成包所在地域，详见产品支持的 [地域列表](https://cloud.tencent.com/document/api/1165/42053#.E5.9C.B0.E5.9F.9F.E5.88.97.E8.A1.A8)
        /// </summary>
        [JsonProperty("AssetRegion")]
        public string AssetRegion{ get; set; }

        /// <summary>
        /// 生成包支持的操作系统镜像id
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// 操作系统镜像包大小，比如：40GB，支持单位 KB、MB、GB
        /// </summary>
        [JsonProperty("ImageSize")]
        public string ImageSize{ get; set; }

        /// <summary>
        /// 操作系统镜像包名称，最小长度为1，最大长度为64
        /// </summary>
        [JsonProperty("ImageOs")]
        public string ImageOs{ get; set; }

        /// <summary>
        /// 操作系统镜像包类型，CentOS 或者 Windows
        /// </summary>
        [JsonProperty("OsType")]
        public string OsType{ get; set; }

        /// <summary>
        /// 操作系统镜像包类型，当前只支持 SHARED_IMAGE
        /// </summary>
        [JsonProperty("ImageType")]
        public string ImageType{ get; set; }

        /// <summary>
        /// 操作系统镜像包位数，32 或者 64
        /// </summary>
        [JsonProperty("OsBit")]
        public ulong? OsBit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "AssetVersion", this.AssetVersion);
            this.SetParamSimple(map, prefix + "AssetRegion", this.AssetRegion);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "ImageSize", this.ImageSize);
            this.SetParamSimple(map, prefix + "ImageOs", this.ImageOs);
            this.SetParamSimple(map, prefix + "OsType", this.OsType);
            this.SetParamSimple(map, prefix + "ImageType", this.ImageType);
            this.SetParamSimple(map, prefix + "OsBit", this.OsBit);
        }
    }
}

