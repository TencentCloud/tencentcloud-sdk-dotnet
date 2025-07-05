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

namespace TencentCloud.Cii.V20210408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAutoClassifyStructureTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 服务类型
        /// Structured 仅结构化
        /// Underwrite 结构化+核保
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// 创建任务时可以上传多个报告，后台生成多个识别子任务，子任务的详细信息
        /// </summary>
        [JsonProperty("TaskInfos")]
        public CreateAutoClassifyStructureTaskInfo[] TaskInfos{ get; set; }

        /// <summary>
        /// 保单号
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }

        /// <summary>
        /// 核保触发方式
        /// Auto 自动
        /// Manual 手动
        /// </summary>
        [JsonProperty("TriggerType")]
        public string TriggerType{ get; set; }

        /// <summary>
        /// 险种，如果是体检报告类型，此参数是必填，类型说明如下：
        /// CriticalDiseaseInsurance:重疾险
        /// LifeInsurance：寿险
        /// AccidentInsurance：意外险
        /// </summary>
        [JsonProperty("InsuranceTypes")]
        public string[] InsuranceTypes{ get; set; }

        /// <summary>
        /// 回调地址，接收Post请求传送结果
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamArrayObj(map, prefix + "TaskInfos.", this.TaskInfos);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamArraySimple(map, prefix + "InsuranceTypes.", this.InsuranceTypes);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
        }
    }
}

