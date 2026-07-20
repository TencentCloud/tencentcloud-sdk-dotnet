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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConfigGroupVersionInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>配置组版本 ID，创建配置组版本时 EdgeOne 分配的唯一资源 ID。</p><p>参数格式：ver-2kplomhisdcb</p><p>取值参考：</p><ul><li><a href="https://cloud.tencent.com/document/api/1552/101867">CreateConfigGroupVersion</a> 返回值 <code>VersionId</code></li><li><a href="https://cloud.tencent.com/document/api/1552/101864">DescribeConfigGroupVersions</a> 返回值 <code>ConfigGroupVersionInfos</code></li></ul>
        /// </summary>
        [JsonProperty("VersionId")]
        public string VersionId{ get; set; }

        /// <summary>
        /// <p>配置组版本号。该参数仅作展示使用，配置组每创建一次新版本，该版本号自增加一，初始版本的版本号为 &quot;0&quot;。</p><p>取值参考：<a href="https://cloud.tencent.com/document/api/1552/101864">DescribeConfigGroupVersions</a> 返回值 <code>ConfigGroupVersionInfos</code></p>
        /// </summary>
        [JsonProperty("VersionNumber")]
        public string VersionNumber{ get; set; }

        /// <summary>
        /// <p>配置组版本所基于的来源版本 ID，在创建配置组版本时进行指定来源版本 ID，新版本将在该来源版本的配置基础上派生创建。</p><p>参数格式：ver-2kplomhisdcb</p><p>取值参考：</p><ul><li><a href="https://cloud.tencent.com/document/api/1552/101867">CreateConfigGroupVersion</a> 返回值 <code>VersionId</code></li><li><a href="https://cloud.tencent.com/document/api/1552/101864">DescribeConfigGroupVersions</a> 返回值 <code>ConfigGroupVersionInfos</code></li></ul>
        /// </summary>
        [JsonProperty("SourceVersion")]
        public string SourceVersion{ get; set; }

        /// <summary>
        /// <p>版本归属的配置组类型。</p><p>枚举值：</p><ul><li>l7_acceleration： 七层加速配置组</li><li>edge_functions： 边缘函数配置组</li><li>web_security： Web 防护配置组</li></ul>
        /// </summary>
        [JsonProperty("GroupType")]
        public string GroupType{ get; set; }

        /// <summary>
        /// <p>版本归属的配置组 ID。</p><p>参数格式：cg-2kplomhisdcb</p>
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// <p>版本描述。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>版本生效状态。</p><p>枚举值：</p><ul><li>creating： 版本创建中</li><li>inactive： 版本未生效</li><li>active： 版本已生效</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>版本创建时间。时间为世界标准时间（UTC）， 遵循 ISO 8601 标准的日期和时间格式。</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VersionId", this.VersionId);
            this.SetParamSimple(map, prefix + "VersionNumber", this.VersionNumber);
            this.SetParamSimple(map, prefix + "SourceVersion", this.SourceVersion);
            this.SetParamSimple(map, prefix + "GroupType", this.GroupType);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

