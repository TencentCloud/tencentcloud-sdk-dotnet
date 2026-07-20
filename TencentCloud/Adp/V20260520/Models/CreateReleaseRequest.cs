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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateReleaseRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>应用ID</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>应用分享访问控制配置</p>
        /// </summary>
        [JsonProperty("AppShareAccessControl")]
        public AppShareAccessControl AppShareAccessControl{ get; set; }

        /// <summary>
        /// <p>渠道ID列表</p>
        /// </summary>
        [JsonProperty("ChannelIdList")]
        public string[] ChannelIdList{ get; set; }

        /// <summary>
        /// <p>企业共享配置</p>
        /// </summary>
        [JsonProperty("CorpShareConfig")]
        public CorpShareConfig CorpShareConfig{ get; set; }

        /// <summary>
        /// <p>发布描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>将默认知识库中，仅调试生效的知识批量变更为&quot;调试/发布都生效&quot;</p>
        /// </summary>
        [JsonProperty("IsDevToRelease")]
        public bool? IsDevToRelease{ get; set; }

        /// <summary>
        /// <p>是否同步发布为应用模板</p>
        /// </summary>
        [JsonProperty("IsPublishAsTemplate")]
        public bool? IsPublishAsTemplate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamObj(map, prefix + "AppShareAccessControl.", this.AppShareAccessControl);
            this.SetParamArraySimple(map, prefix + "ChannelIdList.", this.ChannelIdList);
            this.SetParamObj(map, prefix + "CorpShareConfig.", this.CorpShareConfig);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "IsDevToRelease", this.IsDevToRelease);
            this.SetParamSimple(map, prefix + "IsPublishAsTemplate", this.IsPublishAsTemplate);
        }
    }
}

