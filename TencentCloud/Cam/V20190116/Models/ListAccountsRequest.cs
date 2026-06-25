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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListAccountsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>返回结果的条数，当返回结果达到 MaxItems 限制被截断时，返回参数IsTruncated将等于true。</p><p>取值范围：[1, 100]</p>
        /// </summary>
        [JsonProperty("MaxItems")]
        public long? MaxItems{ get; set; }

        /// <summary>
        /// <p>当请求的返回结果被截断时，可以使用Marker获取从当前截断位置之后的内容。</p>
        /// </summary>
        [JsonProperty("Marker")]
        public string Marker{ get; set; }

        /// <summary>
        /// <p>用户类型</p><p>枚举值：</p><ul><li>Owner： 主账号</li><li>SubUser： 普通子用户</li><li>CICUser： CIC 子用户</li><li>WechatCorpUser： 企业微信子用户</li><li>AgentIdentity： AgentIdentity子用户</li><li>Collaborator： 协作者</li><li>MessageReceiver： 消息接收者</li></ul>
        /// </summary>
        [JsonProperty("UserType")]
        public string UserType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxItems", this.MaxItems);
            this.SetParamSimple(map, prefix + "Marker", this.Marker);
            this.SetParamSimple(map, prefix + "UserType", this.UserType);
        }
    }
}

