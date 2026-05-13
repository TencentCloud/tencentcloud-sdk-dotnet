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

    public class DspmApplyOrder : AbstractModel
    {
        
        /// <summary>
        /// 申请单id
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 身份id。
        /// </summary>
        [JsonProperty("IdentifyId")]
        public string IdentifyId{ get; set; }

        /// <summary>
        /// 申请人账号uin
        /// </summary>
        [JsonProperty("ApplicantUin")]
        public DspmUinUser ApplicantUin{ get; set; }

        /// <summary>
        /// 资产id
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// 资产名
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// 资产所属地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 申请类型。0-关联身份 1-编辑身份 2-创建临时身份
        /// </summary>
        [JsonProperty("ApplyType")]
        public long? ApplyType{ get; set; }

        /// <summary>
        /// 申请权限。
        /// </summary>
        [JsonProperty("Privilege")]
        public DspmDbAccountPrivilege Privilege{ get; set; }

        /// <summary>
        /// 从审批完成后开始计算的访问权限失效时间，临时账号有效。单位毫秒。
        /// </summary>
        [JsonProperty("ValidatePeriod")]
        public long? ValidatePeriod{ get; set; }

        /// <summary>
        /// 申请原因。
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// 审批步骤
        /// </summary>
        [JsonProperty("ApproverSteps")]
        public DspmApproverStep[] ApproverSteps{ get; set; }

        /// <summary>
        /// 管理类型。0-普通成员 1-管理员
        /// </summary>
        [JsonProperty("ManagerType")]
        public long? ManagerType{ get; set; }

        /// <summary>
        /// 个人用户信息
        /// </summary>
        [JsonProperty("Person")]
        public DspmPersonUser Person{ get; set; }

        /// <summary>
        /// 云账号用户信息
        /// </summary>
        [JsonProperty("SubjectUser")]
        public DspmUinUser SubjectUser{ get; set; }

        /// <summary>
        /// 审批状态。 0-未审批 1-通过 2-拒绝
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 申请单创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "IdentifyId", this.IdentifyId);
            this.SetParamObj(map, prefix + "ApplicantUin.", this.ApplicantUin);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "ApplyType", this.ApplyType);
            this.SetParamObj(map, prefix + "Privilege.", this.Privilege);
            this.SetParamSimple(map, prefix + "ValidatePeriod", this.ValidatePeriod);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamArrayObj(map, prefix + "ApproverSteps.", this.ApproverSteps);
            this.SetParamSimple(map, prefix + "ManagerType", this.ManagerType);
            this.SetParamObj(map, prefix + "Person.", this.Person);
            this.SetParamObj(map, prefix + "SubjectUser.", this.SubjectUser);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}

