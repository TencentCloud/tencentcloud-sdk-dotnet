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

    public class CreateConfigGroupVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>站点 ID。</p>
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// <p>待新建版本的配置组 ID。您可以通过查询环境信息接口（DescribeEnvironments）获取完整的环境信息，环境信息中包含了每个配置组类型的配置组 ID。</p><p>取值参考：<a href="https://cloud.tencent.com/document/api/1552/101862">DescribeEnvironments</a> 返回值 <code>EnvInfos</code></p>
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// <p>待导入的配置内容。要求采用 JSON 格式，按照 UTF-8 方式进行编码。配置文件内容可参考下方示例和 <a href="https://cloud.tencent.com/document/product/1552/125342">配置组语法说明</a>。</p>
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// <p>版本描述，可输入最大长度为 50 个字符，可以通过本字段填写该版本的使用场景等。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>新版本所基于的来源版本 ID。新版本将在该来源版本的配置基础上派生创建。该字段可选，未传入时默认采用当前生产环境正在生效的版本作为来源版本。</p><p>取值参考：</p><ul><li><a href="https://cloud.tencent.com/document/api/1552/101867">CreateConfigGroupVersion</a> 返回值 <code>VersionId</code></li><li><a href="https://cloud.tencent.com/document/api/1552/101864">DescribeConfigGroupVersions</a> 返回值 <code>ConfigGroupVersionInfos</code></li></ul>
        /// </summary>
        [JsonProperty("SourceVersion")]
        public string SourceVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "SourceVersion", this.SourceVersion);
        }
    }
}

