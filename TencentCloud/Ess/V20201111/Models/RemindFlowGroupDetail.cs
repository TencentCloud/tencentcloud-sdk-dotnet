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

    public class RemindFlowGroupDetail : AbstractModel
    {
        
        /// <summary>
        /// <p>该签署人在合同中的签署顺序</p>
        /// </summary>
        [JsonProperty("ApproverOrder")]
        public long? ApproverOrder{ get; set; }

        /// <summary>
        /// <p>签署人对应的签署id，签署方唯一编号，一个全局唯一的标识符，不同的流程不会出现冲突。</p><p>在<a href="https://qian.tencent.com/developers/companyApis/startFlows/CreateFlowSignUrl/">CreateFlowSignUrl</a>、<a href="https://qian.tencent.com/developers/companyApis/startFlows/CreateBatchQuickSignUrl/">CreateBatchQuickSignUrl</a>等接口生成签署链接时，可以通过查询合同流程的详情信息接口 <a href="https://qian.tencent.com/developers/companyApis/queryFlows/DescribeFlowInfo/">DescribeFlowInfo</a> 获取签署人的Signld，然后可以将此值传入，为该签署人创建签署链接。这样可以避免重复传输姓名、手机号、证件号等其他信息。</p>
        /// </summary>
        [JsonProperty("SignId")]
        public string SignId{ get; set; }

        /// <summary>
        /// <p>催办状态</p><p>枚举值：</p><ul><li>0： 成功</li><li>2： 无需催办</li><li>5： 超过次数限制</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>描述当前催办结果的原因</p>
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApproverOrder", this.ApproverOrder);
            this.SetParamSimple(map, prefix + "SignId", this.SignId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
        }
    }
}

