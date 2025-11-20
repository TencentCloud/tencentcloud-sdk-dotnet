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

namespace TencentCloud.Bh.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateUserDirectoryRequest : AbstractModel
    {
        
        /// <summary>
        /// 目录id
        /// </summary>
        [JsonProperty("DirId")]
        public ulong? DirId{ get; set; }

        /// <summary>
        /// 目录名称
        /// </summary>
        [JsonProperty("DirName")]
        public string DirName{ get; set; }

        /// <summary>
        /// ioa分组信息
        /// </summary>
        [JsonProperty("UserOrgSet")]
        public UserOrg[] UserOrgSet{ get; set; }

        /// <summary>
        /// ioa关联用户源类型
        /// </summary>
        [JsonProperty("Source")]
        public ulong? Source{ get; set; }

        /// <summary>
        /// ioa关联用户源名称
        /// </summary>
        [JsonProperty("SourceName")]
        public string SourceName{ get; set; }

        /// <summary>
        /// 目录包含用户数
        /// </summary>
        [JsonProperty("UserCount")]
        public ulong? UserCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DirId", this.DirId);
            this.SetParamSimple(map, prefix + "DirName", this.DirName);
            this.SetParamArrayObj(map, prefix + "UserOrgSet.", this.UserOrgSet);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "SourceName", this.SourceName);
            this.SetParamSimple(map, prefix + "UserCount", this.UserCount);
        }
    }
}

