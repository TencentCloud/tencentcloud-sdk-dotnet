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

    public class AgentSpaceDTO : AbstractModel
    {
        
        /// <summary>
        /// 工作空间名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

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
        /// 云主机登录名称
        /// </summary>
        [JsonProperty("RemoteUser")]
        public string RemoteUser{ get; set; }

        /// <summary>
        /// 云主机登录地址
        /// </summary>
        [JsonProperty("RemoteHost")]
        public string RemoteHost{ get; set; }

        /// <summary>
        /// 云主机登录端口
        /// </summary>
        [JsonProperty("RemotePort")]
        public string RemotePort{ get; set; }

        /// <summary>
        /// 工作空间类型
        /// </summary>
        [JsonProperty("WorkspaceType")]
        public string WorkspaceType{ get; set; }

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
        /// 描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamSimple(map, prefix + "ImageName", this.ImageName);
            this.SetParamSimple(map, prefix + "RemoteUser", this.RemoteUser);
            this.SetParamSimple(map, prefix + "RemoteHost", this.RemoteHost);
            this.SetParamSimple(map, prefix + "RemotePort", this.RemotePort);
            this.SetParamSimple(map, prefix + "WorkspaceType", this.WorkspaceType);
            this.SetParamSimple(map, prefix + "WorkspaceVersion", this.WorkspaceVersion);
            this.SetParamObj(map, prefix + "WorkspaceResourceDTO.", this.WorkspaceResourceDTO);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

