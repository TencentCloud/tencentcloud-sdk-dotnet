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

namespace TencentCloud.Eis.V20210601.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuntimeDeployedInstanceMC : AbstractModel
    {
        
        /// <summary>
        /// 项目id
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 应用id
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// 应用实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public long? InstanceId{ get; set; }

        /// <summary>
        /// 应用实例版本
        /// </summary>
        [JsonProperty("InstanceVersion")]
        public long? InstanceVersion{ get; set; }

        /// <summary>
        /// 应用实例创建时间
        /// </summary>
        [JsonProperty("InstanceCreatedAt")]
        public long? InstanceCreatedAt{ get; set; }

        /// <summary>
        /// 应用实例部署状态. 0:running, 1:deleting
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 应用实例部署创建时间
        /// </summary>
        [JsonProperty("CreatedAt")]
        public long? CreatedAt{ get; set; }

        /// <summary>
        /// 应用实例部署更新时间
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public long? UpdatedAt{ get; set; }

        /// <summary>
        /// 应用类型：0:NormalApp普通应用 1:TemplateApp模板应用 2:LightApp轻应用 3:MicroConnTemplate微连接模板 4:MicroConnApp微连接应用
        /// </summary>
        [JsonProperty("ProjectType")]
        public long? ProjectType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceVersion", this.InstanceVersion);
            this.SetParamSimple(map, prefix + "InstanceCreatedAt", this.InstanceCreatedAt);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "ProjectType", this.ProjectType);
        }
    }
}

