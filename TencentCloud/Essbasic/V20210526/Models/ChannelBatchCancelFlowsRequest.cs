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

    public class ChannelBatchCancelFlowsRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用相关信息。 此接口Agent.ProxyOrganizationOpenId、Agent. ProxyOperator.OpenId、Agent.AppId 必填。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 签署流程Id数组，最多100个，超过100不处理
        /// </summary>
        [JsonProperty("FlowIds")]
        public string[] FlowIds{ get; set; }

        /// <summary>
        /// 撤销理由,不超过200个字符
        /// </summary>
        [JsonProperty("CancelMessage")]
        public string CancelMessage{ get; set; }

        /// <summary>
        /// 撤销理由自定义格式，支持以下格式
        /// <ul><li>0 : 默认值</li>
        /// <li>1 : 只保留身份信息</li>
        /// <li>2 : 保留身份信息+企业名称</li>
        /// <li>3 : 保留身份信息+企业名称+经办人名称</li></ul>
        /// 例如,假设合同的发起方是典子谦示例企业的经办人张三，撤销理由是"合同内容错误，需要修正",合同撤销后，各签署方看到的撤销理由是会是
        /// 
        /// 0: 发起方-典子谦示例企业-张三以"合同内容错误，需要修正"的理由撤销当前合同
        /// 1: 发起方以"合同内容错误，需要修正"的理由撤销当前合同
        /// 2: 发起方-典子谦示例企业以"合同内容错误，需要修正"的理由撤销当前合同
        /// 3: 发起方-典子谦示例企业-张三以"合同内容错误，需要修正"的理由撤销当前合同</br>
        /// 
        /// 备注:`如果不传递撤销理由，那么默认撤销理由是 "自动撤销（通过接口实现）"`
        /// </summary>
        [JsonProperty("CancelMessageFormat")]
        public long? CancelMessageFormat{ get; set; }

        /// <summary>
        /// 暂未开放
        /// </summary>
        [JsonProperty("Operator")]
        [System.Obsolete]
        public UserInfo Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamArraySimple(map, prefix + "FlowIds.", this.FlowIds);
            this.SetParamSimple(map, prefix + "CancelMessage", this.CancelMessage);
            this.SetParamSimple(map, prefix + "CancelMessageFormat", this.CancelMessageFormat);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
        }
    }
}

