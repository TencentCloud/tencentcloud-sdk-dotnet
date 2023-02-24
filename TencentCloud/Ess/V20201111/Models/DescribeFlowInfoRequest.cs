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

    public class DescribeFlowInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要查询的流程ID列表，限制最大100个
        /// </summary>
        [JsonProperty("FlowIds")]
        public string[] FlowIds{ get; set; }

        /// <summary>
        /// 调用方用户信息
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 代理相关应用信息，如集团主企业代子企业操作的场景中ProxyOrganizationId必填
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "FlowIds.", this.FlowIds);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
        }
    }
}

