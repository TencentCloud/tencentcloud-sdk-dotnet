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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProjectInfo : AbstractModel
    {
        
        /// <summary>
        /// 项目名称。
        /// </summary>
        [JsonProperty("ProjectName")]
        public string ProjectName{ get; set; }

        /// <summary>
        /// 项目创建用户 UIN。
        /// </summary>
        [JsonProperty("ProjectCreatorUin")]
        public ulong? ProjectCreatorUin{ get; set; }

        /// <summary>
        /// 项目创建时间。
        /// </summary>
        [JsonProperty("ProjectCreateTime")]
        public string ProjectCreateTime{ get; set; }

        /// <summary>
        /// 项目信息简述。
        /// </summary>
        [JsonProperty("ProjectResume")]
        public string ProjectResume{ get; set; }

        /// <summary>
        /// 用户 UIN。
        /// </summary>
        [JsonProperty("OwnerUin")]
        public ulong? OwnerUin{ get; set; }

        /// <summary>
        /// 项目 ID。
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectName", this.ProjectName);
            this.SetParamSimple(map, prefix + "ProjectCreatorUin", this.ProjectCreatorUin);
            this.SetParamSimple(map, prefix + "ProjectCreateTime", this.ProjectCreateTime);
            this.SetParamSimple(map, prefix + "ProjectResume", this.ProjectResume);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
        }
    }
}

