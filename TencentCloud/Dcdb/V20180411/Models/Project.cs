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

namespace TencentCloud.Dcdb.V20180411.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Project : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 资源拥有者（主账号）uin
        /// </summary>
        [JsonProperty("OwnerUin")]
        public long? OwnerUin{ get; set; }

        /// <summary>
        /// 应用Id
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 创建者uin
        /// </summary>
        [JsonProperty("CreatorUin")]
        public long? CreatorUin{ get; set; }

        /// <summary>
        /// 来源平台
        /// </summary>
        [JsonProperty("SrcPlat")]
        public string SrcPlat{ get; set; }

        /// <summary>
        /// 来源AppId
        /// </summary>
        [JsonProperty("SrcAppId")]
        public long? SrcAppId{ get; set; }

        /// <summary>
        /// 项目状态,0正常，-1关闭。默认项目为3
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 是否默认项目，1 是，0 不是
        /// </summary>
        [JsonProperty("IsDefault")]
        public long? IsDefault{ get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonProperty("Info")]
        public string Info{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CreatorUin", this.CreatorUin);
            this.SetParamSimple(map, prefix + "SrcPlat", this.SrcPlat);
            this.SetParamSimple(map, prefix + "SrcAppId", this.SrcAppId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamSimple(map, prefix + "Info", this.Info);
        }
    }
}

