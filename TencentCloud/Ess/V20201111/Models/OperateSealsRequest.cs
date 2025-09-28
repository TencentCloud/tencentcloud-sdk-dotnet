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

    public class OperateSealsRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行本接口操作的员工信息。 注: 在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 代理企业和员工的信息。 在集团企业代理子企业操作的场景中，需设置此参数。在此情境下，ProxyOrganizationId（子企业的组织ID）为必填项。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 操作类型，int，目前支持传入以下类型：
        /// <ul><li>1：启用印章</li></ul>
        /// <ul><li>2：停用印章</li></ul>
        /// </summary>
        [JsonProperty("Act")]
        public long? Act{ get; set; }

        /// <summary>
        /// 需要操作的印章ID，数组形式，印章ID可从【web控制台->印章 】获取。
        /// </summary>
        [JsonProperty("SealIds")]
        public string[] SealIds{ get; set; }

        /// <summary>
        /// 个性化配置字段，默认不传。
        /// </summary>
        [JsonProperty("Options")]
        public Option[] Options{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamSimple(map, prefix + "Act", this.Act);
            this.SetParamArraySimple(map, prefix + "SealIds.", this.SealIds);
            this.SetParamArrayObj(map, prefix + "Options.", this.Options);
        }
    }
}

