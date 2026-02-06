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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AddRealServersRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>源站对应的项目ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// <p>源站对应的IP或域名</p>
        /// </summary>
        [JsonProperty("RealServerIP")]
        public string[] RealServerIP{ get; set; }

        /// <summary>
        /// <p>源站名称</p>
        /// </summary>
        [JsonProperty("RealServerName")]
        public string RealServerName{ get; set; }

        /// <summary>
        /// <p>标签列表</p>
        /// </summary>
        [JsonProperty("TagSet")]
        public TagPair[] TagSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamArraySimple(map, prefix + "RealServerIP.", this.RealServerIP);
            this.SetParamSimple(map, prefix + "RealServerName", this.RealServerName);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
        }
    }
}

