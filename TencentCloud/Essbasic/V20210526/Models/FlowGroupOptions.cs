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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FlowGroupOptions : AbstractModel
    {
        
        /// <summary>
        /// <p>发起方企业经办人（即签署人为发起方企业员工）是否需要对子合同进行独立的意愿确认</p><ul><li>**false**（默认）：发起方企业经办人签署时对所有子合同进行统一的意愿确认。</li><li>**true**：发起方企业经办人签署时需要对子合同进行独立的意愿确认。</li></ul>
        /// </summary>
        [JsonProperty("SelfOrganizationApproverSignEach")]
        public bool? SelfOrganizationApproverSignEach{ get; set; }

        /// <summary>
        /// <p>非发起方企业经办人（即：签署人为个人或者不为发起方企业的员工）是否需要对子合同进行独立的意愿确认</p><ul><li>**false**（默认）：非发起方企业经办人签署时对所有子合同进行统一的意愿确认。</li><li>**true**：非发起方企业经办人签署时需要对子合同进行独立的意愿确认。</li></ul>
        /// </summary>
        [JsonProperty("OtherApproverSignEach")]
        public bool? OtherApproverSignEach{ get; set; }

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
        /// <p><br>在调用<a href="https://qian.tencent.com/developers/partnerApis/embedPages/ChannelCreatePrepareFlowGroup">获取发起合同组嵌入链接</a>创建合同时,可通过此参数限制在界面上拖拽签署控件后，可选那几种印章类型或签名类型。</p><p>注：仅在<strong>嵌入式文件</strong>发起场景下生效。</p>
        /// </summary>
        [JsonProperty("SignComponentLimits")]
        public EmbedSignComponentLimit[] SignComponentLimits{ get; set; }

        /// <summary>
        /// <p>隐藏操作步骤: 具体的控件类型如下</p><ul><li>2 : 补充文件内容</li><li>4 : 发起前合同信息与设置确认</li></ul>注：仅对新版页面生效
        /// </summary>
        [JsonProperty("HideOperationSteps")]
        public ulong?[] HideOperationSteps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SelfOrganizationApproverSignEach", this.SelfOrganizationApproverSignEach);
            this.SetParamSimple(map, prefix + "OtherApproverSignEach", this.OtherApproverSignEach);
            this.SetParamSimple(map, prefix + "NoEditFlowName", this.NoEditFlowName);
            this.SetParamSimple(map, prefix + "NoEditFlowType", this.NoEditFlowType);
            this.SetParamSimple(map, prefix + "NoEditDeadline", this.NoEditDeadline);
            this.SetParamObj(map, prefix + "SignComponentConfig.", this.SignComponentConfig);
            this.SetParamSimple(map, prefix + "ForbidEditWatermark", this.ForbidEditWatermark);
            this.SetParamSimple(map, prefix + "HideSignCodeAfterStart", this.HideSignCodeAfterStart);
            this.SetParamSimple(map, prefix + "SignAfterStart", this.SignAfterStart);
            this.SetParamSimple(map, prefix + "PreviewAfterStart", this.PreviewAfterStart);
            this.SetParamArrayObj(map, prefix + "SignComponentLimits.", this.SignComponentLimits);
            this.SetParamArraySimple(map, prefix + "HideOperationSteps.", this.HideOperationSteps);
        }
    }
}

