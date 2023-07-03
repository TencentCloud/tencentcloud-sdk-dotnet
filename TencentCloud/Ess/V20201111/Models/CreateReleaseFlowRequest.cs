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

    public class CreateReleaseFlowRequest : AbstractModel
    {
        
        /// <summary>
        /// 调用方用户信息，userId 必填
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 待解除的签署流程编号（即原签署流程的编号）
        /// </summary>
        [JsonProperty("NeedRelievedFlowId")]
        public string NeedRelievedFlowId{ get; set; }

        /// <summary>
        /// 解除协议内容
        /// </summary>
        [JsonProperty("ReliveInfo")]
        public RelieveInfo ReliveInfo{ get; set; }

        /// <summary>
        /// 非必须，解除协议的本企业签署人列表，
        /// 默认使用原流程的签署人列表,当解除协议的签署人与原流程的签署人不能相同时（例如原流程签署人离职了），需要指定本企业其他已实名员工来替换原流程中的原签署人，注意需要指明原签署人的编号(ReceiptId,通过DescribeFlowInfo接口获取)来代表需要替换哪一个签署人
        /// 解除协议的签署人数量不能多于原流程的签署人数量
        /// </summary>
        [JsonProperty("ReleasedApprovers")]
        public ReleasedApprover[] ReleasedApprovers{ get; set; }

        /// <summary>
        /// 签署流程的签署截止时间。 值为unix时间戳,精确到秒,不传默认为当前时间七天后
        /// </summary>
        [JsonProperty("Deadline")]
        public long? Deadline{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "NeedRelievedFlowId", this.NeedRelievedFlowId);
            this.SetParamObj(map, prefix + "ReliveInfo.", this.ReliveInfo);
            this.SetParamArrayObj(map, prefix + "ReleasedApprovers.", this.ReleasedApprovers);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
        }
    }
}

