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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Blueprint : AbstractModel
    {
        
        /// <summary>
        /// 镜像 ID  ，是 Blueprint 的唯一标识。
        /// </summary>
        [JsonProperty("BlueprintId")]
        public string BlueprintId{ get; set; }

        /// <summary>
        /// 镜像对外展示标题。
        /// </summary>
        [JsonProperty("DisplayTitle")]
        public string DisplayTitle{ get; set; }

        /// <summary>
        /// 镜像对外展示版本。
        /// </summary>
        [JsonProperty("DisplayVersion")]
        public string DisplayVersion{ get; set; }

        /// <summary>
        /// 镜像描述信息。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 操作系统名称。
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// 操作系统平台。
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// 操作系统平台类型，如 LINUX_UNIX、WINDOWS。
        /// </summary>
        [JsonProperty("PlatformType")]
        public string PlatformType{ get; set; }

        /// <summary>
        /// 镜像类型，如 APP_OS、PURE_OS、PRIVATE。
        /// </summary>
        [JsonProperty("BlueprintType")]
        public string BlueprintType{ get; set; }

        /// <summary>
        /// 镜像图片 URL。
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 镜像所需系统盘大小，单位 GB。
        /// </summary>
        [JsonProperty("RequiredSystemDiskSize")]
        public long? RequiredSystemDiskSize{ get; set; }

        /// <summary>
        /// 镜像状态。
        /// </summary>
        [JsonProperty("BlueprintState")]
        public string BlueprintState{ get; set; }

        /// <summary>
        /// 创建时间。按照 ISO8601 标准表示，并且使用 UTC 时间。 
        /// 格式为： YYYY-MM-DDThh:mm:ssZ。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 镜像名称。
        /// </summary>
        [JsonProperty("BlueprintName")]
        public string BlueprintName{ get; set; }

        /// <summary>
        /// 镜像是否支持自动化助手。
        /// </summary>
        [JsonProperty("SupportAutomationTools")]
        public bool? SupportAutomationTools{ get; set; }

        /// <summary>
        /// 镜像所需内存大小, 单位: GB
        /// </summary>
        [JsonProperty("RequiredMemorySize")]
        public long? RequiredMemorySize{ get; set; }

        /// <summary>
        /// CVM镜像共享到轻量应用服务器轻量应用服务器后的CVM镜像ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BlueprintId", this.BlueprintId);
            this.SetParamSimple(map, prefix + "DisplayTitle", this.DisplayTitle);
            this.SetParamSimple(map, prefix + "DisplayVersion", this.DisplayVersion);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "PlatformType", this.PlatformType);
            this.SetParamSimple(map, prefix + "BlueprintType", this.BlueprintType);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "RequiredSystemDiskSize", this.RequiredSystemDiskSize);
            this.SetParamSimple(map, prefix + "BlueprintState", this.BlueprintState);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "BlueprintName", this.BlueprintName);
            this.SetParamSimple(map, prefix + "SupportAutomationTools", this.SupportAutomationTools);
            this.SetParamSimple(map, prefix + "RequiredMemorySize", this.RequiredMemorySize);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
        }
    }
}

