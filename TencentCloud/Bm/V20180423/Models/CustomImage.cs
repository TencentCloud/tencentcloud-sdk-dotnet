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

namespace TencentCloud.Bm.V20180423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomImage : AbstractModel
    {
        
        /// <summary>
        /// 镜像ID
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// 镜像别名
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// 镜像状态码
        /// </summary>
        [JsonProperty("ImageStatus")]
        public ulong? ImageStatus{ get; set; }

        /// <summary>
        /// 镜像OS名
        /// </summary>
        [JsonProperty("OsClass")]
        public string OsClass{ get; set; }

        /// <summary>
        /// 镜像OS版本
        /// </summary>
        [JsonProperty("OsVersion")]
        public string OsVersion{ get; set; }

        /// <summary>
        /// OS是64还是32位
        /// </summary>
        [JsonProperty("OsBit")]
        public ulong? OsBit{ get; set; }

        /// <summary>
        /// 镜像大小(M)
        /// </summary>
        [JsonProperty("ImageSize")]
        public ulong? ImageSize{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 分区信息
        /// </summary>
        [JsonProperty("PartitionInfoSet")]
        public PartitionInfo[] PartitionInfoSet{ get; set; }

        /// <summary>
        /// 适用机型
        /// </summary>
        [JsonProperty("DeviceClassCode")]
        public string DeviceClassCode{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("ImageDescription")]
        public string ImageDescription{ get; set; }

        /// <summary>
        /// 原始镜像id
        /// </summary>
        [JsonProperty("OsTypeId")]
        public ulong? OsTypeId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ImageStatus", this.ImageStatus);
            this.SetParamSimple(map, prefix + "OsClass", this.OsClass);
            this.SetParamSimple(map, prefix + "OsVersion", this.OsVersion);
            this.SetParamSimple(map, prefix + "OsBit", this.OsBit);
            this.SetParamSimple(map, prefix + "ImageSize", this.ImageSize);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArrayObj(map, prefix + "PartitionInfoSet.", this.PartitionInfoSet);
            this.SetParamSimple(map, prefix + "DeviceClassCode", this.DeviceClassCode);
            this.SetParamSimple(map, prefix + "ImageDescription", this.ImageDescription);
            this.SetParamSimple(map, prefix + "OsTypeId", this.OsTypeId);
        }
    }
}

