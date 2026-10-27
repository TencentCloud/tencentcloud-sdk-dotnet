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

namespace TencentCloud.Cvd.V20201104.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImageInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>镜像id</p>
        /// </summary>
        [JsonProperty("ImageID")]
        public string ImageID{ get; set; }

        /// <summary>
        /// <p>镜像名称</p>
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// <p>镜像类型：<br>PUBLIC_IMAGE-公共镜像<br>PRIVATE_IMAGE-自定义镜像<br>TENCENT_OFFICE_IMAGE-腾讯办公镜像</p>
        /// </summary>
        [JsonProperty("ImageType")]
        public string ImageType{ get; set; }

        /// <summary>
        /// <p>镜像状态：<br>CREATING-创建中<br>NORMAL-正常<br>CREATEFAILED-创建失败<br>USING-使用中<br>SYNCING-同步中<br>IMPORTING-导入中<br>IMPORTFAILED-导入失败<br>INVISIBLE-淘汰的镜像<br>DELETIING-删除中<br>DELETED-删除的</p>
        /// </summary>
        [JsonProperty("ImageState")]
        public string ImageState{ get; set; }

        /// <summary>
        /// <p>镜像操作系统</p>
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// <p>镜像大小（单位G）</p>
        /// </summary>
        [JsonProperty("ImageSize")]
        public long? ImageSize{ get; set; }

        /// <summary>
        /// <p>镜像描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>镜像所在区域</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>内核类型：<br>CPU<br>GPU<br>GPU_A10<br>GPU_RTX6000<br>GPU_2080Ti<br>GPU_3080Ti</p>
        /// </summary>
        [JsonProperty("CoreType")]
        public string CoreType{ get; set; }

        /// <summary>
        /// <p>cvm侧镜像id</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CvmImageId")]
        public string CvmImageId{ get; set; }

        /// <summary>
        /// <p>是否是整机镜像，整机镜像无法用于桌面重置<br>true：整机镜像<br>false: 不是整机镜像</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsWhole")]
        public bool? IsWhole{ get; set; }

        /// <summary>
        /// <p>整机镜像中数据盘大小</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataDiskSize")]
        public long? DataDiskSize{ get; set; }

        /// <summary>
        /// <p>镜像创建时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageID", this.ImageID);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ImageType", this.ImageType);
            this.SetParamSimple(map, prefix + "ImageState", this.ImageState);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "ImageSize", this.ImageSize);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "CoreType", this.CoreType);
            this.SetParamSimple(map, prefix + "CvmImageId", this.CvmImageId);
            this.SetParamSimple(map, prefix + "IsWhole", this.IsWhole);
            this.SetParamSimple(map, prefix + "DataDiskSize", this.DataDiskSize);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

