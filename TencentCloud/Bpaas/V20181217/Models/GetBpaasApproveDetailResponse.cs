/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Bpaas.V20181217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetBpaasApproveDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// 申请人uin
        /// </summary>
        [JsonProperty("ApplyUin")]
        public ulong? ApplyUin{ get; set; }

        /// <summary>
        /// 申请人主账号
        /// </summary>
        [JsonProperty("ApplyOwnUin")]
        public ulong? ApplyOwnUin{ get; set; }

        /// <summary>
        /// 申请人昵称
        /// </summary>
        [JsonProperty("ApplyUinNick")]
        public string ApplyUinNick{ get; set; }

        /// <summary>
        /// 审批流id
        /// </summary>
        [JsonProperty("BpaasId")]
        public ulong? BpaasId{ get; set; }

        /// <summary>
        /// 审批流名称
        /// </summary>
        [JsonProperty("BpaasName")]
        public string BpaasName{ get; set; }

        /// <summary>
        /// 申请参数
        /// </summary>
        [JsonProperty("ApplicationParams")]
        public ApplyParam[] ApplicationParams{ get; set; }

        /// <summary>
        /// 申请原因
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 申请单状态
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 节点信息
        /// </summary>
        [JsonProperty("Nodes")]
        public StatusNode[] Nodes{ get; set; }

        /// <summary>
        /// 正在审批的节点id
        /// </summary>
        [JsonProperty("ApprovingNodeId")]
        public string ApprovingNodeId{ get; set; }

        /// <summary>
        /// 更新时间，时间格式：2021-12-12 10:12:10	
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplyUin", this.ApplyUin);
            this.SetParamSimple(map, prefix + "ApplyOwnUin", this.ApplyOwnUin);
            this.SetParamSimple(map, prefix + "ApplyUinNick", this.ApplyUinNick);
            this.SetParamSimple(map, prefix + "BpaasId", this.BpaasId);
            this.SetParamSimple(map, prefix + "BpaasName", this.BpaasName);
            this.SetParamArrayObj(map, prefix + "ApplicationParams.", this.ApplicationParams);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Nodes.", this.Nodes);
            this.SetParamSimple(map, prefix + "ApprovingNodeId", this.ApprovingNodeId);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

