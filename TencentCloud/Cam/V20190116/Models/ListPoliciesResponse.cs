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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListPoliciesResponse : AbstractModel
    {
        
        /// <summary>
        /// 策略总数
        /// </summary>
        [JsonProperty("TotalNum")]
        public ulong? TotalNum{ get; set; }

        /// <summary>
        /// 策略数组，数组每个成员包括 policyId、policyName、addTime、type、description、 createMode 字段。其中： 
        /// policyId：策略 id 
        /// policyName：策略名
        /// addTime：策略创建时间
        /// type：1 表示自定义策略，2 表示预设策略 
        /// description：策略描述 
        /// createMode：1 表示按业务权限创建的策略，其他值表示可以查看策略语法和通过策略语法更新策略
        /// Attachments: 关联的用户数
        /// ServiceType: 策略关联的产品
        /// IsAttached: 当需要查询标记实体是否已经关联策略时不为null。0表示未关联策略，1表示已关联策略
        /// </summary>
        [JsonProperty("List")]
        public StrategyInfo[] List{ get; set; }

        /// <summary>
        /// 保留字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceTypeList")]
        public string[] ServiceTypeList{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalNum", this.TotalNum);
            this.SetParamArrayObj(map, prefix + "List.", this.List);
            this.SetParamArraySimple(map, prefix + "ServiceTypeList.", this.ServiceTypeList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

