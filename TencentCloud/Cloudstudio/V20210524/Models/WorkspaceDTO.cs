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

namespace TencentCloud.Cloudstudio.V20210524.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WorkspaceDTO : AbstractModel
    {
        
        /// <summary>
        /// 工作空间名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 代码来源类型
        /// </summary>
        [JsonProperty("VersionControlType")]
        public string VersionControlType{ get; set; }

        /// <summary>
        /// 镜像id
        /// </summary>
        [JsonProperty("ImageId")]
        public long? ImageId{ get; set; }

        /// <summary>
        /// 镜像名称
        /// </summary>
        [JsonProperty("ImageName")]
        public string ImageName{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 工作空间版本
        /// </summary>
        [JsonProperty("WorkspaceVersion")]
        public long? WorkspaceVersion{ get; set; }

        /// <summary>
        /// 工作空间资源结构
        /// </summary>
        [JsonProperty("WorkspaceResourceDTO")]
        public WorkspaceResourceDTO WorkspaceResourceDTO{ get; set; }

        /// <summary>
        /// 代码仓库地址
        /// </summary>
        [JsonProperty("VersionControlUrl")]
        public string VersionControlUrl{ get; set; }

        /// <summary>
        /// 代码Ref是分支还是标签
        /// </summary>
        [JsonProperty("VersionControlRef")]
        public string VersionControlRef{ get; set; }

        /// <summary>
        /// 代码Ref地址
        /// </summary>
        [JsonProperty("VersionControlRefType")]
        public string VersionControlRefType{ get; set; }

        /// <summary>
        /// 快照Uid
        /// </summary>
        [JsonProperty("SnapshotUid")]
        public string SnapshotUid{ get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [JsonProperty("TemplateId")]
        public long? TemplateId{ get; set; }

        /// <summary>
        /// 价格id
        /// </summary>
        [JsonProperty("PriceId")]
        public long? PriceId{ get; set; }

        /// <summary>
        /// 初始化状态
        /// </summary>
        [JsonProperty("InitializeStatus")]
        public long? InitializeStatus{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("VersionControlDesc")]
        public string VersionControlDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "VersionControlType", this.VersionControlType);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "WorkspaceVersion", this.WorkspaceVersion);
            this.SetParamObj(map, prefix + "WorkspaceResourceDTO.", this.WorkspaceResourceDTO);
            this.SetParamSimple(map, prefix + "VersionControlUrl", this.VersionControlUrl);
            this.SetParamSimple(map, prefix + "VersionControlRef", this.VersionControlRef);
            this.SetParamSimple(map, prefix + "VersionControlRefType", this.VersionControlRefType);
            this.SetParamSimple(map, prefix + "SnapshotUid", this.SnapshotUid);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "PriceId", this.PriceId);
            this.SetParamSimple(map, prefix + "InitializeStatus", this.InitializeStatus);
            this.SetParamSimple(map, prefix + "VersionControlDesc", this.VersionControlDesc);
        }
    }
}

