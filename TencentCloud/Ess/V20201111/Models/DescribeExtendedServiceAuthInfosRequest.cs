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

    public class DescribeExtendedServiceAuthInfosRequest : AbstractModel
    {
        
        /// <summary>
        /// 操作人信息
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 代理相关应用信息，如集团主企业代子企业操作
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 扩展服务类型，默认为空，查询目前支持的所有扩展服务信息，单个指定则查询单个扩展服务开通信息，取值：
        /// OPEN_SERVER_SIGN：开通企业静默签署
        /// OVERSEA_SIGN：企业与港澳台居民签署合同
        /// MOBILE_CHECK_APPROVER：使用手机号验证签署方身份
        /// PAGING_SEAL：骑缝章
        /// BATCH_SIGN：批量签署
        /// </summary>
        [JsonProperty("ExtendServiceType")]
        public string ExtendServiceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "ExtendServiceType", this.ExtendServiceType);
        }
    }
}

