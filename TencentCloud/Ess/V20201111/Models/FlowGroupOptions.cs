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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FlowGroupOptions : AbstractModel
    {
        
        /// <summary>
        /// <p>签署人校验方式,支持以下类型</p><ul><li>VerifyCheck : 人脸识别 (默认值)</li><li>MobileCheck : 手机号验证</li></ul>参数说明：此参数仅在合同组文件发起有效，可选人脸识别或手机号验证两种方式，若选择后者，未实名个人签署方在签署合同时，无需经过实名认证和意愿确认两次人脸识别，该能力仅适用于个人签署方。
        /// </summary>
        [JsonProperty("ApproverVerifyType")]
        public string ApproverVerifyType{ get; set; }

        /// <summary>
        /// <p>发起合同（流程）组本方企业经办人通知方式<br>签署通知类型，支持以下类型</p><ul><li>sms : 短信 (默认值)</li><li>none : 不通知</li></ul>
        /// </summary>
        [JsonProperty("SelfOrganizationApproverNotifyType")]
        public string SelfOrganizationApproverNotifyType{ get; set; }

        /// <summary>
        /// <p>发起合同（流程）组他方经办人通知方式<br>签署通知类型，支持以下类型</p><ul><li>sms : 短信 (默认值)</li><li>none : 不通知</li></ul>
        /// </summary>
        [JsonProperty("OtherApproverNotifyType")]
        public string OtherApproverNotifyType{ get; set; }

        /// <summary>
        /// <p>是否开启发起合同组的发起审批，默认：false(不开启)，开启后，发起合同组会提交电子签内置审批流</p>
        /// </summary>
        [JsonProperty("FlowGroupNeedWorkflow")]
        public bool? FlowGroupNeedWorkflow{ get; set; }

        /// <summary>
        /// <p>是否不可编辑合同名称 true-不可编辑 false-可编辑(默认)</p>
        /// </summary>
        [JsonProperty("NoEditFlowName")]
        public bool? NoEditFlowName{ get; set; }

        /// <summary>
        /// <p>是否不可编辑合同类型 true-不可编辑 false-可编辑(默认)</p>
        /// </summary>
        [JsonProperty("NoEditFlowType")]
        public bool? NoEditFlowType{ get; set; }

        /// <summary>
        /// <p>是否不可编辑合同截止日期 true-不可编辑 false-可编辑(默认)</p>
        /// </summary>
        [JsonProperty("NoEditDeadline")]
        public bool? NoEditDeadline{ get; set; }

        /// <summary>
        /// <p>签署控件配置(如是否默认展示日期)，用于嵌入式发起页面配置</p>
        /// </summary>
        [JsonProperty("SignComponentConfig")]
        public SignComponentConfig SignComponentConfig{ get; set; }

        /// <summary>
        /// <p>是否禁止编辑水印控件属性 true-禁止 false-否(默认)</p>
        /// </summary>
        [JsonProperty("ForbidEditWatermark")]
        public bool? ForbidEditWatermark{ get; set; }

        /// <summary>
        /// <p>发起成功后是否隐藏签署码 true-隐藏 false-否(默认)</p>
        /// </summary>
        [JsonProperty("HideSignCodeAfterStart")]
        public bool? HideSignCodeAfterStart{ get; set; }

        /// <summary>
        /// <p>发起成功后是否签署合同,仅当前经办人为签署人时生效 true-展示签署 false-否(默认)</p>
        /// </summary>
        [JsonProperty("SignAfterStart")]
        public bool? SignAfterStart{ get; set; }

        /// <summary>
        /// <p>发起成功后是否预览合同 true-展示预览按钮 false-否(默认)</p>
        /// </summary>
        [JsonProperty("PreviewAfterStart")]
        public bool? PreviewAfterStart{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApproverVerifyType", this.ApproverVerifyType);
            this.SetParamSimple(map, prefix + "SelfOrganizationApproverNotifyType", this.SelfOrganizationApproverNotifyType);
            this.SetParamSimple(map, prefix + "OtherApproverNotifyType", this.OtherApproverNotifyType);
            this.SetParamSimple(map, prefix + "FlowGroupNeedWorkflow", this.FlowGroupNeedWorkflow);
            this.SetParamSimple(map, prefix + "NoEditFlowName", this.NoEditFlowName);
            this.SetParamSimple(map, prefix + "NoEditFlowType", this.NoEditFlowType);
            this.SetParamSimple(map, prefix + "NoEditDeadline", this.NoEditDeadline);
            this.SetParamObj(map, prefix + "SignComponentConfig.", this.SignComponentConfig);
            this.SetParamSimple(map, prefix + "ForbidEditWatermark", this.ForbidEditWatermark);
            this.SetParamSimple(map, prefix + "HideSignCodeAfterStart", this.HideSignCodeAfterStart);
            this.SetParamSimple(map, prefix + "SignAfterStart", this.SignAfterStart);
            this.SetParamSimple(map, prefix + "PreviewAfterStart", this.PreviewAfterStart);
        }
    }
}

