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
        /// 注意：此字段可能返回 null，表示取不到有效值。
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
        /// 镜像类型，如 APP_OS（应用镜像）, PURE_OS（系统镜像）, DOCKER（容器）, PRIVATE（私有镜像）, SHARED（共享镜像）, GAME_PORTAL（游戏专区镜像）。
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
        /// 镜像状态，镜镜像状态，NORMAL（正常）、SYNCING（同步中）、OFFLINE（下线）、ISOLATED（已隔离）、CREATEFAILED（创建失败）、SYNCING_FAILED（目的地域同步失败）、ISOLATING（隔离中）、ISOLATED（已隔离）、DELETING（删除中）、DESTROYING（销毁中）。
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
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// 官方网站Url。
        /// </summary>
        [JsonProperty("CommunityUrl")]
        public string CommunityUrl{ get; set; }

        /// <summary>
        /// 指导文章Url。
        /// </summary>
        [JsonProperty("GuideUrl")]
        public string GuideUrl{ get; set; }

        /// <summary>
        /// 镜像关联使用场景Id列表。
        /// </summary>
        [JsonProperty("SceneIdSet")]
        public string[] SceneIdSet{ get; set; }

        /// <summary>
        /// Docker版本号。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DockerVersion")]
        public string DockerVersion{ get; set; }

        /// <summary>
        /// 镜像是否已共享。
        /// </summary>
        [JsonProperty("BlueprintShared")]
        public bool? BlueprintShared{ get; set; }


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
            this.SetParamSimple(map, prefix + "CommunityUrl", this.CommunityUrl);
            this.SetParamSimple(map, prefix + "GuideUrl", this.GuideUrl);
            this.SetParamArraySimple(map, prefix + "SceneIdSet.", this.SceneIdSet);
            this.SetParamSimple(map, prefix + "DockerVersion", this.DockerVersion);
            this.SetParamSimple(map, prefix + "BlueprintShared", this.BlueprintShared);
        }
    }
}

