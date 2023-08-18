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

    public class FlowGroupOptions : AbstractModel
    {
        
        /// <summary>
        /// 发起方企业经办人（即签署人为发起方企业员工）是否需要对子合同进行独立的意愿确认：
        /// fasle：发起方企业经办人签署时对所有子合同进行统一的意愿确认
        /// true：发起方企业经办人签署时需要对子合同进行独立的意愿确认
        /// 默认为fasle。
        /// </summary>
        [JsonProperty("SelfOrganizationApproverSignEach")]
        public bool? SelfOrganizationApproverSignEach{ get; set; }

        /// <summary>
        /// 非发起方企业经办人（即：签署人为个人或者不为发起方企业的员工）是否需要对子合同进行独立的意愿确认：
        /// fasle：非发起方企业经办人签署时对所有子合同进行统一的意愿确认
        /// true：非发起方企业经办人签署时需要对子合同进行独立的意愿确认
        /// 默认为false。
        /// </summary>
        [JsonProperty("OtherApproverSignEach")]
        public bool? OtherApproverSignEach{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SelfOrganizationApproverSignEach", this.SelfOrganizationApproverSignEach);
            this.SetParamSimple(map, prefix + "OtherApproverSignEach", this.OtherApproverSignEach);
        }
    }
}

