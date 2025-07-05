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

    public class CreateAssetRequest : AbstractModel
    {
        
        /// <summary>
        /// 生成包的ZIP包名，例如：server.zip
        /// </summary>
        [JsonProperty("BucketKey")]
        public string BucketKey{ get; set; }

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
        /// 生成包可运行的操作系统，若传入参数为CentOS7.16则不需要传入ImageId字段，否则，需要传入Imageid字段（该方式是为了兼容之前的版本，后续建议使用ImageId来替代该字段）。这里可通过[DescribeAssetSystems](https://cloud.tencent.com/document/product/1165/49191)接口获取asset支持的操作系统进行传入（使用AssetSupportSys的OsVersion字段）
        /// </summary>
        [JsonProperty("OperateSystem")]
        public string OperateSystem{ get; set; }

        /// <summary>
        /// 生成包支持的操作系统镜像id，若传入OperateSystem字段的值是CentOS7.16，则不需要传入该值；如果不是，则需要通过[DescribeAssetSystems](https://cloud.tencent.com/document/product/1165/49191)接口获取asset支持的操作系统ImageId进行传入
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// 标签列表，最大长度50组
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BucketKey", this.BucketKey);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "AssetVersion", this.AssetVersion);
            this.SetParamSimple(map, prefix + "AssetRegion", this.AssetRegion);
            this.SetParamSimple(map, prefix + "OperateSystem", this.OperateSystem);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

