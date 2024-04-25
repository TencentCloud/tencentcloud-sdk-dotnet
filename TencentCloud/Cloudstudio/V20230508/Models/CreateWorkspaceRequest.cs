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

namespace TencentCloud.Cloudstudio.V20230508.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateWorkspaceRequest : AbstractModel
    {
        
        /// <summary>
        /// 工作空间名称, 长度限制 2~64
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 工作空间描述, 长度限制 0~255
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 工作空间规格。Standard: 2C4G, Calculation: 4C8G, Profession: 8C16G. 默认是 Standard。
        /// </summary>
        [JsonProperty("Specs")]
        public string Specs{ get; set; }

        /// <summary>
        /// 工作空间基础镜像名称, 默认会使用 All In One 镜像, 长度限制 1~255
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// Git 仓库. 工作空间启动时会自动克隆该仓库
        /// </summary>
        [JsonProperty("Repository")]
        public GitRepository Repository{ get; set; }

        /// <summary>
        /// 环境变量. 会被注入到工作空间中
        /// </summary>
        [JsonProperty("Envs")]
        public Env[] Envs{ get; set; }

        /// <summary>
        /// 预装插件. 工作空间启动时, 会自动安装这些插件。长度限制: 0~10
        /// </summary>
        [JsonProperty("Extensions")]
        public string[] Extensions{ get; set; }

        /// <summary>
        /// 工作空间生命周期钩子.  分为三个阶段 init, start, destroy. 分别表示工作空间数据初始化阶段, 工作空间启动阶段, 工作空间关闭阶段.  用户可以自定义 shell 命令. 
        /// </summary>
        [JsonProperty("Lifecycle")]
        public LifeCycle Lifecycle{ get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("TenantAppId")]
        public long? TenantAppId{ get; set; }

        /// <summary>
        /// 用户UIN
        /// </summary>
        [JsonProperty("TenantUin")]
        public string TenantUin{ get; set; }

        /// <summary>
        /// VPCID
        /// </summary>
        [JsonProperty("TenantUniqVpcId")]
        public string TenantUniqVpcId{ get; set; }

        /// <summary>
        /// 子网ID
        /// </summary>
        [JsonProperty("TenantSubnetId")]
        public string TenantSubnetId{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Specs", this.Specs);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamObj(map, prefix + "Repository.", this.Repository);
            this.SetParamArrayObj(map, prefix + "Envs.", this.Envs);
            this.SetParamArraySimple(map, prefix + "Extensions.", this.Extensions);
            this.SetParamObj(map, prefix + "Lifecycle.", this.Lifecycle);
            this.SetParamSimple(map, prefix + "TenantAppId", this.TenantAppId);
            this.SetParamSimple(map, prefix + "TenantUin", this.TenantUin);
            this.SetParamSimple(map, prefix + "TenantUniqVpcId", this.TenantUniqVpcId);
            this.SetParamSimple(map, prefix + "TenantSubnetId", this.TenantSubnetId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
        }
    }
}

