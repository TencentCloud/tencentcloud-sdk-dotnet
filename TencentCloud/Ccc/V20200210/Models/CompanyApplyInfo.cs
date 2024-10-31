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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CompanyApplyInfo : AbstractModel
    {
        
        /// <summary>
        /// 申请人身份，0-公司法定代表人，1-经办人（受法定代表人委托）
        /// </summary>
        [JsonProperty("ApplicantType")]
        public long? ApplicantType{ get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [JsonProperty("CompanyName")]
        public string CompanyName{ get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        [JsonProperty("BusinessId")]
        public string BusinessId{ get; set; }

        /// <summary>
        /// 营业执照扫描件(加盖公章)。(支持jpg、png、gif、jpeg格式的图片，每张图片应大于50K，不超过5MB，模板参见控制台:https://console.cloud.tencent.com/ccc/enterprise/update)
        /// </summary>
        [JsonProperty("BusinessIdPicUrl")]
        public string BusinessIdPicUrl{ get; set; }

        /// <summary>
        /// 法定代表人名称
        /// </summary>
        [JsonProperty("CorporationName")]
        public string CorporationName{ get; set; }

        /// <summary>
        /// 法定代表人身份证号码
        /// </summary>
        [JsonProperty("CorporationId")]
        public string CorporationId{ get; set; }

        /// <summary>
        /// 法定代表人身份证正反面扫描件。(支持jpg、png、gif、jpeg格式的图片，每张图片应大于50K，不超过5MB，模板参见控制台:https://console.cloud.tencent.com/ccc/enterprise/update)
        /// </summary>
        [JsonProperty("CorporationIdPicUrl")]
        public string CorporationIdPicUrl{ get; set; }

        /// <summary>
        /// 安全合规使用承诺书。(支持jpg、png、gif、jpeg格式的图片，每张图片应大于50K，不超过5MB，模板参见控制台:https://console.cloud.tencent.com/ccc/enterprise/update)
        /// </summary>
        [JsonProperty("NetworkCommitmentPicUrl")]
        public string NetworkCommitmentPicUrl{ get; set; }

        /// <summary>
        /// 是否与腾讯云账号的资质一致,0-不一致,1-一致
        /// </summary>
        [JsonProperty("IsEqualTencentCloud")]
        public long? IsEqualTencentCloud{ get; set; }

        /// <summary>
        /// 法定代表人手机号
        /// </summary>
        [JsonProperty("CorporationMobile")]
        public string CorporationMobile{ get; set; }

        /// <summary>
        /// 法定代表人手机号码实名认证。(支持jpg、png、gif、jpeg格式的图片，每张图片应大于50K，不超过5MB，模板参见控制台:https://console.cloud.tencent.com/ccc/enterprise/update)
        /// </summary>
        [JsonProperty("CorporationMobilePicUrl")]
        public string CorporationMobilePicUrl{ get; set; }

        /// <summary>
        /// 通话话术。(支持doc、docx格式的文档不超过50MB，模板参见控制台:https://console.cloud.tencent.com/ccc/enterprise/update)
        /// </summary>
        [JsonProperty("UseDescribeFileUrl")]
        public string UseDescribeFileUrl{ get; set; }

        /// <summary>
        /// 公司授权函。(支持jpg、png、gif、jpeg格式的图片，每张图片应大于50K，不超过5MB，模板参见控制台:https://console.cloud.tencent.com/ccc/enterprise/update)
        /// </summary>
        [JsonProperty("CompanyAuthLetterPicUrl")]
        public string CompanyAuthLetterPicUrl{ get; set; }

        /// <summary>
        /// 电话受理单。(支持jpg、png、gif、jpeg格式的图片，每张图片应大于50K，不超过5MB，模板参见控制台:https://console.cloud.tencent.com/ccc/enterprise/update)
        /// </summary>
        [JsonProperty("AcceptPicUrl")]
        public string AcceptPicUrl{ get; set; }

        /// <summary>
        /// 法定代表人手持身份证照，申请人类型为法定代表人时必填。(支持jpg、png、gif、jpeg格式的图片，每张图片应大于50K，不超过5MB，模板参见控制台:https://console.cloud.tencent.com/ccc/enterprise/update)
        /// </summary>
        [JsonProperty("CorporationHoldingOnIdPicUrl")]
        public string CorporationHoldingOnIdPicUrl{ get; set; }

        /// <summary>
        /// 经办人名称，申请人类型为经办人时必填。
        /// </summary>
        [JsonProperty("OperatorName")]
        public string OperatorName{ get; set; }

        /// <summary>
        /// 经办人证件号码，申请人类型为经办人时必填。
        /// </summary>
        [JsonProperty("OperatorId")]
        public string OperatorId{ get; set; }

        /// <summary>
        /// 经办人身份证正反面扫描件，申请人类型为经办人时必填。(支持jpg、png、gif、jpeg格式的图片，每张图片应大于50K，不超过5MB，模板参见控制台:https://console.cloud.tencent.com/ccc/enterprise/update)
        /// </summary>
        [JsonProperty("OperatorIdPicUrl")]
        public string OperatorIdPicUrl{ get; set; }

        /// <summary>
        /// 经办人手持身份证照，申请人类型为经办人时必填。(支持jpg、png、gif、jpeg格式的图片，每张图片应大于50K，不超过5MB，模板参见控制台:https://console.cloud.tencent.com/ccc/enterprise/update)
        /// </summary>
        [JsonProperty("OperatorHoldingOnIdPicUrl")]
        public string OperatorHoldingOnIdPicUrl{ get; set; }

        /// <summary>
        /// 委托授权书，申请人类型为经办人时必填。(支持jpg、png、gif、jpeg格式的图片，每张图片应大于50K，不超过5MB，模板参见控制台:https://console.cloud.tencent.com/ccc/enterprise/update)
        /// </summary>
        [JsonProperty("CommissionPicUrl")]
        public string CommissionPicUrl{ get; set; }

        /// <summary>
        /// 经办人手机号，申请人类型为经办人时必填。
        /// </summary>
        [JsonProperty("OperatorMobile")]
        public string OperatorMobile{ get; set; }

        /// <summary>
        /// 经办人邮箱，申请人类型为经办人时必填。
        /// </summary>
        [JsonProperty("OperatorEmail")]
        public string OperatorEmail{ get; set; }

        /// <summary>
        /// 经办人手机号码实名认证，申请人类型为经办人时必填。(支持jpg、png、gif、jpeg格式的图片，每张图片应大于50K，不超过5MB，模板参见控制台:https://console.cloud.tencent.com/ccc/enterprise/update)
        /// </summary>
        [JsonProperty("OperatorMobilePicUrl")]
        public string OperatorMobilePicUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicantType", this.ApplicantType);
            this.SetParamSimple(map, prefix + "CompanyName", this.CompanyName);
            this.SetParamSimple(map, prefix + "BusinessId", this.BusinessId);
            this.SetParamSimple(map, prefix + "BusinessIdPicUrl", this.BusinessIdPicUrl);
            this.SetParamSimple(map, prefix + "CorporationName", this.CorporationName);
            this.SetParamSimple(map, prefix + "CorporationId", this.CorporationId);
            this.SetParamSimple(map, prefix + "CorporationIdPicUrl", this.CorporationIdPicUrl);
            this.SetParamSimple(map, prefix + "NetworkCommitmentPicUrl", this.NetworkCommitmentPicUrl);
            this.SetParamSimple(map, prefix + "IsEqualTencentCloud", this.IsEqualTencentCloud);
            this.SetParamSimple(map, prefix + "CorporationMobile", this.CorporationMobile);
            this.SetParamSimple(map, prefix + "CorporationMobilePicUrl", this.CorporationMobilePicUrl);
            this.SetParamSimple(map, prefix + "UseDescribeFileUrl", this.UseDescribeFileUrl);
            this.SetParamSimple(map, prefix + "CompanyAuthLetterPicUrl", this.CompanyAuthLetterPicUrl);
            this.SetParamSimple(map, prefix + "AcceptPicUrl", this.AcceptPicUrl);
            this.SetParamSimple(map, prefix + "CorporationHoldingOnIdPicUrl", this.CorporationHoldingOnIdPicUrl);
            this.SetParamSimple(map, prefix + "OperatorName", this.OperatorName);
            this.SetParamSimple(map, prefix + "OperatorId", this.OperatorId);
            this.SetParamSimple(map, prefix + "OperatorIdPicUrl", this.OperatorIdPicUrl);
            this.SetParamSimple(map, prefix + "OperatorHoldingOnIdPicUrl", this.OperatorHoldingOnIdPicUrl);
            this.SetParamSimple(map, prefix + "CommissionPicUrl", this.CommissionPicUrl);
            this.SetParamSimple(map, prefix + "OperatorMobile", this.OperatorMobile);
            this.SetParamSimple(map, prefix + "OperatorEmail", this.OperatorEmail);
            this.SetParamSimple(map, prefix + "OperatorMobilePicUrl", this.OperatorMobilePicUrl);
        }
    }
}

