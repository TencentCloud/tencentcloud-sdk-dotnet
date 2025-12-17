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

namespace TencentCloud.Evt.V20250217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CompleteApprovalRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>审批单号</p>
        /// </summary>
        [JsonProperty("ApprovalId")]
        public string ApprovalId{ get; set; }

        /// <summary>
        /// <p>审批节点</p>
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

        /// <summary>
        /// <p>审批结果，1通过2拒绝</p>
        /// </summary>
        [JsonProperty("Result")]
        public ulong? Result{ get; set; }

        /// <summary>
        /// <p>审批意见</p>
        /// </summary>
        [JsonProperty("Opinion")]
        public string Opinion{ get; set; }

        /// <summary>
        /// <p>审批人的身份认证Token，通过自定义角色体系回调接口分发</p><p>token信息</p>
        /// </summary>
        [JsonProperty("UserToken")]
        public string UserToken{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApprovalId", this.ApprovalId);
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "Opinion", this.Opinion);
            this.SetParamSimple(map, prefix + "UserToken", this.UserToken);
        }
    }
}

