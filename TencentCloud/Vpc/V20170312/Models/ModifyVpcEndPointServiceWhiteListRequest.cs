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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyVpcEndPointServiceWhiteListRequest : AbstractModel
    {
        
        /// <summary>
        /// 用户UIN。可以通过终端节点所在的用户通过登录 腾讯云账号中心控制台获取。
        /// </summary>
        [JsonProperty("UserUin")]
        public string UserUin{ get; set; }

        /// <summary>
        /// 终端节点服务ID。可通过[DescribeVpcEndPointService](https://cloud.tencent.com/document/product/215/54678)接口获取。
        /// </summary>
        [JsonProperty("EndPointServiceId")]
        public string EndPointServiceId{ get; set; }

        /// <summary>
        /// 白名单描述信息。长度不超过60个字符。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserUin", this.UserUin);
            this.SetParamSimple(map, prefix + "EndPointServiceId", this.EndPointServiceId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

