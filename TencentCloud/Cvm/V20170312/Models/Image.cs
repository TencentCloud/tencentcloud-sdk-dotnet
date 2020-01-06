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
        /// 镜像类型
        /// </summary>
        [JsonProperty("ImageType")]
        public string ImageType{ get; set; }

        /// <summary>
        /// 镜像创建时间
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
        /// 镜像大小
        /// </summary>
        [JsonProperty("ImageSize")]
        public long? ImageSize{ get; set; }

        /// <summary>
        /// 镜像架构
        /// </summary>
        [JsonProperty("Architecture")]
        public string Architecture{ get; set; }

        /// <summary>
        /// 镜像状态:
        /// CREATING-创建中
        /// NORMAL-正常
        /// CREATEFAILED-创建失败
        /// USING-使用中
        /// SYNCING-同步中
        /// IMPORTING-导入中
        /// IMPORTFAILED-导入失败
        /// </summary>
        [JsonProperty("ImageState")]
        public string ImageState{ get; set; }

        /// <summary>
        /// 镜像来源平台
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// 镜像创建者
        /// </summary>
        [JsonProperty("ImageCreator")]
        public string ImageCreator{ get; set; }

        /// <summary>
        /// 镜像来源
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
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsSupportCloudinit")]
        public bool? IsSupportCloudinit{ get; set; }

        /// <summary>
        /// 镜像关联的快照信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SnapshotSet")]
        public Snapshot[] SnapshotSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
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
        }
    }
}

