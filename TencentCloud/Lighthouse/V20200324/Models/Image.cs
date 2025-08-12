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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Image : AbstractModel
    {
        
        /// <summary>
        /// CVM镜像 ID ，是Image的唯一标识。
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// 镜像名称。
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// 镜像描述。
        /// </summary>
        [JsonProperty("ImageDescription")]
        public string ImageDescription{ get; set; }

        /// <summary>
        /// 镜像大小。单位GB。
        /// </summary>
        [JsonProperty("ImageSize")]
        public long? ImageSize{ get; set; }

        /// <summary>
        /// 镜像来源。
        /// <li>CREATE_IMAGE：自定义镜像</li>
        /// <li>EXTERNAL_IMPORT：外部导入镜像</li>
        /// </summary>
        [JsonProperty("ImageSource")]
        public string ImageSource{ get; set; }

        /// <summary>
        /// 镜像分类
        /// <li>SystemImage：系统盘镜像</li>
        /// <li>InstanceImage：整机镜像</li>
        /// </summary>
        [JsonProperty("ImageClass")]
        public string ImageClass{ get; set; }

        /// <summary>
        /// 镜像状态
        /// CREATING:创建中
        /// NORMAL:正常
        /// CREATEFAILED:创建失败
        /// USING:使用中
        /// SYNCING:同步中
        /// IMPORTING:导入中
        /// IMPORTFAILED:导入失败
        /// </summary>
        [JsonProperty("ImageState")]
        public string ImageState{ get; set; }

        /// <summary>
        /// 镜像是否支持Cloudinit。
        /// </summary>
        [JsonProperty("IsSupportCloudinit")]
        public bool? IsSupportCloudinit{ get; set; }

        /// <summary>
        /// 镜像架构。
        /// </summary>
        [JsonProperty("Architecture")]
        public string Architecture{ get; set; }

        /// <summary>
        /// 镜像操作系统。
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// 镜像来源平台。
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// 镜像创建时间。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 镜像是否可共享到轻量应用服务器。
        /// </summary>
        [JsonProperty("IsShareable")]
        public bool? IsShareable{ get; set; }

        /// <summary>
        /// 不可共享的原因。
        /// </summary>
        [JsonProperty("UnshareableReason")]
        public string UnshareableReason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "ImageDescription", this.ImageDescription);
            this.SetParamSimple(map, prefix + "ImageSize", this.ImageSize);
            this.SetParamSimple(map, prefix + "ImageSource", this.ImageSource);
            this.SetParamSimple(map, prefix + "ImageClass", this.ImageClass);
            this.SetParamSimple(map, prefix + "ImageState", this.ImageState);
            this.SetParamSimple(map, prefix + "IsSupportCloudinit", this.IsSupportCloudinit);
            this.SetParamSimple(map, prefix + "Architecture", this.Architecture);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "IsShareable", this.IsShareable);
            this.SetParamSimple(map, prefix + "UnshareableReason", this.UnshareableReason);
        }
    }
}

