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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImportKeyPairRequest : AbstractModel
    {
        
        /// <summary>
        /// 密钥对名称，可由数字，字母和下划线组成，长度不超过25个字符。
        /// </summary>
        [JsonProperty("KeyName")]
        public string KeyName{ get; set; }

        /// <summary>
        /// 密钥对创建后所属的[项目](https://cloud.tencent.com/document/product/378/10861)ID。<br>可以通过以下方式获取项目ID：<li>通过[项目列表](https://console.cloud.tencent.com/project)查询项目ID。</li><li>通过调用接口 [DescribeProjects](https://cloud.tencent.com/document/api/651/78725)，取返回信息中的 `projectId ` 获取项目ID。</li>如果是默认项目，直接填0就可以。
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 密钥对的公钥内容，`OpenSSH RSA` 格式。
        /// </summary>
        [JsonProperty("PublicKey")]
        public string PublicKey{ get; set; }

        /// <summary>
        /// 标签描述列表。通过指定该参数可以同时绑定标签到密钥对。
        /// </summary>
        [JsonProperty("TagSpecification")]
        public TagSpecification[] TagSpecification{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KeyName", this.KeyName);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "PublicKey", this.PublicKey);
            this.SetParamArrayObj(map, prefix + "TagSpecification.", this.TagSpecification);
        }
    }
}

