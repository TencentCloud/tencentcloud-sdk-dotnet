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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChannelBillUsageDetail : AbstractModel
    {
        
        /// <summary>
        /// 合同流程ID，为32位字符串。
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 合同经办人名称
        /// 如果有多个经办人用分号隔开。
        /// </summary>
        [JsonProperty("OperatorName")]
        public string OperatorName{ get; set; }

        /// <summary>
        /// 发起方组织机构名称
        /// </summary>
        [JsonProperty("CreateOrganizationName")]
        public string CreateOrganizationName{ get; set; }

        /// <summary>
        /// 合同流程的名称。
        /// </summary>
        [JsonProperty("FlowName")]
        public string FlowName{ get; set; }

        /// <summary>
        /// 合同流程当前的签署状态, 会存在下列的状态值
        /// <ul>
        /// <li>**INIT**: 合同创建</li>
        /// <li>**PART**: 合同签署中(至少有一个签署方已经签署)</li>
        /// <li>**REJECT**: 合同拒签</li>
        /// <li>**ALL**: 合同签署完成</li>
        /// <li>**DEADLINE**: 合同流签(合同过期)</li>
        /// <li>**CANCEL**: 合同撤回</li>
        /// <li>**RELIEVED**: 解除协议（已解除）</li>
        /// <li>**WILLEXPIRE**: 合同即将过期</li>
        /// <li>**EXCEPTION**: 合同异常</li>
        /// </ul>
        /// </summary>
        [JsonProperty("FlowStatus")]
        public string FlowStatus{ get; set; }

        /// <summary>
        /// 查询的套餐类型
        /// 对应关系如下:
        /// <ul>
        /// <li>**CloudEnterprise**: 企业版合同</li>
        /// <li>**SingleSignature**: 单方签章</li>
        /// <li>**CloudProve**: 签署报告</li>
        /// <li>**CloudOnlineSign**: 腾讯会议在线签约</li>
        /// <li>**ChannelWeCard**: 微工卡</li>
        /// <li>**SignFlow**: 合同套餐</li>
        /// <li>**SignFace**: 签署意愿（人脸识别）</li>
        /// <li>**SignPassword**: 签署意愿（密码）</li>
        /// <li>**SignSMS**: 签署意愿（短信）</li>
        /// <li>**PersonalEssAuth**: 签署人实名（腾讯电子签认证）</li>
        /// <li>**PersonalThirdAuth**: 签署人实名（信任第三方认证）</li>
        /// <li>**OrgEssAuth**: 签署企业实名</li>
        /// <li>**FlowNotify**: 短信通知</li>
        /// <li>**AuthService**: 企业工商信息查询</li>
        /// </ul>
        /// </summary>
        [JsonProperty("QuotaType")]
        public string QuotaType{ get; set; }

        /// <summary>
        /// 合同使用量
        /// 注: `如果消耗类型是撤销返还，此值为负值代表返还的合同数量`
        /// </summary>
        [JsonProperty("UseCount")]
        public long? UseCount{ get; set; }

        /// <summary>
        /// 消耗的时间戳，格式为Unix标准时间戳（秒）。
        /// </summary>
        [JsonProperty("CostTime")]
        public long? CostTime{ get; set; }

        /// <summary>
        /// 消耗的套餐名称
        /// </summary>
        [JsonProperty("QuotaName")]
        public string QuotaName{ get; set; }

        /// <summary>
        /// 消耗类型
        /// **1**.扣费 
        /// **2**.撤销返还
        /// </summary>
        [JsonProperty("CostType")]
        public long? CostType{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamSimple(map, prefix + "OperatorName", this.OperatorName);
            this.SetParamSimple(map, prefix + "CreateOrganizationName", this.CreateOrganizationName);
            this.SetParamSimple(map, prefix + "FlowName", this.FlowName);
            this.SetParamSimple(map, prefix + "FlowStatus", this.FlowStatus);
            this.SetParamSimple(map, prefix + "QuotaType", this.QuotaType);
            this.SetParamSimple(map, prefix + "UseCount", this.UseCount);
            this.SetParamSimple(map, prefix + "CostTime", this.CostTime);
            this.SetParamSimple(map, prefix + "QuotaName", this.QuotaName);
            this.SetParamSimple(map, prefix + "CostType", this.CostType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

