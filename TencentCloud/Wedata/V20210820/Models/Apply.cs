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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Apply : AbstractModel
    {
        
        /// <summary>
        /// 申请人id
        /// </summary>
        [JsonProperty("ApplicantId")]
        public string ApplicantId{ get; set; }

        /// <summary>
        /// 申请人名称
        /// </summary>
        [JsonProperty("ApplicantName")]
        public string ApplicantName{ get; set; }

        /// <summary>
        /// 审批备注
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 审批分类key
        /// </summary>
        [JsonProperty("ApproveClassification")]
        public string ApproveClassification{ get; set; }

        /// <summary>
        /// 审批单id
        /// </summary>
        [JsonProperty("ApproveId")]
        public string ApproveId{ get; set; }

        /// <summary>
        /// 审批类型key
        /// </summary>
        [JsonProperty("ApproveType")]
        public string ApproveType{ get; set; }

        /// <summary>
        /// 申请原因
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 审批时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApproveTime")]
        public string ApproveTime{ get; set; }

        /// <summary>
        /// 审批分类名称
        /// </summary>
        [JsonProperty("ApproveClassificationName")]
        public string ApproveClassificationName{ get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 审批类型名称
        /// </summary>
        [JsonProperty("ApproveTypeName")]
        public string ApproveTypeName{ get; set; }

        /// <summary>
        /// 审批异常或者失败信息
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }

        /// <summary>
        /// 申请名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplyName")]
        public string ApplyName{ get; set; }

        /// <summary>
        /// 审批人id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApproverId")]
        public string ApproverId{ get; set; }

        /// <summary>
        /// 审批人名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApproverName")]
        public string ApproverName{ get; set; }

        /// <summary>
        /// 审批所属项目
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApproveProjectName")]
        public string ApproveProjectName{ get; set; }

        /// <summary>
        /// 审批id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplyId")]
        public string ApplyId{ get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonProperty("Metadata")]
        public string Metadata{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicantId", this.ApplicantId);
            this.SetParamSimple(map, prefix + "ApplicantName", this.ApplicantName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "ApproveClassification", this.ApproveClassification);
            this.SetParamSimple(map, prefix + "ApproveId", this.ApproveId);
            this.SetParamSimple(map, prefix + "ApproveType", this.ApproveType);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ApproveTime", this.ApproveTime);
            this.SetParamSimple(map, prefix + "ApproveClassificationName", this.ApproveClassificationName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ApproveTypeName", this.ApproveTypeName);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
            this.SetParamSimple(map, prefix + "ApplyName", this.ApplyName);
            this.SetParamSimple(map, prefix + "ApproverId", this.ApproverId);
            this.SetParamSimple(map, prefix + "ApproverName", this.ApproverName);
            this.SetParamSimple(map, prefix + "ApproveProjectName", this.ApproveProjectName);
            this.SetParamSimple(map, prefix + "ApplyId", this.ApplyId);
            this.SetParamSimple(map, prefix + "Metadata", this.Metadata);
        }
    }
}

