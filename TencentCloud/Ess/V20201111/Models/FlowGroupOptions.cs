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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FlowGroupOptions : AbstractModel
    {
        
        /// <summary>
        /// 签署人校验方式,支持以下类型
        /// <ul><li>VerifyCheck : 人脸识别 (默认值)</li>
        /// <li>MobileCheck : 手机号验证</li></ul>
        /// 参数说明：此参数仅在合同组文件发起有效，可选人脸识别或手机号验证两种方式，若选择后者，未实名个人签署方在签署合同时，无需经过实名认证和意愿确认两次人脸识别，该能力仅适用于个人签署方。
        /// </summary>
        [JsonProperty("ApproverVerifyType")]
        public string ApproverVerifyType{ get; set; }

        /// <summary>
        /// 发起合同（流程）组本方企业经办人通知方式
        /// 签署通知类型，支持以下类型
        /// <ul><li>sms : 短信 (默认值)</li><li>none : 不通知</li></ul>
        /// </summary>
        [JsonProperty("SelfOrganizationApproverNotifyType")]
        public string SelfOrganizationApproverNotifyType{ get; set; }

        /// <summary>
        /// 发起合同（流程）组他方经办人通知方式
        /// 签署通知类型，支持以下类型
        /// <ul><li>sms : 短信 (默认值)</li><li>none : 不通知</li></ul>
        /// </summary>
        [JsonProperty("OtherApproverNotifyType")]
        public string OtherApproverNotifyType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApproverVerifyType", this.ApproverVerifyType);
            this.SetParamSimple(map, prefix + "SelfOrganizationApproverNotifyType", this.SelfOrganizationApproverNotifyType);
            this.SetParamSimple(map, prefix + "OtherApproverNotifyType", this.OtherApproverNotifyType);
        }
    }
}

