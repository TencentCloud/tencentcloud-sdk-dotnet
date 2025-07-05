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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RevokeResourceAuthorizationRequest : AbstractModel
    {
        
        /// <summary>
        /// 平台 Id，指定访问的平台。关于平台概念，请参见文档 [平台](https://cloud.tencent.com/document/product/1156/43767)。
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// 资源所属实体。
        /// </summary>
        [JsonProperty("Owner")]
        public Entity Owner{ get; set; }

        /// <summary>
        /// 被授权资源。
        /// </summary>
        [JsonProperty("Resources")]
        public Resource[] Resources{ get; set; }

        /// <summary>
        /// 被授权目标实体。
        /// </summary>
        [JsonProperty("Authorizees")]
        public Entity[] Authorizees{ get; set; }

        /// <summary>
        /// 详细授权值。 取值有：
        /// <li>R：可读，可以浏览素材，但不能使用该素材（将其添加到 Project），或复制到自己的媒资库中</li>
        /// <li>X：可用，可以使用该素材（将其添加到 Project），但不能将其复制到自己的媒资库中，意味着被授权者无法将该资源进一步扩散给其他个人或团队。</li>
        /// <li>C：可复制，既可以使用该素材（将其添加到 Project），也可以将其复制到自己的媒资库中。</li>
        /// <li>W：可修改、删除媒资。</li>
        /// </summary>
        [JsonProperty("Permissions")]
        public string[] Permissions{ get; set; }

        /// <summary>
        /// 操作者。如不填，默认为 `cmeid_system`，表示平台管理员操作，撤销任意资源的授权权限。如果指定操作者，则操作者必须对被授权资源有写权限。
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamObj(map, prefix + "Owner.", this.Owner);
            this.SetParamArrayObj(map, prefix + "Resources.", this.Resources);
            this.SetParamArrayObj(map, prefix + "Authorizees.", this.Authorizees);
            this.SetParamArraySimple(map, prefix + "Permissions.", this.Permissions);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
        }
    }
}

