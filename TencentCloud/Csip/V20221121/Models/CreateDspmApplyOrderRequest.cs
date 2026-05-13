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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDspmApplyOrderRequest : AbstractModel
    {
        
        /// <summary>
        /// 资产id
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// 申请类型。0-子账号授权 1-访客授权。
        /// </summary>
        [JsonProperty("ApplyType")]
        public long? ApplyType{ get; set; }

        /// <summary>
        /// 权限信息。
        /// </summary>
        [JsonProperty("Privilege")]
        public DspmDbAccountPrivilege Privilege{ get; set; }

        /// <summary>
        /// 主机地址。当前仅支持'%'。默认'%'。
        /// </summary>
        [JsonProperty("Host")]
        public string Host{ get; set; }

        /// <summary>
        /// 从审批完成后开始计算的访问权限失效时间，临时账号有效。单位毫秒。
        /// </summary>
        [JsonProperty("ValidatePeriod")]
        public long? ValidatePeriod{ get; set; }

        /// <summary>
        /// 审批人列表。为空使用资产全部管理员。
        /// </summary>
        [JsonProperty("ApproverUin")]
        public string[] ApproverUin{ get; set; }

        /// <summary>
        /// 申请原因
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// 管理类型。0-普通成员 1-管理员
        /// </summary>
        [JsonProperty("ManagerType")]
        public long? ManagerType{ get; set; }

        /// <summary>
        /// 被授权者。子账号授权时，传目标uin，为空时默认使用当前uin；访客授权时传访客身份id。
        /// </summary>
        [JsonProperty("Subject")]
        public string Subject{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "ApplyType", this.ApplyType);
            this.SetParamObj(map, prefix + "Privilege.", this.Privilege);
            this.SetParamSimple(map, prefix + "Host", this.Host);
            this.SetParamSimple(map, prefix + "ValidatePeriod", this.ValidatePeriod);
            this.SetParamArraySimple(map, prefix + "ApproverUin.", this.ApproverUin);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamSimple(map, prefix + "ManagerType", this.ManagerType);
            this.SetParamSimple(map, prefix + "Subject", this.Subject);
        }
    }
}

