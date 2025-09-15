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

namespace TencentCloud.Lowcode.V20210108.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OrgResp : AbstractModel
    {
        
        /// <summary>
        /// 部门id
        /// </summary>
        [JsonProperty("OrgId")]
        public string OrgId{ get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        [JsonProperty("OrgName")]
        public string OrgName{ get; set; }

        /// <summary>
        /// 部门标识
        /// </summary>
        [JsonProperty("OrgIdentity")]
        public string OrgIdentity{ get; set; }

        /// <summary>
        /// 部门层级
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// 主键字段
        /// </summary>
        [JsonProperty("PrimaryColumn")]
        public string PrimaryColumn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrgId", this.OrgId);
            this.SetParamSimple(map, prefix + "OrgName", this.OrgName);
            this.SetParamSimple(map, prefix + "OrgIdentity", this.OrgIdentity);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "PrimaryColumn", this.PrimaryColumn);
        }
    }
}

