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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Image : AbstractModel
    {
        
        /// <summary>
        /// 镜像ID
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// 镜像操作系统
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// 镜像类型。镜像类型返回值包括：
        /// * `PUBLIC_IMAGE` 公共镜像
        /// * `PRIVATE_IMAGE` 自定义镜像
        /// * `SHARED_IMAGE` 共享镜像
        /// </summary>
        [JsonProperty("ImageType")]
        public string ImageType{ get; set; }

        /// <summary>
        /// 镜像创建时间。
        /// 按照 ISO8601 标准表示，并且使用 UTC 时间，格式为：YYYY-MM-DDThh:mm:ssZ。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 镜像名称
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// 镜像描述
        /// </summary>
        [JsonProperty("ImageDescription")]
        public string ImageDescription{ get; set; }

        /// <summary>
        /// 镜像大小，单位 GiB。
        /// </summary>
        [JsonProperty("ImageSize")]
        public long? ImageSize{ get; set; }

        /// <summary>
        /// 镜像架构。镜像架构返回值包括：
        /// * `x86_64`
        /// * `arm`
        /// * `i386`
        /// </summary>
        [JsonProperty("Architecture")]
        public string Architecture{ get; set; }

        /// <summary>
        /// 镜像状态:
        /// CREATING-创建中
        /// NORMAL-正常
        /// CREATEFAILED-创建失败
        /// SYNCING-复制中
        /// IMPORTING-导入中
        /// IMPORTFAILED-导入失败
        /// </summary>
        [JsonProperty("ImageState")]
        public string ImageState{ get; set; }

        /// <summary>
        /// 镜像来源平台，包括如TencentOS、 CentOS、 Windows、 Ubuntu、 Debian、Fedora等。
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// 镜像创建者
        /// </summary>
        [JsonProperty("ImageCreator")]
        public string ImageCreator{ get; set; }

        /// <summary>
        /// 镜像来源。镜像来源返回值包括：
        /// * `OFFICIAL` 官方镜像
        /// * `CREATE_IMAGE` 用户自建镜像
        /// * `EXTERNAL_IMPORT` 用户外部导入镜像
        /// </summary>
        [JsonProperty("ImageSource")]
        public string ImageSource{ get; set; }

        /// <summary>
        /// 同步百分比
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SyncPercent")]
        public long? SyncPercent{ get; set; }

        /// <summary>
        /// 镜像是否支持cloud-init
        /// </summary>
        [JsonProperty("IsSupportCloudinit")]
        public bool? IsSupportCloudinit{ get; set; }

        /// <summary>
        /// 镜像关联的快照信息
        /// </summary>
        [JsonProperty("SnapshotSet")]
        public Snapshot[] SnapshotSet{ get; set; }

        /// <summary>
        /// 镜像关联的标签列表。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 镜像许可类型。镜像许可类型返回值包括：
        /// * `TencentCloud` 腾讯云官方许可
        /// * `BYOL` 用户自带许可
        /// </summary>
        [JsonProperty("LicenseType")]
        public string LicenseType{ get; set; }

        /// <summary>
        /// 镜像族
        /// </summary>
        [JsonProperty("ImageFamily")]
        public string ImageFamily{ get; set; }

        /// <summary>
        /// 镜像是否废弃
        /// </summary>
        [JsonProperty("ImageDeprecated")]
        public bool? ImageDeprecated{ get; set; }

        /// <summary>
        /// CDC镜像缓存状态
        /// </summary>
        [JsonProperty("CdcCacheStatus")]
        public string CdcCacheStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "ImageType", this.ImageType);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ImageDescription", this.ImageDescription);
            this.SetParamSimple(map, prefix + "ImageSize", this.ImageSize);
            this.SetParamSimple(map, prefix + "Architecture", this.Architecture);
            this.SetParamSimple(map, prefix + "ImageState", this.ImageState);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "ImageCreator", this.ImageCreator);
            this.SetParamSimple(map, prefix + "ImageSource", this.ImageSource);
            this.SetParamSimple(map, prefix + "SyncPercent", this.SyncPercent);
            this.SetParamSimple(map, prefix + "IsSupportCloudinit", this.IsSupportCloudinit);
            this.SetParamArrayObj(map, prefix + "SnapshotSet.", this.SnapshotSet);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "LicenseType", this.LicenseType);
            this.SetParamSimple(map, prefix + "ImageFamily", this.ImageFamily);
            this.SetParamSimple(map, prefix + "ImageDeprecated", this.ImageDeprecated);
            this.SetParamSimple(map, prefix + "CdcCacheStatus", this.CdcCacheStatus);
        }
    }
}

